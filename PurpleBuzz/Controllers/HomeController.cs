using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Migrations;
using PurpleBuzz.ViewModels;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private  AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _context.Sliders.ToList(),
                Cards = _context.Cards.Take(8).ToList(),
                RecentCards = _context.Cards.OrderBy(x=>x.CreatedAt).Take(6).ToList(),
            };
            return View(homeVM);
        }
    }
}
