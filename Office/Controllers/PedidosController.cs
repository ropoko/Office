using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Office.Controllers
{
    [Authorize]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = 180)]
    public class PedidosController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly Contexto _context;

        public PedidosController(UserManager<Usuario> manager, Contexto context)
        {
            _context = context;
            _userManager = manager;
        }

        // Exibe os pedidos feitos pelo usuário
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Reservar(int id)
        {
            var today = DateTime.Now;
            var user = await _userManager.GetUserAsync(User);
            //var user = _context.Users.Find(User.Identity.Name);

            var pedido = new Pedido
            {
                DataPedido = DateTime.Now,
                DataBusca = today.AddDays(14),
                IDCliente = user.Id
            };

            _ = new ItemPedido
            {
                IDProduto = id,
                IDPedido = pedido.IDPedido
            };

            return RedirectToAction("Index", "Home");
        }
    }
}
