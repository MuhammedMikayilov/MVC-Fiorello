using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required, StringLength(256)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public ICollection<Products> Products { get; set; } //soradan elave etdim, ishleyirdi deye unutdum qalmishdi ele :(

    }
}
