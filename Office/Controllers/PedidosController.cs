using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Office.Models;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Account", "Login");
            }

            var today = DateTime.Now;
            var user = await _userManager.GetUserAsync(User);

            // Pega o id do último pedido feito 
            var ultimoPedido = _context.Pedidos.OrderByDescending(x => x.IDPedido).FirstOrDefault().IDPedido;

            var pedido = new Pedido
            {
                IDPedido = ultimoPedido + 1,
                DataPedido = DateTime.Now,
                DataBusca = today.AddDays(14),
                IDCliente = user.Id
            };

            var itemPedido = new ItemPedido
            {
                IDProduto = id,
                IDPedido = pedido.IDPedido
            };

            _context.Pedidos.Add(pedido);
            _context.ItensPedidos.Add(itemPedido);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
