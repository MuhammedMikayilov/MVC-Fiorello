using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Experts
    {
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string Image { get; set; }
        [Required, MaxLength(200)]
        public string Fullname { get; set; }
        [Required, MaxLength(100)]
        public string Position { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
