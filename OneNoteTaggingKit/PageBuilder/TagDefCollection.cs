﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WetHatLab.OneNote.TaggingKit.common;

namespace WetHatLab.OneNote.TaggingKit.PageBuilder
{
    /// <summary>
    /// The enumeration of process types a tag can participate in.
    /// </summary>
    public enum TagProcessClassification
    {
        /// <summary>
        /// A OneNote tag in the page title whose name is the list of page tags.
        /// </summary>
        InTitleMarker = 0,
        /// <summary>
        /// A OneNote tag marling a one:T element containing a list of page tags.
        /// </summary>
        BelowTitleMarker,
        /// <summary>
        /// A regular, importable OneNote Paragrapg tag.
        /// </summary>
        OneNoteTag,
        /// <summary>
        /// A regular page tag.
        /// </summary>
        PageTag,
        /// <summary>
        /// A page tag denoting an imported OneNote tag.
        /// </summary>
        ImportedOneNoteTag,
        /// <summary>
        /// A page tag denoting an imported hashtag.
        /// </summary>
        ImportedHashTag,
    }
    /// <summary>
    /// A collection of tag definitions.
    /// </summary>
    /// <remarks>
    /// The collection does not compact. If
    /// </remarks>
    public class TagDefCollection : DefinitionObjectCollection<TagDef> {
        /// <summary>
        /// The now obsolete name for below title marker tags
        /// </summary>
        public const string sBelowTitleMarkerName = "Page Tags";

        /// <summary>
        /// The symbol for in-title and below-title markers.
        /// </summary>
        private const int cMarkerSymbol = 26;

        private const int InTitleMarkerType = 99;
        private const int BelowTitleMarkerType = 23;

        /// <summary>
        /// A dictionary of page tags indexed by tag name.
        /// </summary>
        Dictionary<string, TagDef> _pageTagDictionary = new Dictionary<string, TagDef>();

        void RegisterPageTagDefinition(TagDef t) {
            TagDef found;
            if (!_pageTagDictionary.TryGetValue(t.TagName, out found)) {
                _pageTagDictionary.Add(t.TagName, t);
            }
        }

        /// <summary>
        /// Get the tags process classification.
        /// </summary>
        /// <param name="def">The tag definition to classify.</param>
        /// <returns>The classification.</returns>
        public TagProcessClassification GetProcessClassification(TagDef def) {
            if (def.Symbol == 0) {
                if (Properties.Settings.Default.ImportHashtagMarker.Equals(def.TagType)) {
                    return TagProcessClassification.ImportedHashTag;
                } else if (Properties.Settings.Default.ImportOneNoteTagMarker.Equals(def.TagType)) {
                    return TagProcessClassification.ImportedOneNoteTag;
                } else {
                    return TagProcessClassification.PageTag;
                }
            } else {
                // check for special Process Tags
                switch (def.Symbol) {
                    case cMarkerSymbol:
                        switch (def.Type) {
                            case InTitleMarkerType:
                                return TagProcessClassification.InTitleMarker;
                            case BelowTitleMarkerType:
                                if (sBelowTitleMarkerName.Equals(def.Name)
                                    || def.Name.EndsWith(Properties.Settings.Default.PageTagMarker)) {
                                    return TagProcessClassification.BelowTitleMarker;
                                } else {
                                    return TagProcessClassification.OneNoteTag;
                                }

                            default:
                                // ordinary importable OneNote Tag
                                return TagProcessClassification.OneNoteTag;
                        }
                    default:
                        return TagProcessClassification.OneNoteTag;
                }
            }
        }
        /// Get the definition for in-title marker tags.
        public TagDef InTitleMarkerDef { get; private set; }
        /// <summary>
        /// Get the definition for below-title marker tags.
        /// </summary>
        public TagDef BelowTitleMarkerDef { get; private set; }

