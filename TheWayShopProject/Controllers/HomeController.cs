using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheWayShopProject.Models;

namespace TheWayShopProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("IndexCustomer");
        }
        public IActionResult IndexCustomer()
        {
            return View();
        }

        public IActionResult IndexAdmin()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new TheWayShopProject.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
