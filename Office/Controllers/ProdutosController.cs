using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Office.Models;

namespace Office.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly Contexto _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProdutosController(Contexto context, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.IDProduto == id);
            if (produto == null)
            {
                return NotFound();
            }

            ViewData["CaminhoFoto"] = webHostEnvironment.WebRootPath;
            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            var lista = new List<string>();

            var categoria = _context.Categorias.ForEachAsync((a) => {
                lista.Add(a.Nome);
            });

            ViewData["Categorias"] = new SelectList(lista);

            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDProduto,Nome,Valor,Marca,Categoria,Foto,Descricao")] Produto produto, IFormFile Foto)
        {
            if (ModelState.IsValid)
            {
                if (Foto != null)
                {
                    string pasta = Path.Combine(webHostEnvironment.WebRootPath, "img\\produtos");
                    var nomeArquivo = Guid.NewGuid().ToString() + "_" + Foto.FileName;
                    string caminho = Path.Combine(pasta, nomeArquivo);

                    using (var stream = new FileStream(caminho, FileMode.Create))
                    {
                        await Foto.CopyToAsync(stream);
                    }

                    produto.Foto = "/img/produtos/" + nomeArquivo;
                }

                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDProduto,Nome,Valor,Marca,Categoria,Foto,Descricao")] Produto produto, IFormFile NovaFoto)
        {
            if (id != produto.IDProduto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (NovaFoto != null)
                    {
                        string pasta = Path.Combine(webHostEnvironment.WebRootPath, "img\\produtos");
                        var nomeArquivo = Guid.NewGuid().ToString() + "_" + NovaFoto.FileName;
                        string caminho = Path.Combine(pasta, nomeArquivo);

                        using (var stream = new FileStream(caminho, FileMode.Create))
                        {
                            await NovaFoto.CopyToAsync(stream);
                        }

                        produto.Foto = "/img/produtos/" + nomeArquivo;
                    }

                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.IDProduto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaminhoFoto"] = webHostEnvironment.WebRootPath;
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.IDProduto == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            // Delete img from wwwroot
            string imgProd = Environment.CurrentDirectory + "\\wwwroot\\" + produto.Foto;
            System.IO.File.Delete(imgProd);

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.IDProduto == id);
        }
    }
}
