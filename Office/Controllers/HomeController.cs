using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Linq;
//using System.Web.Mvc;

namespace Office.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
        {
            _cache = cache; 
            _logger = logger;
        }

        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 180)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
