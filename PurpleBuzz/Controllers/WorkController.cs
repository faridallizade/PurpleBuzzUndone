using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels;
using System.Collections.Generic;

namespace PurpleBuzz.Controllers
{
    public class WorkController : Controller
    {
        private AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public List<Category> Categories { get; private set; }

        public IActionResult Index()
        {
            List<Product> Products = new List<Product>();
            Products = _context.Products.ToList();
            Categories = _context.Categories.ToList();
            _context.AddRange(Categories);
            _context.AddRange(Products);
            WorkVM workVM = new WorkVM();
            workVM.Products = Products;
            workVM.Categories = Categories;
            return View(workVM); 
        }
    }
}
