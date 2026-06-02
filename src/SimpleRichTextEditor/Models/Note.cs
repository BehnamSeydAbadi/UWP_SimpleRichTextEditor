using System;
using System.Collections.Generic;
using System.Linq;
namespace SimpleRichTextEditor.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
