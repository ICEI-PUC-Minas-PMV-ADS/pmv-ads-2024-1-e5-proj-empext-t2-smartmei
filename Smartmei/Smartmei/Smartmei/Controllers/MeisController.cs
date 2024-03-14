using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;

namespace Smartmei.Controllers
{
    public class MeisController : Controller
    {
        private readonly AppDbContext _context;

        public MeisController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Meis.ToListAsync();

            return View(dados);
        }
        // GET: Meis/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Mei mei)
        {
            if (ModelState.IsValid)
            {
                mei.Senha = BCrypt.Net.BCrypt.HashPassword(mei.Senha); //aqui estou criptografando a senha
                _context.Meis.Add(mei);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(mei);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Meis.FindAsync(id);

            if (id == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Mei mei)
        {
            if (id != mei.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                mei.Senha = BCrypt.Net.BCrypt.HashPassword(mei.Senha);
                _context.Meis.Update(mei);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Meis.FindAsync(id);

            if (id == null)
                return NotFound();

            return View(dados);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Meis.FindAsync(id);

            if (id == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Meis.FindAsync(id);

            if (id == null)
                return NotFound();

            _context.Meis.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}