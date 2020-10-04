using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Office.Utils;
using System.Linq;

namespace Office.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto _context;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _context = contexto;
            _logger = logger;
        }

        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 180)]
        public IActionResult Index()
        {
            TempData["Fotos"] = RandomImage.RandomizeImages();
            //return View();
            return View(_context.Produtos.ToList());
        }
    }
}
