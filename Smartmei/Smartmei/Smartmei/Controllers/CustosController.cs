using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;

namespace SmartMei.Controllers
{
    public class CustosController : Controller
    {
        private readonly AppDbContext _context;

        public CustosController(AppDbContext context)
        {
            _context = context;
        }

       
    }
}
