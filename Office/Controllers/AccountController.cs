using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        public static bool Logado;

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
            {
                Logado = true;

                if (user.Email.Equals("rodrigostramantinoli@gmail.com"))
                    return RedirectToAction("Index", "Admin");
                else
                    return RedirectToAction("Index", "Home");
            }

            if (result.IsLockedOut)
                ModelState.AddModelError("", "Usuário Bloqueado");
            else
                ModelState.AddModelError("", "Email e/ou Senha inválidos! :C");

            return View(user);
        }

        [Authorize]
        public IActionResult LoggedIn()
        {
            var u = userManager.GetUserAsync(User);
            if (u != null)
            {
                var usu = new Usuario
                {
                    Cidade = u.Result.Cidade,
                    Cpf = u.Result.Cpf,
                    DataNascimento = u.Result.DataNascimento,
                    Email = u.Result.Email,
                    Foto = u.Result.Foto,
                    Nome = u.Result.Nome,
                };

                return View(usu);
            }
            else
                return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
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

            ViewBag.Cadastrado = true;
            await userManager.AddToRoleAsync(usu, "VISITANTE");

            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            Logado = false;
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
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
