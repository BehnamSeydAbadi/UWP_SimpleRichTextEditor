using SimpleRichTextEditor.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SimpleRichTextEditor.Controls
{
    public sealed partial class NoteListItem : UserControl
    {
        public Note Note
        {
            get { return (Note)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }

        public NoteListItem()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty NoteProperty = DependencyProperty.Register(
            name: nameof(Note),
            propertyType: typeof(Note),
            ownerType: typeof(NoteListItem),
            typeMetadata: new PropertyMetadata(null)
        );
    }
}
