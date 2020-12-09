using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Categories.Where(c=>c.IsDeleted==false).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categories categories)
        {
            if (!ModelState.IsValid) return NotFound();
            bool isExist = _dbContext.Categories.Where(c=>c.IsDeleted == false).Any(c => c.Name.ToLower() == categories.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "This name already exist. Plase write anouther name");
                return View();
            }
            categories.IsDeleted = false;
            await _dbContext.AddAsync(categories);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Categories categories = _dbContext.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (categories == null) return NotFound();
            return View(categories);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Categories categories = _dbContext.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (categories == null) return NotFound();
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Categories categories = _dbContext.Categories.Where(c=>c.IsDeleted == false).Include(c=>c.Products)
                .FirstOrDefault(c=>c.Id == id);
            if (categories == null) return NotFound();

            categories.IsDeleted = true;
            categories.DeletedDate = DateTime.Now;
            foreach (Products pro in categories.Products)
            {
                pro.IsDeleted = true;
                pro.DeletedDate = DateTime.Now;
            }

            await _dbContext.SaveChangesAsync();
            return View(categories);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Categories categories = _dbContext.Categories.Where(c => c.IsDeleted == false)
                .FirstOrDefault(c => c.Id == id);
            if (categories == null) return NotFound();
            categories.IsDeleted = false;
            await _dbContext.SaveChangesAsync();
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Update")]
        public async Task<IActionResult> UpdatePost(int? id, Categories categories)
        {
            if (id == null) return NotFound();
            if (categories == null) return NotFound();

            Categories categ = await _dbContext.Categories.FindAsync(id);

            Categories isExist = _dbContext.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Name.ToLower() == categories.Name.ToLower());
            if (isExist != null)
            {
                ModelState.AddModelError("Name", "This name already exist. Plase write another namesadsd");
                return View();
            }

            categories.IsDeleted = false;
            categ.Name = categories.Name;
            categ.Description = categories.Description;

            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
