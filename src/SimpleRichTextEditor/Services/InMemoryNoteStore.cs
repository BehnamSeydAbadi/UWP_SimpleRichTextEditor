using SimpleRichTextEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleRichTextEditor.Services
{
    public static class InMemoryNoteStore
    {
        private static List<Note> _notes = new List<Note>
        {
            new Note
            {
                Id = 1,
                Title = "Shopping List",
                Content = "Milk\nEggs\nTea",
                ModifiedAt = DateTime.Now.AddMinutes(-30)
            },
            new Note
            {
                Id = 2,
                Title = "Work",
                Content = "Call client\nSend report",
                ModifiedAt = DateTime.Now.AddHours(-2)
            },
            new Note
            {
                Id = 3,
                Title = "Ideas",
                Content = "Simple UWP notes app\nDark theme maybe later",
                ModifiedAt = DateTime.Now.AddDays(-1)
            }
        };

        public static List<Note> GetAll()
        {
            return _notes.OrderByDescending(n => n.ModifiedAt).ToList();
        }

        public static Note GetById(int id)
        {
            return _notes.FirstOrDefault(n => n.Id == id);
        }

        public static void Update(Note updatedNote)
        {
            var existing = _notes.FirstOrDefault(n => n.Id == updatedNote.Id);
            if (existing == null) return;

            existing.Title = updatedNote.Title;
            existing.Content = updatedNote.Content;
            existing.ModifiedAt = DateTime.Now;
        }

        public static Note CreateNew()
        {
            int nextId = _notes.Any() ? _notes.Max(n => n.Id) + 1 : 1;

            var note = new Note
            {
                Id = nextId,
                Title = "New Note",
                Content = "",
                ModifiedAt = DateTime.Now
            };

            _notes.Insert(0, note);
            return note;
        }
    }
}
