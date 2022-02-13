using BestSupermarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BestSupermarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _dBContext;

        public HomeController(ILogger<HomeController> logger, DBContext dBContext)
        {
            _logger = logger;
            _dBContext = dBContext;
        }

        public IActionResult Index()
        {
            ViewBag.Products = _dBContext.Products;
            return View();
        }
        public IActionResult Sale()
        {
            ViewBag.Products = _dBContext.Products;
            return View();
        }

        public IActionResult About(int productId)
        {
            ViewBag.Info = _dBContext.Products.FirstOrDefault(i => i.Id == productId);
            ViewBag.Products = _dBContext.Products;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
