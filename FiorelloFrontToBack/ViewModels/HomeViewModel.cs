using FiorelloFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public SliderTitle SliderTitle { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Products> Products { get; set; }
        public Valentine Valentine { get; set; }
        public List<ValentineList> ValentineLists { get; set; }
        public List<Experts> Experts { get; set; }
        public List<Headers> Headers { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<SliderSay> SliderSays { get; set; }



    }
}
