using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Office.Models;
using Office.Utils;

namespace Office.Controllers
{
    [AllowAnonymous]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 1801)]
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly Contexto _context;
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController(UserManager<Usuario> user, SignInManager<Usuario> signIn, IMapper map, IWebHostEnvironment hostEnvironment, Contexto context)
        {
            _context = context;
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
        public IActionResult LoggedIn(IFormFile Foto)
        {
            try
            {
                if (Foto != null)
                {

                }

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

            if (!ValidaCpf.IsCpf(userModel.Cpf))
                return View(userModel);

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

            usu.DataCadastro = DateTime.Now;
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
            await signInManager.SignInAsync(usu, true);

            TempData["PrimeiroAcesso"] = "OK";

            return RedirectToAction("LoggedIn");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            _ = signInManager.GetExternalLoginInfoAsync().Result;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Usuario usuario, IFormFile NovaFoto)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (NovaFoto != null)
                    {
                        string pasta = Path.Combine(webHostEnvironment.WebRootPath, "img\\usuarios");
                        var nomeArquivo = Guid.NewGuid().ToString() + "_" + NovaFoto.FileName;
                        string caminho = Path.Combine(pasta, nomeArquivo);

                        using (var stream = new FileStream(caminho, FileMode.Create))
                        {
                            await NovaFoto.CopyToAsync(stream);
                        }

                        usuario.Foto = "/img/usuarios/" + nomeArquivo;
                    }

                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["CaminhoFoto"] = webHostEnvironment.WebRootPath;
            return View(usuario);
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
