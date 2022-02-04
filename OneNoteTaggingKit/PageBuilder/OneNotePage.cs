﻿// Author: WetHat | (C) Copyright 2013 - 2017 WetHat Lab, all rights reserved
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using WetHatLab.OneNote.TaggingKit.common;
using WetHatLab.OneNote.TaggingKit.Tagger;

namespace WetHatLab.OneNote.TaggingKit.PageBuilder
{
    /// <summary>
    /// Enumeration of ways to display tags on a Onenote Page
    /// </summary>
    public enum TagDisplay
    {
        /// <summary>
        /// Display tags as comma separated text below the title.
        /// </summary>
        BelowTitle,

        /// <summary>
        /// Display the tags a single OneNote tag whose name is comma separated tag names.
        /// </summary>
        InTitle
    }

    /// <summary>Sequence positions of page structure elements</summary>
    /// <remarks>
    /// <code lang="xml">
    /// // Sequence of elements below the page tag
    /// <xsd:element name="TagDef" type="TagDef" minOccurs="0" maxOccurs="unbounded"/>[
    /// <xsd:element name="QuickStyleDef" type="QuickStyleDef" minOccurs="0" maxOccurs="unbounded"/>
    /// <xsd:element name="XPSFile" type="XPSFile" minOccurs="0" maxOccurs="unbounded"/>
    /// <xsd:element name="Meta" type="Meta" minOccurs="0" maxOccurs="unbounded"/>
    /// <xsd:element name="MediaPlaylist" type="MediaPlaylist" minOccurs="0"/>
    /// <xsd:element name="MeetingInfo" type="MeetingInfo" minOccurs="0"/>
    /// <xsd:element name="PageSettings" type="PageSettings" minOccurs="0"/>
    /// <xsd:element name="Title" type="Title" minOccurs="0"/>
    /// </code>
    /// </remarks>
    public enum PageSchemaPosition
    {
        /// <summary>
        /// Position of tag definition elements on a OneNote page.
        /// </summary>
        TagDef = 0,
        // <summary>
        /// Position of style definition elements on a OneNote page.
        /// </summary>
        QuickStyleDef = 1,

        XPSFile = 2,

        /// <summary>
        /// Position of _Meta_ elements on a OneNote page.
        /// </summary>
        Meta = 3,

        MediaPlaylist = 4,

        MeetingInfo = 5,

        PageSettings = 6,

        /// <summary>
        /// Position of the _Title_ element on a OneNote page.
        /// </summary>
        Title = 7,

        /// <summary>
        /// Position of the _Outline_ elements on a OneNote page.
        /// </summary>
        Outline = 8
    }

    /// <summary>
    /// Local representation of a OneNote Page
    /// </summary>
    /// <remarks>
    ///     Supports:
    ///     <list type="bullet">
    ///     <item>tag related operations</item>
    ///     <item>limited page editing</item>
    ///     </list>
    /// </remarks>
    public class OneNotePage {
        private static readonly Regex _hashtag_matcher = new Regex(@"(?<=(^|[^\w]))#\w{3,}", RegexOptions.Compiled);
        private static readonly Regex _number_matcher = new Regex(@"^#\d*\w{0,1}\d*$|^#[xX]{0,1}[\dABCDEFabcdef]+$", RegexOptions.Compiled);
        private static readonly Regex _tag_matcher = new Regex(@"</*(a|span)[^<>]*>", RegexOptions.Compiled);

        /// <summary>
        /// The sequence of structure elements in which elements have to
        /// appear on a OneNote page.
        /// </summary>
        /// <remarks>
        /// The schema for stucture elements on a OneNote page is defined as:
        /// <code lang="xml">
        /// // Sequence of elements below the page tag
        /// <xsd:element name="TagDef" type="TagDef" minOccurs="0" maxOccurs="unbounded"/>[
        /// <xsd:element name="QuickStyleDef" type="QuickStyleDef" minOccurs="0" maxOccurs="unbounded"/>
        /// <xsd:element name="XPSFile" type="XPSFile" minOccurs="0" maxOccurs="unbounded"/>
        /// <xsd:element name="Meta" type="Meta" minOccurs="0" maxOccurs="unbounded"/>
        /// <xsd:element name="MediaPlaylist" type="MediaPlaylist" minOccurs="0"/>
        /// <xsd:element name="MeetingInfo" type="MeetingInfo" minOccurs="0"/>
        /// <xsd:element name="PageSettings" type="PageSettings" minOccurs="0"/>
        /// <xsd:element name="Title" type="Title" minOccurs="0"/>
        /// </code>
        /// </remarks>

