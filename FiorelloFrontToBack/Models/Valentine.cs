using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Valentine
    {
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string VideoImg { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
