using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;
using SmartMei.Models;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;

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
        public async Task<IActionResult> Index(string projeto,decimal? custoTotal)
        {
            // Definindo a variável projetos como IQueryable<Projeto>
            var custos = _context.Custos.AsQueryable();

            if (!String.IsNullOrEmpty(projeto))
            {
                custos = custos.Where(p => p.Projeto.Nome.Contains(projeto));
            }
            if (custoTotal.HasValue)
            {
                custos = custos.Where(p => p.CustoTotal == custoTotal);
            }

            // Convertendo a consulta em uma lista e incluindo a entidade Cliente se necessário
            return View(await custos.Include(p => p.Projeto).ToListAsync());
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
        public async Task<IActionResult> GerarPDFCustos()
        {
            // Busca todos os custos no banco de dados
            var custos = await _context.Custos.ToListAsync();

            // Cria um stream de memória para armazenar o PDF
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = new PdfWriter(memoryStream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adiciona um título ao documento
            Paragraph title = new Paragraph("Relatório de Custos").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            document.Add(title);

            // Adiciona os dados dos custos ao PDF
            foreach (var custo in custos)
            {
                // Recuperar nome do projeto com base no ID
                var projeto = await _context.Projetos.FirstOrDefaultAsync(p => p.Id == custo.ProjetoId);
                var nomeProjeto = projeto != null ? projeto.Nome : "Projeto não encontrado";

                // Adiciona os detalhes de cada custo
                document.Add(new Paragraph($"Projeto: {nomeProjeto}"));
                document.Add(new Paragraph($"Passagem Aérea (R$): {custo.PassagemAerea}"));
                document.Add(new Paragraph($"Hospedagem (R$): {custo.Hospedagem}"));
                document.Add(new Paragraph($"Deslocamento (R$): {custo.Deslocamento}"));
                document.Add(new Paragraph($"Alimentação (R$): {custo.Alimentacao}"));
                document.Add(new Paragraph($"Custo Total (R$): {custo.CustoTotal}"));

                // Adiciona uma linha em branco entre os custos
                document.Add(new Paragraph("\n"));
            }

            // Fecha o documento
            document.Close();
            writer.Close();

            // Retorna o PDF gerado como um arquivo para download
            return File(memoryStream.ToArray(), "application/pdf", "RelatorioCustos.pdf");
        }

    }
}

       
    
