using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Conntrollers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.ToList(),
                SliderTitle = _context.SliderTitles.FirstOrDefault(),
                Categories = _context.Categories.Where(c=>c.IsDeleted==false).ToList(),
                Products = _context.Products.Take(8).Where(p => p.IsDeleted == false).ToList(),
                Valentine = _context.Valentines.FirstOrDefault(),
                ValentineLists = _context.ValentineLists.ToList(),
                Experts = _context.Experts.ToList(),
                Headers=_context.Headers.ToList(),
                Blogs=_context.Blogs.Where(b=>b.isDeleted==false).ToList(),
                SliderSays= _context.SliderSays.ToList()

            };
            
            return View(homeVM);
        }

        public async Task<IActionResult> AddBasket(int id)
        {
            Products products = await _context.Products.FindAsync(id);
            if (products == null)
                NotFound();
            List<BasketVM> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            //basket = new List<BasketVM>();
            //ViewBag.ProId = _context.Products.Count();
            BasketVM hasProduct = basket.FirstOrDefault(prop => prop.Id == id);
            if(hasProduct != null)
            {
                hasProduct.Count += 1;
            }
            else
            {
                basket.Add(new BasketVM
                {
                    Id = id,
                    Count = 1
                });
            }
            
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteBasket(int id)
        {
            List<BasketVM> basket;
            basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            BasketVM basketVM = basket.FirstOrDefault(p => p.Id == id);

            basket.Remove(basketVM);

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            return RedirectToAction(nameof(Basket));
        }
        public async Task<IActionResult> Basket()
        {

            //string baskets = Request.Cookies["basket"];
            List<BasketVM> basketPro = new List<BasketVM>();
            if (Request.Cookies["basket"] != null)
            {
                List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);

                foreach (BasketVM pro in basket)
                {
                    Products product = await _context.Products.FindAsync(pro.Id);
                    pro.Title = product.Name;
                    pro.Price = product.Price * pro.Count;
                    pro.Image = product.Image;
                    basketPro.Add(pro);
                    ViewBag.Total = pro.Count;

                }
            }


            return View(basketPro);
        }
    }
}
