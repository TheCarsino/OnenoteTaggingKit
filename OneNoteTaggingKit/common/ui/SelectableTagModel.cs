using System.Windows;

using System.Text;
using System.Linq;

namespace WetHatLab.OneNote.TaggingKit.common.ui
{
    /// <summary>
    /// View model for tags which change state when they are selected.
    /// </summary>
    public class SelectableTagModel : FilterableTagModel
    {
        bool _isSelected = false;

        /// <summary>
        /// Create a new instance of the view model.
        /// </summary>6
        public SelectableTagModel()
        {
            IsSelected = false;
        }

        private TagPageSet _tag;

        /// <summary>
        /// Set the page tag which keeps track of the pages having this
        /// tag.
        /// </summary>
        /// <remarks>
        /// The page tag is used to provide the page count
        /// (number of pages with this tag). If the page count is 0, the
        /// tag isn't used anywhere.
        /// </remarks>
        internal TagPageSet PageTag
        {
            get => _tag;
            set
            {
                _tag = value;
                if (Tag == null)
                {
                    Tag = value.Tag;
                }
            }
        }

        /// <summary>
        /// Get/set the tag selection flag.
        /// </summary>
        /// <remarks>Selected tags are collapsed.</remarks
        public bool IsSelected {
            get => _isSelected;
            set {
                if (_isSelected != value) {
                    _isSelected = value;
                    UpdateTagVisibility();
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Compute the visibility based on changes to the <see cref="IsSelected"/>
        /// and/or <see cref="FilterableTagModel.HighlightedTagName"/> property.
        /// </summary>
        protected override void UpdateTagVisibility() {
            if (IsSelected) {
                TagVisibility = Visibility.Collapsed;
            } else {
                base.UpdateTagVisibility();
            }
        }

        public override string ToString()
        {
            return GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }
}
