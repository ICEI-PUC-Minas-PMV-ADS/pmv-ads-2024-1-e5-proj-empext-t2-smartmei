using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;
using SmartMei.Models;

namespace SmartMei.Controllers
{
    public class CustosController : Controller
    {
        private readonly AppDbContext _context;

        public CustosController(AppDbContext context)
        {
            _context = context;

        }

        // GET: Custos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Custos.Include(c => c.Projeto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Custos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Custos == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos
                .Include(c => c.Projeto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // GET: Custos/Create
        public IActionResult Create()
        {
            ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome");
            return View();
        }

        // POST: Custos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PassagemAerea,Hospedagem,Deslocamento,Alimentacao,CustoTotal,ProjetoId")] Custo custo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome", custo.ProjetoId);
            return View(custo);
        }

        // GET: Custos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Custos == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos.FindAsync(id);
            if (custo == null)
            {
                return NotFound();
            }
            ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome", custo.ProjetoId);
            return View(custo);
        }

        // POST: Custos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PassagemAerea,Hospedagem,Deslocamento,Alimentacao,CustoTotal,ProjetoId")] Custo custo)
        {
            if (id != custo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustoExists(custo.Id))
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
            ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome", custo.ProjetoId);
            return View(custo);
        }

        // GET: Custos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Custos == null)
            {
                return NotFound();
            }

            var custo = await _context.Custos
                .Include(c => c.Projeto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custo == null)
            {
                return NotFound();
            }

            return View(custo);
        }

        // POST: Custos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Custos == null)
            {
                return Problem("Entity set 'AppDbContext.Custos'  is null.");
            }
            var custo = await _context.Custos.FindAsync(id);
            if (custo != null)
            {
                _context.Custos.Remove(custo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustoExists(int id)
        {
            return _context.Custos.Any(e => e.Id == id);
        }
    }
}

       
    
