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
            var results = await _samurai.GetAll();
            string strResult = string.Empty;
            foreach(var result in results)
            {
                strResult += result.Name + "\n";
            }

            return Content(strResult);
            //return View();
        }
    }
}
