using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string Image { get; set; }
        public string BlogTitle { get; set; }
        public string Description { get; set; }
        public DateTime DateBlog { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
