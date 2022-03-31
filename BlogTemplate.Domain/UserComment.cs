using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogTemplate.Domain
{
    [Table("UserComment")]
    public class UserComment
    {

        public int UserCommentID { get; set; }
        public int? UserID { get; set; }
        public User User { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }

    }
}
