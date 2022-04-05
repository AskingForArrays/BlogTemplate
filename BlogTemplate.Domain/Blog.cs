using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogTemplate.Domain
{

    [Table("Blog")]
    public class Blog
    {

        public int BlogID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Content { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        [Required]
        public string Url { get; set; } = "";
        [Required]
        public string Summary { get; set; } = "";
        [Required]
        public bool Published { get; set; } = false;
        [Required]
        public byte[] MainImage { get; set; }

        public ICollection<UserComment> UserComments { get; set; }
    }
}
