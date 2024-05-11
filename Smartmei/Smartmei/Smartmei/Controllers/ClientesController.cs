using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: Clientes
        public async Task<IActionResult> Index(string nome, string productOwner)
        {
            var clienteQuery = _context.Clientes.AsQueryable();

            // Aplicar filtros, se o nome do cliente for fornecido
            if (!string.IsNullOrEmpty(nome))
            {
                clienteQuery = clienteQuery.Where(c => c.Nome.Contains(nome));
            }

            // Aplicar filtro por ProductOwner, se fornecido
            if (!string.IsNullOrEmpty(productOwner))
            {
                clienteQuery = clienteQuery.Where(c => c.ProductOwner.Contains(productOwner));
            }

            // Executar a consulta e converter em uma lista
            var clientes = await clienteQuery.ToListAsync();

            // Retornar a lista de clientes para a view
            return View(clientes);
        }




        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Cliente()); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CNPJ,Telefone,Email,Cidade,Estado,ProductOwner,Observacao")] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest(); 
            }

            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CNPJ,Telefone,Email,Cidade,Estado,ProductOwner,Observacao")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
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
