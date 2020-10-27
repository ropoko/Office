using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Office.Models;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var meuPedido = _context.Pedidos.ToList();
            var meusItems = new List<Produto>();

            foreach (var item in meuPedido)
            {
                if (user.Id == item.IDCliente)
                {
                    var itens = _context.ItensPedidos.SingleOrDefault(x => x.IDPedido == item.IDPedido);

                    var produtos = _context.Produtos.SingleOrDefault(x => x.IDProduto == itens.IDProduto);

                    meusItems.Add(produtos);
                }
            }

            return View(meusItems.AsQueryable());
        }

        public async Task<IActionResult> Reservar(int id)
        {
            // QUANDO O MESMO USUARIO TENTA FAZER O MESMO PEDIDO 2X FUNCIONA
            // MAS QUANDO 2 USUARIOS DIFERENTES TENTAM RESERVAR O MESMO PRODUTO, ESTA FALHANDO


            // Não pode reservar o mesmo produto 2x
            string userID = _userManager.GetUserId(User);
            var mesmoProduto = _context.ItensPedidos.SingleOrDefault(x => x.IDProduto.Equals(id));

            if (mesmoProduto != null)
            {
                var Pedido = _context.Pedidos.Where(y => y.IDPedido == mesmoProduto.IDPedido && y.IDCliente == userID);

                if (Pedido.Count() > 0)
                {
                    return View();
                }
            }

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Account", "Login");
            }

            var today = DateTime.Now;
            var user = await _userManager.GetUserAsync(User);

            int ultimoPedido = 0;
            if (_context.Pedidos.ToList().Count > 0)
            {
                // Pega o id do último pedido feito 
                ultimoPedido = _context.Pedidos.OrderByDescending(x => x.IDPedido).SingleOrDefault().IDPedido;
            }

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

        public void ExcluirPedido(int item)
        {
            var user = _userManager.GetUserId(User);

            _context.ItensPedidos.SingleOrDefault(x => x.IDProduto == item);
        }
    }
}
