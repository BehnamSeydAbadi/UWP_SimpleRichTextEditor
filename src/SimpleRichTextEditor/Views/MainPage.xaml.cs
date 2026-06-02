using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleRichTextEditor.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void EditorToolbar_BlackClicked(object sender, EventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Black;
        }

        private void EditorToolbar_RedClicked(object sender, EventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Red;
        }

        private void EditorToolbar_BlueClicked(object sender, EventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Blue;
        }

        private void EditorToolbar_YellowBackgroundClicked(object sender, EventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.BackgroundColor = Colors.Yellow;
        }

        private void EditorToolbar_ClearBackgroundClicked(object sender, EventArgs e)
        {
            Editor.Document.Selection.CharacterFormat.BackgroundColor = Colors.Transparent;
        }
    }
}
