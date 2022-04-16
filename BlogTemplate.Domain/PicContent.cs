using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogTemplate.Domain
{
    [Table("PicContent")]
    public class PicContent
    {

        public int PicContentID { get; set; }
        [Required]
        public string Picture { get; set; }
    }
}