        static readonly string[] PositionNames = new string[] { "TagDef", "QuickStyleDef", "XPSFile", "Meta", "MediaPlaylist", "MeetingInfo", "PageSettings", "Title", "Outline" };

        /// <summary>
        /// Map available structure element proxies to page location indices.
        /// </summary>
        static readonly Dictionary<Type, int> _typeToIndex = new Dictionary<Type, int>() {
            [typeof(TagDef)] = (int)PageSchemaPosition.TagDef,
            [typeof(QuickStyleDef)] = (int)PageSchemaPosition.QuickStyleDef,
            [typeof(Meta)] = (int)PageSchemaPosition.Meta,
            [typeof(Title)] = (int)PageSchemaPosition.Title,
        };

        XElement[] PageAnchors = new XElement[] { null, null, null, null, null, null, null, null, null };
        QuickStyleDefCollection _styles;
        MetaCollection _meta; // Page Meta information
        TagDefCollection _tagdef; // OneNote tag definitions.

        private DateTime _lastModified;
        /// <summary>
        /// Get the XML namespace for elements in OneNote XML page documents.
        /// </summary>
        public XNamespace Namespace { get; private set; }

        // the OneNote application object
        private OneNoteProxy _onenote;

        /// <summary>
        /// Get a XML Name for elements on a OneNote page document.
        /// </summary>
        /// <param name="localname"></param>
        /// <returns>XML name in the OneNote page document namespace.</returns>
        public XName GetName(string localname) => Namespace.GetName(localname);

        /// <summary>
        /// Get the XML document of the OneNote page
        /// </summary>
        public XDocument Document { get; private set; }
        /// <summary>
        /// Get he XML Root element of the OneNote page document.
        /// </summary>
        public XElement Root { get; private set; }

        OE _belowTitleTags;

        HashSet<string> _hashtags = new HashSet<string>(); // imported hashtags
        /// <summary>
        /// Get the proxy object for the 'one:Title' element of the OneNote page
        /// document.
        /// </summary>
        public Title Title { get; private set; }

