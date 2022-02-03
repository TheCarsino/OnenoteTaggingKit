﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace WetHatLab.OneNote.TaggingKit.PageBuilder
{
    /// <summary>
    /// Proxy object class for `one:QuickStyleDef` style definition elements
    /// on a OneNote page document.
    /// </summary>
    public class QuickStyleDef : DefinitionObjectBase {

        System.Drawing.Font _styleFont;
        /// <summary>
        /// Get the font of this style.
        /// </summary>
        public System.Drawing.Font Font {
            get => _styleFont;
            set {
                _styleFont = value;
                SetAttributeValue("font", value.Name);
                SetAttributeValue("fontSize", value.Size.ToString());
                SetAttributeValue("bold", value.Bold.ToString().ToLower());
                SetAttributeValue("italic", value.Italic.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get/set the font color.
        /// </summary>
        public Color FontColor {
            get {
                var color = GetAttributeValue("fontColor");
                return color != null ? (Color)ColorConverter.ConvertFromString(color) : default(Color);
            }
            set  => SetAttributeValue("fontColor", "#" + value.ToString().Substring(3));
        }

        /// <summary>
        /// Initialize a new proxy object for a style definition element on
        /// a OneNote page document.
        /// </summary>
        /// <param name="page">Proxy of the OneNote page.</param>
        /// <param name="element">The style definition element selected from a OneNote page
        /// definition element.</param>
        public QuickStyleDef(OneNotePage page, XElement element) : base(page,element) {
            var style = System.Drawing.FontStyle.Regular;

            if ("true".Equals(GetAttributeValue("bold"),StringComparison.InvariantCultureIgnoreCase)) {
                style |= System.Drawing.FontStyle.Bold;
            }
            if ("true".Equals(GetAttributeValue("italic"), StringComparison.InvariantCultureIgnoreCase)) {
                style |= System.Drawing.FontStyle.Italic;
            }
            var f = new System.Drawing.Font(GetAttributeValue("font"),
                                            float.Parse(GetAttributeValue("fontSize")),
                                            style);
        }

        /// <summary>
        /// Initialize proxy object
        /// </summary>
        /// <param name="page">OneNote page proxy object</param>
        /// <param name="name">Style name.</param>
        /// <param name="index">Style definition index.</param>
        /// <param name="font">The style font</param>
        /// <param name="fontColor">Fint foreground color</param>
        public QuickStyleDef(OneNotePage page, string name, int index, System.Drawing.Font font, Color fontColor)
            : base(page,
                  new XElement(page.GetName(nameof(QuickStyleDef)),
                      new XAttribute("highlightColor", "automatic")  ),
                  name,
                  index) {
            Font = font;
            FontColor = fontColor;
        }
    }
}
