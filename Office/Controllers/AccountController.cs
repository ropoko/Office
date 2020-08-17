using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;

namespace Office.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public AccountController(UserManager<Usuario> user, SignInManager<Usuario> signIn, IMapper map)
        {
            mapper = map;
            userManager = user;
            signInManager = signIn;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel user)
        {
            if (!ModelState.IsValid)
                return View(user);

            var result = await signInManager.PasswordSignInAsync(user.Email, user.Senha, true, lockoutOnFailure: true);
            if (result.Succeeded)
                return RedirectToAction("Index", "Admin");

            if (result.IsLockedOut)
                ModelState.AddModelError("", "Usuário Bloqueado");
            else
                ModelState.AddModelError("", "Email e/ou Senha inválidos! :C");

            if (user.Email.Equals("rodrigostramantinoli@gmail.com"))
                return RedirectToAction("Index", "Admin");
            else
                return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro(UserRegistrationModel userModel)
        {
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

            await userManager.AddToRoleAsync(usu, "VISITANTE");

            return View(usu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }

    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, Usuario>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }

}
