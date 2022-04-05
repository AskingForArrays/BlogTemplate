using System;
using System.Drawing;

namespace BlogTemplate.App.Models
{
    public class BlogViewModel
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string UserID { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public Image MainImage { get; set; }
        public bool Published { get; set; }
        public string Summary { get; set; }

    }
}
