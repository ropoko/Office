using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Office.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class UsuariosController : Controller
    {
        private readonly Contexto _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public UsuariosController(Contexto context, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            ViewData["CaminhoFoto"] = webHostEnvironment.WebRootPath;
            return View(user);
        }
    }
}
