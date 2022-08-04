using Microsoft.AspNetCore.Mvc;
using MyASPProject.Models;
using MyASPProject.Services;

namespace MyASPProject.Controllers
{
    public class SamuraiController : Controller
    {
        private readonly ISamurai _samurai;
        public SamuraiController(ISamurai samurai)
        {
            _samurai = samurai;
        }

        public async Task<IActionResult> Index()
        {

            ViewData["pesan"] = TempData["pesan"] ?? TempData["pesan"];

            var model = await _samurai.GetAll();
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _samurai.GetById(id);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Samurai samurai)
        {
            try
            {
                var result = await _samurai.Insert(samurai);
                TempData["pesan"] = $"<div class='alert alert-success alert-dismissible fade show'><button type='button' class='btn-close' data-bs-dismiss='alert'></button> Berhasil menambahkan data samurai {result.Name}</div>";
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewData["pesan"] = $"<div class='alert alert-success alert-dismissible fade show'><button type='button' class='btn-close' data-bs-dismiss='alert'></button> Error: {ex.Message}</div>";
                return View();
            }
            
        }
    }
}
