using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SimpleRichTextEditor.Controls
{
    public sealed partial class EditorToolbar : UserControl
    {
        public event EventHandler BlackClicked;
        public event EventHandler RedClicked;
        public event EventHandler BlueClicked;
        public event EventHandler YellowBackgroundClicked;
        public event EventHandler ClearBackgroundClicked;

        public EditorToolbar()
        {
            this.InitializeComponent();
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            BlackClicked?.Invoke(this, EventArgs.Empty);
            //Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Black;
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            RedClicked?.Invoke(this, EventArgs.Empty);
            //Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Red;
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            BlueClicked?.Invoke(this, EventArgs.Empty);
            //Editor.Document.Selection.CharacterFormat.ForegroundColor = Colors.Blue;
        }

        private void YellowBackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            YellowBackgroundClicked?.Invoke(this, EventArgs.Empty);
            //Editor.Document.Selection.CharacterFormat.BackgroundColor = Colors.Yellow;
        }

        private void ClearBackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            ClearBackgroundClicked?.Invoke(this, EventArgs.Empty);
            //Editor.Document.Selection.CharacterFormat.BackgroundColor = Colors.Transparent;
        }
    }
}
