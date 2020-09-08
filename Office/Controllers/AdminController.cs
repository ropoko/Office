using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Office.Models;
using System.Threading.Tasks;

namespace Office.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminController : Controller
    {
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public AdminController(RoleManager<IdentityRole> role, UserManager<Usuario> user, SignInManager<Usuario> signIn, IMapper map)
        {
            roleManager = role;
            mapper = map;
            userManager = user;
            signInManager = signIn;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");

            if (!ModelState.IsValid)
                return View();

            var usu = mapper.Map<Usuario>(userModel);

            var result = await userManager.CreateAsync(usu, userModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }

            await userManager.AddToRoleAsync(usu, userModel.Perfis);

            return RedirectToAction("Register", "Admin");
        }
    }
}
