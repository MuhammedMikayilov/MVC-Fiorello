using FiorelloFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewModels
{
    public class ProductViewModel
    {
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
