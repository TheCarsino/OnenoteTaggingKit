﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace WetHatLab.OneNote.TaggingKit.common
{
    /// <summary>
    /// Tag formatting options.
    /// </summary>
    public enum TagFormat
    {
        /// <summary>
        /// Tags start with an uppercase letter.
        /// </summary>
        Capitalized = 0,

        /// <summary>
        /// Tags are lowercase, without spaces, and start with a '#'
        /// </summary>
        HashTag = 1,

        /// <summary>
        /// Tags are as entered by the user
        /// </summary>
        AsEntered = 2
    }

    /// <summary>
    /// Enumeration of types of Tagging Kit recognized page tags which appear on
    /// OneNote pages.
    /// </summary>
    /// <remarks>
    ///     This class implements the required interfaces to make it suitable
    ///     for HashSets.
    ///
    /// </remarks>
    public enum PageTagType
    {
        /// <summary>
        /// A regular page tag without any annotation.
        /// </summary>
        PlainTag = 0,
        /// <summary>
        /// A hashtag.
        /// </summary>
        HashTag,
        /// <summary>
        /// An importated OneNote tag.
        /// </summary>
        ImportedOneNoteTag,
        /// <summary>
        /// An imported hashtag.
        /// </summary>
        ImportedHashTag,

        /// <summary>
        /// Unknown tag type.
        /// </summary>
        /// <remarks>
        /// When passed to <see cref="PageTag.PageTag(string, PageTagType)"/>
        /// the type is inferred from the possibly annotated tagname.
        /// </remarks>
        Unknown,
    }
    /// <summary>
    /// Definition of page level tags which are recognized by the Tagging Kit.
    /// </summary>
    public class PageTag : ISortableKeyedItem<string, string>, IEquatable<PageTag> {
        const string cHashtagMarker = "#";
        const string cImportedHashtagMarker = "⏹";
        const string cImportedLegacyHashtagMarker = "📜";
        const string cImportedOneNoteTagMarker = "📑";
        const string cImportedOneNoteTagMarkerHTML = "&#128209;";
        const string cImportedLegacyHashtagMarkerHTML = "&#128220;";

        /// <summary>
        /// Predicate to determine if the page tags is right-to-left.
        /// </summary>
        public bool IsRTL { get; private set;  }

        /// <summary>
        /// Parse a comma separated list of tags.
        /// </summary>
        /// <remarks>
        /// This function does **not** handle HTML markup in the taglist.
        /// </remarks>
        /// <param name="tagnames">Collection of tag names.</param>
        /// <param name="format">Tag fromatting to apply.</param>
        /// <returns>
        ///     Collection of parsed tags. The collection may contain tags with the
        ///     same key but of different type.
        /// </returns>
        public static IEnumerable<PageTag> Parse(IEnumerable<string> tagnames, TagFormat format) {
             switch (format) {
                case TagFormat.AsEntered:
                    foreach (var tagname in tagnames) {
                        yield return new PageTag(tagname, PageTagType.Unknown);
                    }
                    break;
                case TagFormat.Capitalized:
                    foreach (var tagname in tagnames) {
                        var pt = new PageTag(tagname, PageTagType.Unknown);
                        if (pt.TagType == PageTagType.PlainTag) {
                            pt.BaseName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pt.BaseName);
                        }
                        yield return pt;
                     }
                    break;
                case TagFormat.HashTag:
                    foreach (var tagname in tagnames) {
                        var pt = new PageTag(tagname, PageTagType.Unknown);
                        if (pt.TagType == PageTagType.PlainTag) {
                            // switch over to hashtag
                            pt = new PageTag(pt.BaseName, PageTagType.HashTag);
                        }
                        // normalize name
                        yield return pt;
                    }
                    break;
            }
        }
        /// <summary>
        /// The type markers to watch out for on tag names.
        /// </summary>
        static readonly string[] _typeMarker = new string[] {
                cImportedOneNoteTagMarker,
                cImportedOneNoteTagMarkerHTML,
                cHashtagMarker,
                cImportedHashtagMarker,
                cImportedLegacyHashtagMarker,
                cImportedLegacyHashtagMarkerHTML,
        };
        /// <summary>
        /// The tag type associated with type markers.
        /// </summary>
        /// <remarks>The types associated with the marker strings in <see cref="_typeMarker"/> </remarks>
        static readonly PageTagType[] _typeOfMarker = new PageTagType[] {
            PageTagType.ImportedOneNoteTag,
            PageTagType.ImportedOneNoteTag,
            PageTagType.HashTag,
            PageTagType.ImportedHashTag,
            PageTagType.ImportedHashTag,
            PageTagType.ImportedHashTag,
        };

        /// <summary>
        /// Maps the members of the <see cref="PageTagType"/> enumeration to
        /// marker string.
        /// </summary>
        static readonly string[] _markerOfType = new string[] {
            string.Empty,
            cHashtagMarker,
            cImportedOneNoteTagMarker,
            cImportedHashtagMarker,
        };

        /// <summary>
        /// Get the type marker string associated with the tag.
        /// </summary>
        public string TagMarker { get => _markerOfType[(int)TagType]; }

        PageTagType _tagType = PageTagType.Unknown;
        /// <summary>
        /// Get or set the page tag type.
        /// </summary>
        public PageTagType TagType {
            get => _tagType;
            set {
                if (value != _tagType && value== PageTagType.HashTag) {
                    // enforce hashtag formatting
                    if (BaseName.Contains(" ")) {
                        BaseName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BaseName);
                        BaseName = BaseName.Replace(" ", string.Empty);

                    } else {
                        BaseName = BaseName.ToLower();
                    }
                }
                _tagType = value;
            }
        }

        /// <summary>
        /// Get the tag name as it is displayed on a OneNote page.
        /// </summary>
        /// <remarks>
        ///     The display name is composed of the <see cref="BaseName"/>
        ///     and an optional type prefix.
        /// </remarks>
        public string DisplayName { get => IsRTL ? BaseName + TagMarker:  TagMarker + BaseName; }

        /// <summary>
        /// Predicate to dermine if the tag has been imported.
        /// </summary>
        public bool IsImported {
            get => TagType == PageTagType.ImportedHashTag
                || TagType == PageTagType.ImportedOneNoteTag;
        }
        /// <summary>
        /// Get the basename of the tag.
        /// </summary>
        public string BaseName { get; private set; }

        #region ISortableKeyedItem<string, string>
        string _key;
        /// <summary>
        /// Get the tag sorting key.
        /// </summary>
        public string SortKey { get => _key; }

        /// <summary>
        /// Get the unique key of the tag,
        /// </summary>
        public string Key { get => _key; }
        #endregion ISortableKeyedItem<string, string>

        /// <summary>
        /// Initialize a new page tag instance.
        /// </summary>
        /// <param name="tagname">
        ///     The name of the tag. If the requested tag type is
        ///     <see cref="PageTagType.Unknown"/>, the tagname can have type
        ///     annotation. Otherwise the tagname must be an unannotated basename.
        /// </param>
        /// <param name="tagtype">
        ///     The type of tag to generate. If <see cref="PageTagType.Unknown"/>
        ///     the type is inferred from the type annotation on the tag name.
        /// </param>
        public PageTag(string tagname, PageTagType tagtype ) {
            bool rtl = false;
            if (tagtype == PageTagType.Unknown) {
                // infer type by inspecting the name
                string basename = null;
                for (int i = 0; i < _typeMarker.Length; i++) {
                    var marker = _typeMarker[i];
                    tagtype = _typeOfMarker[i];
                    if (tagname.StartsWith(marker,StringComparison.OrdinalIgnoreCase)) {
                        basename = tagname.Substring(marker.Length);
                        break;
                    } else if (tagname.EndsWith(marker, StringComparison.OrdinalIgnoreCase)) {
                        // for RTL language support
                        basename = tagname.Substring(0, tagname.Length - marker.Length);
                        rtl = i >= 2; // only hashtags
                        break;
                    }
                }
                if (basename == null) {
                    tagtype = PageTagType.PlainTag;
                } else {
                    tagname = basename;
                }
            } else if( tagtype == PageTagType.HashTag || tagtype == PageTagType.ImportedHashTag) {
                rtl = tagname.EndsWith(cHashtagMarker);
            }

            if (tagtype == PageTagType.HashTag || tagtype == PageTagType.ImportedHashTag) {
                // handle RTL for hashtags only
                IsRTL = rtl;
            }

            BaseName = tagtype != PageTagType.ImportedOneNoteTag ? tagname.Trim('#') : tagname;
            TagType = tagtype;
            _key = BaseName.Replace(" ", string.Empty).ToLower();
        }
        /// <summary>
        /// Create a persistable string representation of the page tag.
        /// </summary>
        /// <returns>Normalized string representation resembling a managed tag.</returns>
        public override string ToString() {
            if (TagType <= PageTagType.HashTag) {
                return DisplayName;
            }
            // make a new managed tag
            if (TagType == PageTagType.ImportedHashTag) {
                var tmp = new PageTag(BaseName, PageTagType.HashTag) {
                    IsRTL = this.IsRTL
                };
                return tmp.DisplayName;
            }
            return BaseName;
        }

        #region IEquatable<PageTag>
        /// <summary>
        /// Predicate to determine if two page tag objects are equal.
        /// </summary>
        /// <remarks>Comparison is based on the (unique) key.</remarks>
        /// <param name="other">The comparand.</param>
        /// <returns>`true` if page tags are equal.</returns>
        public bool Equals(PageTag other) => Key.Equals(other.Key);
        #endregion IEquatable<PageTag>

        /// <summary>Get the hash code for this page tag.</summary>
        /// <remarks>The hash code is based on the (unique) key.</remarks>
        /// <returns>The hash code for this page tag.</returns>
        public override int GetHashCode() => Key.GetHashCode();
    }
}
