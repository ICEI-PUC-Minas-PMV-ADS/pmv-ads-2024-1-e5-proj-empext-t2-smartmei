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
            var appDbContext = await _context.Meis.ToListAsync();
            return View(appDbContext);
        }
            
           }
}
