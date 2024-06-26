﻿using iText.Kernel.Pdf;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using iText.Layout;
using Smartmei.Models;

public class EventosController : Controller
{
    private readonly AppDbContext _context;

    public EventosController(AppDbContext context)
    {
        _context = context;
    }


    public async Task<IActionResult> Index(string projetoNome, DateTime? dataEventoInicio)
    {
        // Query inicial
        var eventoQuery = _context.Eventos.AsQueryable();

        // Aplicar filtro pelo nome do projeto, se fornecido
        if (!string.IsNullOrEmpty(projetoNome))
        {
            eventoQuery = eventoQuery.Where(e => e.Projeto.Nome.Contains(projetoNome));
        }

        // Aplicar filtro pela data de início, se fornecida
        if (dataEventoInicio.HasValue)
        {
            eventoQuery = eventoQuery.Where(p => p.DataEventoInicio.Date == dataEventoInicio.Value.Date);
        }

        // Incluir entidades relacionadas, se necessário
        eventoQuery = eventoQuery.Include(e => e.Projeto);

        var eventos = await eventoQuery.ToListAsync();

        return View(eventos);
    }


    // GET: Eventos/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var evento = await _context.Eventos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (evento == null)
        {
            return NotFound();
        }

        return View(evento);
    }

    // GET: Eventos/Create
    public IActionResult Create()
    {
        // Popule ViewBag.ProjetoId com os projetos disponíveis
        ViewBag.ProjetoId = new SelectList(_context.Projetos, "Id", "Nome");
        return View(new Evento());
    }

    // POST: Eventos/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ProjetoId,DataEventoInicio,DataEventoFim,ValorDiaria,Cidade,Estado")] Evento evento)
    {
        if (ModelState.IsValid)
        {
            _context.Add(evento);
            await _context.SaveChangesAsync();

            TempData["Mensagem"] = "Evento criado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        return View(evento);
    }

    // GET: Eventos/Edit/5
    public async Task<IActionResult> Edit(int? id )
    {
        if (id == null || _context.Eventos == null)
        {
            return NotFound();
        }

        var evento = await _context.Eventos.FindAsync(id);
        if (evento == null)
        {
            return NotFound();
        }
        ViewData["ProjetoId"] = new SelectList(_context.Projetos, "Id", "Nome", evento.ProjetoId);
        return View(evento);
    }

    // POST: Eventos/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,ProjetoId,DataEventoInicio,DataEventoFim,ValorDiaria,Cidade,Estado")] Evento evento)
    {
        if (id != evento.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(evento);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Evento atualizado com sucesso!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventoExists(evento.Id))
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
        return View(evento);
    }

    // GET: Eventos/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var evento = await _context.Eventos
            .FirstOrDefaultAsync(m => m.Id == id);
        if (evento == null)
        {
            return NotFound();
        }

        return View(evento);
    }

    // POST: Eventos/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);
        _context.Eventos.Remove(evento);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EventoExists(int id)
    {
        return _context.Eventos.Any(e => e.Id == id);
    }

    public async Task<IActionResult> GerarPDFEventos()
    {
        // Busca todos os eventos no banco de dados
        var eventos = await _context.Eventos.ToListAsync();

        // Cria um stream de memória para armazenar o PDF
        MemoryStream memoryStream = new MemoryStream();
        PdfWriter writer = new PdfWriter(memoryStream);
        PdfDocument pdf = new PdfDocument(writer);
        Document document = new Document(pdf);

        // Adiciona um título ao documento
        Paragraph title = new Paragraph("Relatório de Eventos").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
        document.Add(title);

        // Adiciona os dados dos eventos ao PDF
        foreach (var evento in eventos)
        {
            // Recuperar o nome do projeto com base no ID
            var projeto = await _context.Projetos.FirstOrDefaultAsync(p => p.Id == evento.ProjetoId);
            var nomeProjeto = projeto != null ? projeto.Nome : "Projeto não encontrado";

            // Adiciona os detalhes de cada evento
            document.Add(new Paragraph($"Projeto: {nomeProjeto}"));
            document.Add(new Paragraph($"Data de início do evento: {evento.DataEventoInicio}"));
            document.Add(new Paragraph($"Data final do evento: {evento.DataEventoFim}"));
            document.Add(new Paragraph($"Valor da diária (R$): {evento.ValorDiaria}"));
            document.Add(new Paragraph($"Cidade: {evento.Cidade}"));
            document.Add(new Paragraph($"Estado: {evento.Estado}"));

            // Adiciona uma linha em branco entre os eventos
            document.Add(new Paragraph("\n"));
        }

        // Fecha o documento
        document.Close();
        writer.Close();

        // Retorna o PDF gerado como um arquivo para download
        return File(memoryStream.ToArray(), "application/pdf", "RelatorioEventos.pdf");
    }

}


