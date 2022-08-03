using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyASPProject.ViewModels;

namespace MyASPProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole myRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                var result = await _roleManager.CreateAsync(myRole);
                if(result.Succeeded)
                {
                    ViewData["pesan"] = 
                        $"<div class='alert alert-success alert-dismissible fade show'><button type='button' class='btn-close' data-bs-dismiss='alert'></button> Berhasil menambahkan data role {model.RoleName}</div>"; 
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
    }
}
