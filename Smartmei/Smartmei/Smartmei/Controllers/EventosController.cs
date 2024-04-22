using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Controllers;
using Smartmei.Models;

public class EventosController : Controller
{
    private readonly AppDbContext _context;

    public EventosController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Eventos
    public async Task<IActionResult> Index()
    {
        var eventos = await _context.Eventos.Include(e => e.Projeto).ToListAsync();
        return View(eventos);
    }


    // GET: Eventos/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var evento = await _context.Eventos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (evento == null)
        {
            return NotFound();
        }

        return View(evento);
    }

    // GET: Eventos/Create
    public IActionResult Create()
    {
        // Popule ViewBag.ProjetoId com os projetos disponíveis
        ViewBag.ProjetoId = new SelectList(_context.Projetos, "Id", "Nome");
        return View(new Evento());
    }

    // POST: Eventos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ProjetoId,DataEventoInicio,DataEventoFim,ValorDiaria,Cidade,Estado")] Evento evento)
    {
        if (ModelState.IsValid)
        {
            _context.Add(evento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(evento);
    }

    // GET: Eventos/Edit/5
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
        ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome", evento.ProjetoId);
        return View(evento);
    }

    // POST: Eventos/Edit/5
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
        return View(evento);
    }

    // GET: Eventos/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var evento = await _context.Eventos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (evento == null)
        {
            return NotFound();
        }

        return View(evento);
    }

    // POST: Eventos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);
        _context.Eventos.Remove(evento);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EventoExists(int id)
    {
        return _context.Eventos.Any(e => e.Id == id);
    }
}


