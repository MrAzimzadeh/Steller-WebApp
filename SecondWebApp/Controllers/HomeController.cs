using Microsoft.AspNetCore.Mvc;
using SecondWebApp.Data;
using SecondWebApp.Models;
using SecondWebApp.ViewModels;
using System.Diagnostics;

namespace SecondWebApp.Controllers
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
            var banner = _context.Banners.First();
            var about = _context.Abouts.OrderByDescending(x => x.Id).Last();
            var clientCounts = _context.ClientCounts.ToList();
            var services = _context.Services.OrderByDescending(x => x.Id).ToList();
            var skill = _context.Skills.OrderByDescending(x => x.Id).ToList();

            HomeVM homeVM = new()
            {
                About = about,
                Banner = banner,
                ClientCounts = clientCounts,
                Services = services,
                Skills= skill,

            };

            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}