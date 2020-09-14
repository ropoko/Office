using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;

namespace Office.Controllers
{
    [AllowAnonymous]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 1801)]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController(UserManager<Usuario> user, SignInManager<Usuario> signIn, IMapper map, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
            mapper = map;
            userManager = user;
            signInManager = signIn;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("LoggedIn");
            else
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
            try
            {
                var u = userManager.GetUserAsync(User);

                var usu = new Usuario
                {
                    Cidade = u.Result.Cidade,
                    Cpf = u.Result.Cpf,
                    DataNascimento = u.Result.DataNascimento,
                    Email = u.Result.Email,
                    Foto = u.Result.Foto,
                    Nome = u.Result.Nome,
                    DataCadastro = u.Result.DataCadastro
                };

                return View(usu);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel, IFormFile Foto)
        {
            if (!ModelState.IsValid)
                return View();

            if (Foto != null)
            {
                string pasta = Path.Combine(webHostEnvironment.WebRootPath, "img\\usuarios");
                var nomeArquivo = Guid.NewGuid().ToString() + "_" + Foto.FileName;
                string caminho = Path.Combine(pasta, nomeArquivo);

                using (var stream = new FileStream(caminho, FileMode.Create))
                {
                    await Foto.CopyToAsync(stream);
                }

                userModel.Foto = "/img/usuarios/" + nomeArquivo;
            }

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

            var u = await userManager.FindByEmailAsync(usu.Email);
            u.DataCadastro = DateTime.Now;
            await userManager.AddToRoleAsync(usu, "VISITANTE");

            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            var a = signInManager.GetExternalLoginInfoAsync().Result;
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
