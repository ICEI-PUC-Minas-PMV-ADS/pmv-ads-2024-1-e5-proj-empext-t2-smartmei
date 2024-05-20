using iText.Kernel.Pdf;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using iText.Layout;
using Smartmei.Models;
using SmartMei.Models;

namespace SmartMei.Controllers
{
    public class FaturamentosController : Controller
    {
        private readonly AppDbContext _context;

        public FaturamentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Faturamentos
        public async Task<IActionResult> Index(int? mes, int? ano)
        {
            var faturamentoQuery = _context.Faturamentos.AsQueryable();

            if (mes.HasValue)
            {
                faturamentoQuery = faturamentoQuery.Where(p => p.Mes == mes);
            }

            if (ano.HasValue)
            {
                faturamentoQuery = faturamentoQuery.Where(p => p.Ano == ano);
            }

            faturamentoQuery = faturamentoQuery.Include(p => p.Mei);

            
            var faturamentos = await faturamentoQuery.ToListAsync();

 
            return View(faturamentos);
        }


        // GET: Faturamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Faturamentos == null)
            {
                return NotFound();
            }

            var faturamento = await _context.Faturamentos
                .Include(f => f.Mei)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faturamento == null)
            {
                return NotFound();
            }

            return View(faturamento);
        }

        // GET: Faturamentos/Create
        public IActionResult Create()
        {
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome");
            return View();
        }

        // POST: Faturamentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mes,Ano,ValorBruto,CustoMensal,ValorLiquidoMensal,MeiId")] Faturamento faturamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faturamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", faturamento.MeiId);
            return View(faturamento);
        }

        // GET: Faturamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Faturamentos == null)
            {
                return NotFound();
            }

            var faturamento = await _context.Faturamentos.FindAsync(id);
            if (faturamento == null)
            {
                return NotFound();
            }
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", faturamento.MeiId);
            return View(faturamento);
        }

        // POST: Faturamentos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mes,Ano,ValorBruto,CustoMensal,ValorLiquidoMensal,MeiId")] Faturamento faturamento)
        {
            if (id != faturamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faturamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaturamentoExists(faturamento.Id))
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
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", faturamento.MeiId);
            return View(faturamento);
        }

        // GET: Faturamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Faturamentos == null)
            {
                return NotFound();
            }

            var faturamento = await _context.Faturamentos
                .Include(f => f.Mei)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faturamento == null)
            {
                return NotFound();
            }

            return View(faturamento);
        }

        // POST: Faturamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Faturamentos == null)
            {
                return Problem("Entity set 'AppDbContext.Faturamentos'  is null.");
            }
            var faturamento = await _context.Faturamentos.FindAsync(id);
            if (faturamento != null)
            {
                _context.Faturamentos.Remove(faturamento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaturamentoExists(int id)
        {
            return _context.Faturamentos.Any(e => e.Id == id);
        }
        public async Task<IActionResult> GerarPDFFaturamentos()
        {
            // Busca todos os faturamentos no banco de dados
            var faturamentos = await _context.Faturamentos.ToListAsync();

            // Cria um stream de memória para armazenar o PDF
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = new PdfWriter(memoryStream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adiciona um título ao documento
            Paragraph title = new Paragraph("Relatório de Faturamentos").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            document.Add(title);

            // Adiciona os dados dos faturamentos ao PDF
            foreach (var faturamento in faturamentos)
            {
                // Recuperar nome do profissional (MEI) com base no ID
                var profissional = await _context.Meis.FirstOrDefaultAsync(p => p.Id == faturamento.MeiId);
                var nomeProfissional = profissional != null ? profissional.Nome : "Profissional não encontrado";

                // Adiciona os detalhes de cada faturamento
                document.Add(new Paragraph($"Mês: {faturamento.Mes}"));
                document.Add(new Paragraph($"Ano: {faturamento.Ano}"));
                document.Add(new Paragraph($"Valor Bruto (R$): {faturamento.ValorBruto}"));
                document.Add(new Paragraph($"Custo Mensal (R$): {faturamento.CustoMensal}"));
                document.Add(new Paragraph($"Valor Líquido Mensal (R$): {faturamento.ValorLiquidoMensal}"));
                document.Add(new Paragraph($"Profissional: {nomeProfissional}"));

                // Adiciona uma linha em branco entre os faturamentos
                document.Add(new Paragraph("\n"));
            }

            // Fecha o documento
            document.Close();
            writer.Close();

            // Retorna o PDF gerado como um arquivo para download
            return File(memoryStream.ToArray(), "application/pdf", "RelatorioFaturamentos.pdf");
        }

    }
}

    
