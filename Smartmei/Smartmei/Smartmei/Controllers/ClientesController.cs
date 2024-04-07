using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;

namespace Smartmei.Controllers
{
    public class ClientesController : Controller
    {

        private readonly AppDbContext _context;
        public ClientesController(AppDbContext context)

        {

            _context = context;

        }

        public async Task<IActionResult> Index()
        {

            var appDbContext = await _context.Clientes.ToListAsync();

            return View(appDbContext);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
                return NotFound();

            var dados = await _context.Clientes.FindAsync(id);

            if (dados == null)
                return NotFound();



            return View(dados);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Cliente cliente)
        {
            if (id != cliente.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Clientes.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details (int ? id)
           {
            if (id == null)
                return NotFound();

            var dados = await _context.Clientes.FindAsync(id);

            if(dados == null)
                return NotFound() ;



            return View(dados);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Clientes.FindAsync(id);

            if (dados == null)
                return NotFound();


            return View(dados);
        }



        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Clientes.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Clientes.Remove(dados);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }


    }
                
     }








