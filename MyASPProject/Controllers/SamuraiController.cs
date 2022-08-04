using Microsoft.AspNetCore.Mvc;
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
            var model = await _samurai.GetAll();
            return View(model);
        }
    }
}
