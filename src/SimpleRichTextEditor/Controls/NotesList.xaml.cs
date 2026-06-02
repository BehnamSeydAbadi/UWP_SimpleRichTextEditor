using SimpleRichTextEditor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SimpleRichTextEditor.Controls
{
    public sealed partial class NotesList : UserControl
    {
        public List<Note> Notes
        {
            get { return (List<Note>)GetValue(NotesProperty); }
            set { SetValue(NotesProperty, value); }
        }

        public NotesList()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty NotesProperty = DependencyProperty.Register(
            name: nameof(Notes),
            propertyType: typeof(List<Note>),
            ownerType: typeof(NotesList),
            typeMetadata: new PropertyMetadata(null)
        );

        public event TypedEventHandler<object, Note> NoteClicked;

        private void NotesListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedNote = e.ClickedItem as Note;

            if (clickedNote is null) return;

            NoteClicked?.Invoke(this, clickedNote);
        }
    }
}
