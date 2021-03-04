using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;


namespace Office.Controllers
{
    [AllowAnonymous]
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
