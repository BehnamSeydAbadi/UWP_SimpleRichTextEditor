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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleRichTextEditor.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NotesListPage : Page
    {
        public NotesListPage()
        {
            this.InitializeComponent();

            MyNotesList.Notes = new List<Note>
            {
                new Note
                {
                    Id = 1,
                    Title = "Meeting Notes",
                    Content = "Call supplier tomorrow and revise the draft document...",
                    ModifiedAt = DateTime.Now
                },
                new Note
                {
                    Id = 2,
                    Title = "Shopping List",
                    Content = "Milk, Bread, Eggs",
                    ModifiedAt = DateTime.Now.AddHours(-2)
                },
                new Note
                {
                    Id = 3,
                    Title = "Ideas",
                    Content = "Build a simple UWP notes app for Lumia",
                    ModifiedAt = DateTime.Now.AddDays(-1)
                }
            };
        }

        private void MyNotesList_NoteClicked(object sender, Note e)
        {
            Frame.Navigate(typeof(MainPage), e.Id);
        }
    }
}
