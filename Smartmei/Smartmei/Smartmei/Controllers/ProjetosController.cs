using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iText.Commons.Actions.Contexts;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;

namespace Smartmei.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly AppDbContext _context;

        public ProjetosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Projetos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Projetos.Include(p => p.Cliente).Include(p => p.Mei);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Projetos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Projetos == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos
                .Include(p => p.Cliente)
                .Include(p => p.Mei)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return View(projeto);
        }

        // GET: Projetos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome");
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome");
            return View();
        }

        // POST: Projetos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,ClienteId,DataInicioProjeto,DataFimProjeto,QuantidadeTelas,ValorTela,ValorTotalProjeto,PrazoPagamento,DataEmissaoNF,DataPagamentoNF,Acompanhamento,LinkDrive,Observacao,MeiId")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projeto);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Projeto criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // GET: Projetos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Projetos == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // POST: Projetos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,ClienteId,DataInicioProjeto,DataFimProjeto,QuantidadeTelas,ValorTela,ValorTotalProjeto,PrazoPagamento,DataEmissaoNF,DataPagamentoNF,Acompanhamento,LinkDrive,Observacao,MeiId")] Projeto projeto)
        {
            if (id != projeto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projeto);
                    await _context.SaveChangesAsync();

                    TempData["Mensagem"] = "Projeto atualizado com sucesso!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetoExists(projeto.Id))
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

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Nome", projeto.ClienteId);
            ViewData["MeiId"] = new SelectList(_context.Meis, "Id", "Nome", projeto.MeiId);
            return View(projeto);
        }

        // GET: Projetos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Projetos == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos
                .Include(p => p.Cliente)
                .Include(p => p.Mei)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return View(projeto);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Projetos == null)
            {
                return Problem("Entity set 'AppDbContext.Projetos' is null.");
            }

            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto != null)
            {
                _context.Projetos.Remove(projeto);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = "Projeto deletado com sucesso!";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProjetoExists(int id)
        {
            return _context.Projetos.Any(e => e.Id == id);
        }

        public async Task<IActionResult> GerarPDFProjetos()
        {
            // Busca todos os projetos no banco de dados
            var projetos = await _context.Projetos.ToListAsync();

            // Cria um stream de memória para armazenar o PDF
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = new PdfWriter(memoryStream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adiciona um título ao documento
            Paragraph title = new Paragraph("Relatório de Projetos").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            document.Add(title);

            // Adiciona os dados dos projetos ao PDF
            foreach (var projeto in projetos)
            {
                // Recuperar nome do cliente com base no ID
                var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == projeto.ClienteId);
                var nomeCliente = cliente != null ? cliente.Nome : "Cliente não encontrado";

                // Recuperar nome do profissional (MEI) com base no ID
                var profissional = await _context.Meis.FirstOrDefaultAsync(p => p.Id == projeto.MeiId);
                var nomeProfissional = profissional != null ? profissional.Nome : "Profissional não encontrado";

                // Adiciona os detalhes de cada projeto
                document.Add(new Paragraph($"Titulo: {projeto.Nome}"));
                document.Add(new Paragraph($"Cliente: {nomeCliente}"));
                document.Add(new Paragraph($"Data de início do projeto: {projeto.DataInicioProjeto}"));
                document.Add(new Paragraph($"Data final do projeto: {projeto.DataFimProjeto}"));
                document.Add(new Paragraph($"Quantidade de telas: {projeto.QuantidadeTelas}"));
                document.Add(new Paragraph($"Valor da tela (R$): {projeto.ValorTela}"));
                document.Add(new Paragraph($"Valor do projeto (R$): {projeto.ValorTotalProjeto}"));
                document.Add(new Paragraph($"Prazo para pagamento (dias): {projeto.PrazoPagamento}"));
                document.Add(new Paragraph($"Data de emissão da NF: {projeto.DataEmissaoNF}"));
                document.Add(new Paragraph($"Data de pagamento da NF: {projeto.DataPagamentoNF}"));
                document.Add(new Paragraph($"Acompanhamento: {projeto.Acompanhamento}"));
                document.Add(new Paragraph($"Link do Drive: {projeto.LinkDrive}"));
                document.Add(new Paragraph($"Observação: {projeto.Observacao}"));
                document.Add(new Paragraph($"Profissional: {nomeProfissional}"));

                // Adiciona uma linha em branco entre os projetos
                document.Add(new Paragraph("\n"));
            }

            // Fecha o documento
            document.Close();
            writer.Close();

            // Retorna o PDF gerado como um arquivo para download
            return File(memoryStream.ToArray(), "application/pdf", "RelatorioProjetos.pdf");
        }
    }
}