        internal OneNotePage(OneNoteProxy onenoteApp, string pageID) {
            _onenote = onenoteApp;
            PageID = pageID;
            Document = _onenote.GetPage(PageID); // get the page's XML document
            Root = Document.Root;
            Namespace = Document.Root.GetNamespaceOfPrefix("one");
            _lastModified = DateTime.Parse(Root.Attribute("lastModifiedTime").Value);

            // recognize some page content

            _styles = new QuickStyleDefCollection(this);
            _meta = new MetaCollection(this);
            _tagdef = new TagDefCollection(this);

            XElement title = Root.Element(GetName(nameof(Title)));
            if (title == null) {
                // a title is required for tagging
                Title = new Title(this, "Untitled Page");
            } else {
                Title = new Title(this, title);
                // inspect the title tags an mark some of them as page tags
                _tagdef.DefineKnownPageTags(from i in Title.Tags.TagIndices
                                            let td = _tagdef[i]
                                            where _tagdef.GetProcessClassification(td) == TagProcessClassification.PageTag
                                            select td.TagName);
            }

            // make sure all tags recorded in the page's meta informations are defined
            _tagdef.DefineKnownPageTags(TaggedPage.ParseTaglist(_meta.PageTags));

            // For performance reasons we are going to delete all outlines not related to tags
            // Note: Page updates will actually leave those removed outlines on the page.
            List<XElement> outlinesToDelete = new List<XElement>();
            XName outlineName = GetName("Outline");

            // For performance reasons we avoid Xpath!
            foreach (var outline in Root.Elements(outlineName).ToList()) {
                XElement OEChildren = outline.Element(GetName("OEChildren"));
                if (OEChildren != null) {
                    // further inspect that outline
                    if (_tagdef.BelowTitleMarkerDef != null) {
                        // there is a below title taglist on the page
                        // the outline we are looking for has one <one:OEChildren> element with
                        // one <one:OE> element containing a <one:Tag> with the given index
                        // The tag outline element lookis like this
                        // <one:Outline author="Peter Ernst" authorInitials="PE" lastModifiedBy="Peter Ernst" lastModifiedByInitials="PE" objectID="{E470786C-A904-4E9F-AC3B-0D9F36B6FC54}{14}{B0}" lastModifiedTime="2013-12-06T16:04:48.000Z">
                        //   <one:Position x="236.249984741211" y="42.1500015258789" z="0" />
                        //   <one:Size width="90.8847274780273" height="10.9862976074219" />
                        //   <one:OEChildren>
                        //     <one:OE objectID="{E470786C-A904-4E9F-AC3B-0D9F36B6FC54}{15}{B0}" lastModifiedTime="2013-12-06T16:04:48.000Z" quickStyleIndex="1" creationTime="2013-12-06T16:03:50.000Z">
                        //       <one:Tag index="0" completed="true" creationDate="2013-12-06T15:55:59.000Z" completionDate="2013-12-06T15:55:59.000Z" />
                        //       <one:T><![CDATA[Gdfgdf, sdfdsf]]></one:T>
                        //     </one:OE>
                        //   </one:OEChildren>
                        // </one:Outline>

                        XElement oelement = OEChildren.Element(GetName("OE"));
                        if (oelement != null) {
                            // make a proxy for that
                            var oe = new OE(oelement);
                            if (oe.Tags.ContainsTag(_tagdef.BelowTitleMarkerDef.Index)) {
                                _belowTitleTags = oe;
                                // collect these tags too
                                _tagdef.DefineKnownPageTags(ParseTags(oe.Element.Value));
                                // delete the Indents as they tend to cause errors
                                XElement indents = outline.Element(GetName("Indents"));
                                if (indents != null) {
                                    indents.Remove();
                                }
                                continue; // keep this outline
                            }
                        }
                    }
                    if (Properties.Settings.Default.MapHashTags) {
                        // make sure all hashtags in that outline are defined
                        foreach (var t in outline.Descendants(GetName("T"))) {
                            // remove some non-sensical tags from the text
                            string txt = _tag_matcher.Replace(t.Value, string.Empty);
                            _hashtags.UnionWith(from Match m in _hashtag_matcher.Matches(txt)
                                                 where !_number_matcher.Match(m.Value).Success
                                                 select m.Value);
                        }
                    }
                }
                outline.Remove();
            }
        }

        /// <summary>
        /// Determine if this page is in the recycle bin.
        /// </summary>
        public bool IsDeleted {
            get {

                XAttribute recycleBinAtt = Root.Attribute("isInRecycleBin");
                return recycleBinAtt != null && "true".Equals(recycleBinAtt.Value);
            }
        }

        /// <summary>
        /// Get or set the unique ID of the OneNote Page
        /// </summary>
        internal string PageID { get; private set; }

        /// <summary>
        /// Get/set the page tags.
        /// </summary>
        /// <value>Collection of tag names without type annotation</value>
        public IEnumerable<string> PageTags {
            get => from TagDef def in _tagdef.DefinedPageTags
                   where _tagdef.GetProcessClassification(def) == TagProcessClassification.PageTag
                   select def.TagName;
            set => _tagdef.DefinePageTags(value);
        }

