using System;

namespace BlogTemplate.App.Models
{
    public class BlogModel
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
    }
}
