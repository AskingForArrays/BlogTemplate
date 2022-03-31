using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlogTemplate.Domain
{
    [Table("User")]
    public class User
    {

        public int UserID { get; set; }
        [Required]
        public string Username{ get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccessLevel { get; set; }

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<UserComment> UserComments { get; set; }
    }
}