        /// <summary>
        /// Define a tag participating in a specified process.
        /// </summary>
        /// <param name="tagname">The name of the tag (without type annotation).</param>
        /// <param name="classification">Classification for the process tags
        /// based on this definition are participating in.</param>
        /// <returns>A new tag definition.</returns>
        public TagDef DefineProcessTag(string tagname,TagProcessClassification classification) {
            TagDef newdef = null;
            switch (classification) {
                case TagProcessClassification.BelowTitleMarker:
                    if (BelowTitleMarkerDef == null) {
                        BelowTitleMarkerDef = newdef = new TagDef(Page, tagname, Items.Count, Properties.Settings.Default.PageTagMarker, BelowTitleMarkerType, cMarkerSymbol);
                    }
                    break;
                case TagProcessClassification.InTitleMarker:
                    if (InTitleMarkerDef == null) {
                        InTitleMarkerDef = newdef = new TagDef(Page, tagname, Items.Count, string.Empty, InTitleMarkerType,cMarkerSymbol);
                    }
                    break;
                case TagProcessClassification.PageTag:
                    newdef = new TagDef(Page, tagname, Items.Count, string.Empty, Items.Count, 0);
                    RegisterPageTagDefinition(newdef);
                    break;
                case TagProcessClassification.ImportedOneNoteTag:
                    newdef = new TagDef(Page, tagname, Items.Count, Properties.Settings.Default.ImportOneNoteTagMarker, Items.Count, 0);
                    RegisterPageTagDefinition(newdef);
                    break;
                case TagProcessClassification.ImportedHashTag:
                    newdef = new TagDef(Page, tagname, Items.Count, Properties.Settings.Default.ImportHashtagMarker, Items.Count, 0);
                    RegisterPageTagDefinition(newdef);
                    break;
            }

            Add(newdef);
            return newdef;
        }
        /// <summary>
        /// Make sure all known regular page tags are defined.
        /// </summary>
        /// <remarks>This function should not be used for tagnames
        /// with type annotation e.g import markers.</remarks>
        /// <param name="tags">Names of regular page tags (not imported).</param>
        public void DefineKnownPageTags(IEnumerable<string> tags) {
            var tagset = new HashSet<string>(from string _ in tags
                                             let parsed = TagPageSet.ParseTagName(_)
                                             where string.IsNullOrEmpty(parsed.Item2) // regular tags only
                                             select parsed.Item1);

            // loop over the already known tag definitions to find matches.
            foreach (TagDef tagdef in Items) {
                if (tagset.Remove(tagdef.TagName)) {
                    TagDef found;
                    if (!_pageTagDictionary.TryGetValue(tagdef.TagName, out found)) {
                        RegisterPageTagDefinition(tagdef);
                    }
                    tagdef.TagType = string.Empty; // update to regular tag type
                }
            }
            // for all remaining tags we need to create new definitions
            foreach (string name in tagset) {
                _ = DefineProcessTag(name,TagProcessClassification.PageTag);
            }
         }

