using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FiorelloFrontToBack.Conntrollers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProductViewModel productVM = new ProductViewModel
            {
                Products = _context.Products.Take(8).ToList(),
                Categories = _context.Categories.ToList()

            };

            ViewBag.ProductCount = _context.Products.Count();
            return View(productVM);
        }

        public IActionResult LoadMore(int skip)
        {
            List<Products> modelProducts = _context.Products.Skip(skip).Take(8).ToList();
            return PartialView("_PartialProduct", modelProducts);
        }

        //public async Task<IActionResult> AddBasket(int id)
        //{
        //    Products products = await _context.Products.FindAsync(id);
        //    if (products == null)
        //        NotFound();
        //    List<BasketVM> basket;
        //    if (Request.Cookies["basket"] != null)
        //    {
        //        basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
        //    }
        //    else
        //    {
        //        basket = new List<BasketVM>();
        //    }
        //    //basket = new List<BasketVM>();
        //    //ViewBag.ProId = _context.Products.Count();
        //    BasketVM hasProduct = basket.FirstOrDefault(prop => prop.Id == id);
        //    if (hasProduct != null)
        //    {
        //        hasProduct.Count += 1;
        //    }
        //    else
        //    {
        //        basket.Add(new BasketVM
        //        {
        //            Id = id,
        //            Count = 1
        //        });
        //    }

        //    Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task<IActionResult> Basket()
        //{
        //    //string baskets = Request.Cookies["basket"];
        //    List<BasketVM> basketPro = new List<BasketVM>();
        //    if (Request.Cookies["basket"] != null)
        //    {
        //        List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);

        //        foreach (BasketVM pro in basket)
        //        {
        //            Products product = await _context.Products.FindAsync(pro.Id);
        //            pro.Title = product.Name;
        //            pro.Price = product.Price * pro.Count;
        //            pro.Image = product.Image;
        //            basketPro.Add(pro);
        //            ViewBag.Total = pro.Count;
        //        }
        //    }

        //    return View(basketPro);
        //}
    }
}
