using System;

namespace BlogTemplate.App.Models
{
    public class CommentModel
    {

        public int UserCommentID { get; set; }
        public int? UserID { get; set; }
        public int BlogID { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