        /// <summary>
        /// Define tags from hashtags found in page content.
        /// </summary>
        /// <param name="hashtags"></param>
        public void DefineContentHashtags(IEnumerable<string> hashtags) {
            var hashtagset = new HashSet<string>(hashtags);
            // loop over the already known tag definitions to find matches.
            foreach (TagDef tagdef in Items) {
                if (hashtagset.Remove(tagdef.TagName)) {
                    tagdef.TagType = Properties.Settings.Default.ImportHashtagMarker;
                    RegisterPageTagDefinition(tagdef);
                } else if  (GetProcessClassification(tagdef) == TagProcessClassification.ImportedHashTag) {
                    // dispose that definition if it is a hashtag
                    tagdef.Dispose();
                }
            }
            // for all remaining hashtags we need to create new definitions
            foreach (string name in hashtagset) {
                _ = DefineProcessTag(name,TagProcessClassification.ImportedHashTag);
            }
        }
        /// <summary>
        /// Define the tags which should be on the page.
        /// </summary>
        /// <remarks>All definitions for tags not in the given list are removed</remarks>
        /// <param name="tags">list of tags without type annotation.</param>
        public void DefinePageTags(IEnumerable<string> tags) {
            var tagset = new HashSet<string>(tags);

            // make sure only those tags are defined
            foreach (TagDef td in _pageTagDictionary.Values) {
                if (!tagset.Contains(td.TagName)
                    && GetProcessClassification(td) == TagProcessClassification.PageTag) {
                    td.Dispose();
                    IsModified = true;
                }
            }
            // define missing tags
            DefineKnownPageTags(tags);
        }
        /// <summary>
        /// Intitialize the collection of tag definitions selected from an
        /// OneNote page document.
        /// </summary>
        /// <param name="page">The OneNote page document proxy.</param>
        public TagDefCollection(OneNotePage page) : base(page, page.GetName(nameof(TagDef))) {
            if (Properties.Settings.Default.MapOneNoteTags) {
                // define mapped OneNote tags
                var onTags = new HashSet<string>(from TagDef _ in Items
                                                 where GetProcessClassification(_) == TagProcessClassification.OneNoteTag
                                                 select _.Name);
                foreach (var tagdef in Items) {
                    if (onTags.Remove(tagdef.TagName)) {
                        // found existing tag which we can use
                        tagdef.TagType = Properties.Settings.Default.ImportOneNoteTagMarker;
                        RegisterPageTagDefinition(tagdef);
                    } else if (GetProcessClassification(tagdef) == TagProcessClassification.ImportedOneNoteTag) {
                        // that tag is no longer on the page
                        tagdef.Dispose();
                    }
                }

                // Need import tag definitions for the remaining unmatched OneNote tags.
                foreach (string ontagname in onTags) {
                    _ = DefineProcessTag(ontagname, TagProcessClassification.ImportedHashTag);
                }
            }
            // use the in-title tag to define more page tags.
            if (InTitleMarkerDef != null) {
                DefineKnownPageTags(InTitleMarkerDef.Name.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        /// <summary>
        /// Create a new instance of a tag definition proxy object
        /// and intialize it with a corresponting XML element from a
        /// OneNote page.
        /// </summary>
        /// <param name="e">XML tag definition element from a OneNote page.</param>
        /// <returns>Ne instance of a tag definition proxy object.</returns>
        protected override TagDef CreateElementProxy(XElement e) {
            var tagdef = new TagDef(Page,e);
            switch (GetProcessClassification(tagdef)) {
                case TagProcessClassification.BelowTitleMarker:
                    BelowTitleMarkerDef = tagdef;
                    break;
                case TagProcessClassification.InTitleMarker:
                    InTitleMarkerDef = tagdef;
                    break;
            }
            // We do not pick up page tags here because we are not certain
            // that they qualify. May be somebody has used tags with symbol=0
            // somewhere on the page.
            return tagdef;
        }

        /// <summary>
        /// Get the collection of defined page tags.
        /// </summary>
        /// <value>Collection of tag definitions.</value>
        public IEnumerable<TagDef> DefinedPageTags {
            get {
                return from TagDef _ in _pageTagDictionary.Values
                       where !_.IsDisposed
                       select _;
            }
        }
        /// <summary>
        /// Add a new tag definition
        /// </summary>
        /// <param name="td">Tag definition proxy object.</param>
        protected override void Add(TagDef td) {
            if (td.Symbol == 0) {
                // make sure the type is unique
                td.Type = Items.Count;
            }
            base.Add(td);
        }
        /// <summary>
        /// Get a comma separated list of page tags.
        /// </summary>
        public override string ToString() {
            return string.Join(",", from TagDef _ in _pageTagDictionary.Values
                                    where ! _.IsDisposed
                                    orderby _.TagName ascending
                                    select _);
        }
    }
}
