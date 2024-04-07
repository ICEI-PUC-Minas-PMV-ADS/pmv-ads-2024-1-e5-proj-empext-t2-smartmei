using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Controllers;
using Smartmei.Models;

namespace Smartmei.Controllers
{
    public class EventosController : Controller
    {
        private readonly AppDbContext _context;
        public EventosController(AppDbContext context)

        {

            _context = context;

        }


        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Eventos.Include(p => p.Projeto);
            return View(await appDbContext.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Eventos == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos
                .Include(p => p.Projeto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        public IActionResult Create()
        {
            ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome");
            return View();
        }

        // POST: Projetos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjetoId,DataEventoInicio,DataEventoFim,ValorDiaria,Cidade,Estado")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evento);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Evento criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjetoId"] = new SelectList(_context.Clientes, "Id", "Nome", evento.ProjetoId);
            return View(evento);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Eventos == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos.FindAsync(id);
            if (evento == null)
            {
                return NotFound();
            }
            ViewData["ProjetoId"] = new SelectList(_context.Clientes, "Id", "Nome", evento.ProjetoId);

            return View(evento);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjetoId,DataEventoInicio,DataEventoFim,ValorDiaria,Cidade,Estado")] Evento evento)

        {
            if (id != evento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evento);
                    await _context.SaveChangesAsync();

                    TempData["Mensagem"] = "Evento atualizado com sucesso!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventoExists(evento.Id))
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

            ViewData["ProjetoId"] = new SelectList(_context.Clientes, "Id", "Nome", evento.ProjetoId);

            return View(evento);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Eventos == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos
                .Include(p => p.Projeto)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Eventos == null)
            {
                return Problem("Entity set 'AppDbContext.Eventos' is null.");
            }

            var evento = await _context.Eventos.FindAsync(id);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = "Evento deletado com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }




        private bool EventoExists(int id)
        {
            return _context.Eventos.Any(e => e.Id == id);
        }
    }
}




