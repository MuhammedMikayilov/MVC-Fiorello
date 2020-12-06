using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class SliderSay
    {
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string Image { get; set; }
        public string Description { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }

    }
}
