﻿using Microsoft.AspNetCore.Mvc;
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