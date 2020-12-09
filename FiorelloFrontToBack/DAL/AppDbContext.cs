using FiorelloFrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderTitle> SliderTitles { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Valentine> Valentines { get; set; }
        public DbSet<ValentineList> ValentineLists { get; set; }
        public DbSet<Experts> Experts { get; set; }
        public DbSet<Headers> Headers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SliderSay> SliderSays { get; set; }
        public DbSet<Bio> Bios { get; set; }

    }
}
