using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.BasketCount = 0;
            ViewBag.PriceTotal = 0;

            if(Request.Cookies["basket"] != null)
            {
                List<BasketVM> baskets = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                ViewBag.BasketCount = baskets.Sum(p=>p.Count);
                //ViewbaB.pricetotal = baskets.;
                foreach (BasketVM item in baskets)
                {
                    Products product = await _context.Products.FindAsync(item.Id);
                    double count = product.Price * item.Count;
                    ViewBag.PriceTotal = count;
                }
            }

            Bio bio = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
