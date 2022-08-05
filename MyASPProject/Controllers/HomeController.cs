using Microsoft.AspNetCore.Mvc;
using MyASPProject.Models;
using System.Diagnostics;

namespace MyASPProject.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("token")))
            {
                HttpContext.Session.SetString("token", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImVyaWNrQHJhcGlkdGVjaC5pZCIsIm5iZiI6MTY1OTY4OTY2NCwiZXhwIjoxNjU5NjkzMjY0LCJpYXQiOjE2NTk2ODk2NjR9.7f5FAPfV4WiAHSVmQyP9RiHBCjKX0Y55o37zrr7eHGA");
            }

            return View();
        }

        public IActionResult About()
        {
            string[] arrName = new string[] { "Erick", "Budi", "Bambang" };
            return new JsonResult(arrName);
        }

        public IActionResult Address()
        {
            return Content("Jl Mangga 12");
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