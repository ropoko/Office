using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;
using Owin.Security.Providers.Instagram;

namespace Office.Controllers
{
    [AllowAnonymous]
    public class GaleriaController : Controller
    {
        //private readonly UserManager<Usuario> userManager;
        //private readonly SignInManager<Usuario> signInManager;
 
        public IActionResult Index()
        {
            return View();
        }
    }
}
