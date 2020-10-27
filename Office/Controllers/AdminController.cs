using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Office.Models;
using Office.Utils;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Office.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminController : Controller
    {
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<Usuario> userManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        private Contexto _context;

        public AdminController(RoleManager<IdentityRole> role, UserManager<Usuario> user, IMapper map, IWebHostEnvironment hostEnvironment, Contexto contexto)
        {
            webHostEnvironment = hostEnvironment;
            roleManager = role;
            mapper = map;
            userManager = user;
            _context = contexto;
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
        public async Task<IActionResult> Register(UserRegistrationModel userModel, IFormFile Foto)
        {
            if (!ModelState.IsValid)
                return View();

            if (!ValidaCpf.IsCpf(userModel.Cpf))
                return View(userModel);

            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");

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

            await userManager.AddToRoleAsync(usu, userModel.Perfis);

            return RedirectToAction("Register", "Admin");
        }

        public IActionResult DashBoard()
        {
            return View();
        }

        public IActionResult Reservas()
        {
            var lista = _context.Pedidos.ToList();
            return View(lista);
        }
    }
}
