using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;

namespace Smartmei.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly AppDbContext _context;

        public ProjetosController(AppDbContext context)
        {
            _context = context;
        }

    // GET: Projetos

    public async Task<IActionResult> Index(string titulo, string cliente)
        {
            // Definindo a variável projetos como IQueryable<Projeto>
            var projetos = _context.Projetos.AsQueryable();

            if (!String.IsNullOrEmpty(titulo))
            {
                projetos = projetos.Where(p => p.Nome.Contains(titulo));
            }

            if (!String.IsNullOrEmpty(cliente))
            {
                projetos = projetos.Include(p => p.Cliente).Where(p => p.Cliente.Nome.Contains(cliente));
            }

            // Convertendo a consulta em uma lista e incluindo a entidade Cliente se necessário
            return View(await projetos.Include(p => p.Cliente).Include(p => p.Mei).ToListAsync());
        }

        // GET: Projetos/Details/5
        public async Task<IActionResult> Details(int? id)
            {
                if (id == null || _context.Projetos == null)
                {
                    return NotFound();
                }

                var projeto = await _context.Projetos
                    .Include(p => p.Cliente)
                    .Include(p => p.Mei)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (projeto == null)
                {
                    return NotFound();
                }

                return View(projeto);
            }

        // GET: Projetos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome");
            return View();
        }

        // POST: Projetos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,ClienteId,DataInicioProjeto,DataFimProjeto,QuantidadeTelas,ValorTela,ValorTotalProjeto,PrazoPagamento,DataEmissaoNF,DataPagamentoNF,Acompanhamento,LinkDrive,Observacao,MeiId")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projeto);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Projeto criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // GET: Projetos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Projetos == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // POST: Projetos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,ClienteId,DataInicioProjeto,DataFimProjeto,QuantidadeTelas,ValorTela,ValorTotalProjeto,PrazoPagamento,DataEmissaoNF,DataPagamentoNF,Acompanhamento,LinkDrive,Observacao,MeiId")] Projeto projeto)
        {
            if (id != projeto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projeto);
                    await _context.SaveChangesAsync();

                    TempData["Mensagem"] = "Projeto atualizado com sucesso!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetoExists(projeto.Id))
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

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // GET: Projetos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Projetos == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos
                .Include(p => p.Cliente)
                .Include(p => p.Mei)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return View(projeto);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Projetos == null)
            {
                return Problem("Entity set 'AppDbContext.Projetos' is null.");
            }

            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto != null)
            {
                _context.Projetos.Remove(projeto);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = "Projeto deletado com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProjetoExists(int id)
        {
            return _context.Projetos.Any(e => e.Id == id);
        }
    }
}
