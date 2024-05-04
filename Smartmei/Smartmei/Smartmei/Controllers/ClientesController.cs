using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartmei.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Threading.Tasks;



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

        public async Task<IActionResult> GerarPDFClientes()
        {
            // Busca todos os clientes no banco de dados
            var clientes = await _context.Clientes.ToListAsync();

            // Cria um stream de memória para armazenar o PDF
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = new PdfWriter(memoryStream);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adiciona um título ao documento
            Paragraph title = new Paragraph("Relatório de Clientes").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            document.Add(title);

            // Adiciona os dados dos clientes ao PDF
            foreach (var cliente in clientes)
            {
                // Adiciona os detalhes de cada cliente
                document.Add(new Paragraph($"Nome: {cliente.Nome}"));
                document.Add(new Paragraph($"CNPJ: {cliente.CNPJ}"));
                document.Add(new Paragraph($"Telefone: {cliente.Telefone}"));
                document.Add(new Paragraph($"Email: {cliente.Email}"));
                document.Add(new Paragraph($"Cidade: {cliente.Cidade}"));
                document.Add(new Paragraph($"Estado: {cliente.Estado}"));
                document.Add(new Paragraph($"Product Owner: {cliente.ProductOwner}"));
                document.Add(new Paragraph($"Observação: {cliente.Observacao}"));

                // Adiciona uma linha em branco entre os clientes
                document.Add(new Paragraph("\n"));
            }

            // Fecha o documento
            document.Close();
            writer.Close();

            // Retorna o PDF gerado como um arquivo para download
            return File(memoryStream.ToArray(), "application/pdf", "RelatorioClientes.pdf");
        }
    }
                
     }