        /// <summary>
        /// Parse a comma separated list of tag names into an array.
        /// </summary>
        /// <param name="tags">comma separated list of tags</param>
        /// <returns>array of tag names</returns>
        static IEnumerable<string> ParseTags(string tags) {
            if (!string.IsNullOrEmpty(tags)) {
                // remove all HTML markup
                return from string tag in TaggedPage.ParseTaglist(tags)
                       where !tag.Contains("&#") // no Emoji HTML entities
                       select _tag_matcher.Replace(tag,string.Empty).Trim(); // remove HTML Markup
            }
            return new string[0];
        }

        /// <summary>
        /// Save all changes to the page to OneNote
        /// </summary>
        internal void Update() {

            // define import tags
            string[] savedTags = (from TagDef def in _tagdef.DefinedPageTags
                                  select def.Name).ToArray();
            if (ApplyTagsToPage()) {
                try {
                    _onenote.UpdatePage(Document, _lastModified);
                } catch (COMException ce) {
                    unchecked {
                        switch ((uint)ce.ErrorCode) {
                            case 0x80042010: // concurrent page modification
                                TraceLogger.Log(TraceCategory.Error(), "The last modified date does not match. Concurrent page modification: {0}\n Rescheduling tagging job.", ce.Message);
                                _onenote.TaggingService.Add(new TaggingJob(PageID, savedTags, TagOperation.REPLACE));
                                break;

                            case 0x80042030: // blocked by modal dialog
                                TraceLogger.ShowGenericErrorBox(Properties.Resources.TaggingKit_Blocked, ce);
                                _onenote.TaggingService.Add(new TaggingJob(PageID, savedTags, TagOperation.REPLACE));
                                break;

                            default:
                                throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add a page structure element at the correct location on a
        /// OneNote page XML document.
        /// </summary>
        /// <remarks>
        ///     Makes use of an internal lookup table containing anchor elements
        ///     known to be at certain schema positions.
        /// </remarks>
        /// <param name="obj">The proxy object containing the element to add to the page.</param>
        public void Add(PageStructureObjectBase obj) {
            int p = _typeToIndex[obj.GetType()];
            XElement anchor = PageAnchors[p];
            if (anchor == null || anchor.Parent == null) {
                // need to go searching
                for (int i = p; i < PositionNames.Length; i++) {
                    var localname = PositionNames[i];
                    anchor = Root.Element(obj.GetName(localname));
                    if (anchor != null) {
                        PageAnchors[i] = anchor; // remember that
                        break;
                    }
                }
            }
            if (anchor != null) {
                anchor.AddBeforeSelf(obj.Element);
            } else {
                Root.Add(obj.Element);
            }
            PageAnchors[p] = obj.Element;
        }
        /// <summary>
        /// Add tags to the page as specified by the <see cref="TagDisplay" /> enumeration.
        /// </summary>
        /// <returns><i>true</i> if a page update is needed; <i>false</i> otherwise</returns>
        private bool ApplyTagsToPage() {
            // import tags from page content
            _tagdef.ImporteOneNoteTags();
            _tagdef.ImportContentHashtags(_hashtags);
            bool specChanged = _tagdef.IsModified;
            // update the meta information of the page
            string taglist = string.Join(", ", from TagDef td in _tagdef.DefinedPageTags
                                               orderby td.TagName.ToLower().TrimStart('#') ascending
                                               select td.Name);
            _meta.PageTags = taglist;
            specChanged = specChanged || _meta.IsModified;

            // Cleanup obsolete Tag display
            switch ((TagDisplay)Properties.Settings.Default.TagDisplay) {
                case TagDisplay.InTitle:
                    if (_belowTitleTags != null && !string.IsNullOrEmpty(_belowTitleTags.ElementId)) {
                        if (_tagdef.BelowTitleMarkerDef != null) {
                            // this tag definition has to go
                            _tagdef.BelowTitleMarkerDef.Dispose();
                        }
                        // the corresponding outline too
                        _onenote.DeletePageContent(PageID, _belowTitleTags.Element.Parent.Parent.Attribute("objectID").Value);
                        specChanged = true;
                    }
                    break;
                case TagDisplay.BelowTitle:
                    if (_tagdef.InTitleMarkerDef != null) {
                        Title.Tags.RemoveTag(_tagdef.InTitleMarkerDef.Index);
                        _tagdef.InTitleMarkerDef.Dispose();
                        specChanged = true;
                    }
                    break;
            }

            TagCollection titletags = Title.Tags;
            var pagetagset = new HashSet<int>(from TagDef def in _tagdef.DefinedPageTags
                                              select def.Index);
            var titletagset = new HashSet<int>(from int i in titletags.TagIndices
                                               where !_tagdef[i].IsDisposed
                                               select i);
            titletagset.UnionWith(from TagDef def in _tagdef.DefinedPageTags
                                  select def.Index);

            switch ((TagDisplay)Properties.Settings.Default.TagDisplay) {
                case TagDisplay.InTitle:
                    TagDef inTitleMarker = _tagdef.DefineProcessTag(taglist, TagProcessClassification.InTitleMarker);
                    titletagset.Add(inTitleMarker.Index);
                    specChanged = true;
                    break;
                case TagDisplay.BelowTitle:
                    if (_tagdef.InTitleMarkerDef != null) {
                        titletagset.Remove(_tagdef.InTitleMarkerDef.Index);
                        _tagdef.InTitleMarkerDef.Dispose();
                        specChanged = true;
                    }
                    if (_belowTitleTags == null) {
                        // create a new outline for below-title tags
                        //
                        //<one:Outline author="Peter Ernst" authorInitials="PE" lastModifiedBy="Peter Ernst" lastModifiedByInitials="PE" objectID="{E470786C-A904-4E9F-AC3B-0D9F36B6FC54}{14}{B0}" lastModifiedTime="2013-12-06T16:04:48.000Z">
                        //  <one:Position x="236.249984741211" y="42.1500015258789" z="0" />
                        //  <one:Size width="90.8847274780273" height="10.9862976074219" />
                        //  <one:OEChildren>
                        //    <one:OE objectID="{E470786C-A904-4E9F-AC3B-0D9F36B6FC54}{15}{B0}" lastModifiedTime="2013-12-06T16:04:48.000Z" quickStyleIndex="1" creationTime="2013-12-06T16:03:50.000Z">
                        //      <one:Tag index="0" completed="true" creationDate="2013-12-06T15:55:59.000Z" completionDate="2013-12-06T15:55:59.000Z" />
                        //      <one:T><![CDATA[Gdfgdf, sdfdsf]]></one:T>
                        //    </one:OE>
                        //  </one:OEChildren>
                        //</one:Outline>
                        XElement oe;
                        XElement outline = new XElement(GetName("Outline"),
                                           new XElement(GetName("Position"),
                                               new XAttribute("x", "236"),
                                               new XAttribute("y", "43"),
                                               new XAttribute("z", "0")),
                                           new XElement(GetName("Size"),
                                               new XAttribute("width", "400"),
                                               new XAttribute("height", "10"),
                                               new XAttribute("isSetByUser", "true")),
                                           new XElement(GetName("OEChildren"),
                                         (oe = new XElement(GetName("OE"),
                                                  new XAttribute("quickStyleIndex", _styles.TagOutlineStyleDef.Index),
                                                  new XElement(GetName("T"), taglist)))));
                        Root.Add(outline);
                        _belowTitleTags = new OE(oe);
                        specChanged = true;
                    } else if (specChanged) {
                        // update the tag text
                        var T = _belowTitleTags.Element.Element(GetName("T"));
                        if (T == null) {
                            _belowTitleTags.Element.Add(new XElement(GetName("T")));
                        }
                        T.Value = taglist;
                    }
                    // turn spellcheck off for tag lists.
                    _belowTitleTags.Element.SetAttributeValue("lang", "yo");

                    TagDef belowTitleMarker = _tagdef.DefineProcessTag(TagDefCollection.sBelowTitleMarkerName, TagProcessClassification.BelowTitleMarker);

                    // add marker tag
                    _belowTitleTags.Tags.TagIndices = new int[] { belowTitleMarker.Index };

                    break;
            }

            titletags.TagIndices = titletagset;
            return specChanged || _tagdef.IsModified;
        }
    }
}