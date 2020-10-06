﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Office.Controllers
{
    [Authorize]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 180)]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
