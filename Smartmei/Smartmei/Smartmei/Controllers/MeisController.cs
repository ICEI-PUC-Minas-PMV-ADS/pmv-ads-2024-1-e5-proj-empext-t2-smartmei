using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace Smartmei.Controllers
{
    public class MeisController : Controller
    {
        private readonly AppDbContext _context;

        public MeisController(AppDbContext context)
        {
            _context = context;
        }

        // GET : MEI

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Meis.ToListAsync();

            return View(dados);
        }

        public IActionResult Login ()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Mei mei)
        {
            var dados = await _context.Meis.FirstOrDefaultAsync(m => m.Email == mei.Email);

            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();  
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(mei.Senha, dados.Senha);

            if (senhaOk) 
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString())
                };

                var meiIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(meiIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
            }

            return View();
        }

        public async Task<IActionResult> Logout() 
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Meis");
        }

        // GET: Meis/Create
        public async Task<IActionResult> Create()
        {
            // Verificar se já existe algum usuário cadastrado
            var existingUser = await _context.Meis.AnyAsync();
            if (existingUser)
            {
                ViewBag.AlertMessage = "Cadastro bloqueado: Apenas um cadastro  permitido.";

                return RedirectToAction("Login");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Mei mei)
        {
            var existingUser = await _context.Meis.AnyAsync();
            if (existingUser)
            {
                ViewBag.AlertMessage = "Cadastro bloqueado: Apenas um cadastro permitido.";
                return View(mei);
            }

            // Verifica se a senha atende aos critérios de senha forte
            bool isStrongPassword = IsStrongPassword(mei.Senha);
            if (!isStrongPassword)
            {
                ModelState.AddModelError("Senha", "A senha deve conter pelo menos 8 caracteres, incluindo letras maiúsculas, minúsculas e números.");
                return View(mei);
            }

            // Se nenhum usuário existir e a senha for forte, então é feito o cadastro
            if (ModelState.IsValid)
            {
                mei.Senha = BCrypt.Net.BCrypt.HashPassword(mei.Senha); //aqui estou criptografando a senha
                _context.Meis.Add(mei);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(mei);

        }

        // Verifica se a senha é forte
        private static bool IsStrongPassword(string password)
        {
            int minLength = 8;

            if (password.Length < minLength)
                return false;
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            // Senha atende a todos os critérios
            return true;
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

            // Verificar se a senha atende aos critérios de senha forte
            bool isStrongPassword = IsStrongPassword(mei.Senha);
            if (!isStrongPassword)
            {
                ModelState.AddModelError("Senha", "A senha deve conter pelo menos 8 caracteres, incluindo letras maiúsculas, minúsculas e números.");
                return View(mei);
            }

            if (ModelState.IsValid)
            {
                mei.Senha = BCrypt.Net.BCrypt.HashPassword(mei.Senha);
                _context.Meis.Update(mei);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }

            return View(mei);
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

            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Meis.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Meis.Remove(dados);
            await _context.SaveChangesAsync();

            // Realiza o logout do usuário
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}