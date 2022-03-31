using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogTemplate.Domain
{
    [Table("TextContent")]
    public class TextContent
    {
        public int TextContentID { get; set; }
        [Required]
        public string Text { get; set; }


    }
}
