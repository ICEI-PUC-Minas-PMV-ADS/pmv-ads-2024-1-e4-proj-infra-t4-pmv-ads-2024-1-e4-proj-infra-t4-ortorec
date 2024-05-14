using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApiDB.Data;
using WebApiDB.Models;

namespace WebApiDB.Controllers
{
    public class AgendamentoServicoesController : Controller
    {
        private readonly RecomecarDBContext _context;

        public AgendamentoServicoesController(RecomecarDBContext context)
        {
            _context = context;
        }

        // GET: AgendamentoServicoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgendamentoServicos.ToListAsync());
        }

        // GET: AgendamentoServicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamentoServico = await _context.AgendamentoServicos
                .FirstOrDefaultAsync(m => m.AgendamentoServicoId == id);
            if (agendamentoServico == null)
            {
                return NotFound();
            }

            return View(agendamentoServico);
        }

        // GET: AgendamentoServicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgendamentoServicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AgendamentoServicoId,DataAgendamento")] AgendamentoServico agendamentoServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendamentoServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agendamentoServico);
        }

        // GET: AgendamentoServicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamentoServico = await _context.AgendamentoServicos.FindAsync(id);
            if (agendamentoServico == null)
            {
                return NotFound();
            }
            return View(agendamentoServico);
        }

        // POST: AgendamentoServicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AgendamentoServicoId,DataAgendamento")] AgendamentoServico agendamentoServico)
        {
            if (id != agendamentoServico.AgendamentoServicoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agendamentoServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendamentoServicoExists(agendamentoServico.AgendamentoServicoId))
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
            return View(agendamentoServico);
        }

        // GET: AgendamentoServicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendamentoServico = await _context.AgendamentoServicos
                .FirstOrDefaultAsync(m => m.AgendamentoServicoId == id);
            if (agendamentoServico == null)
            {
                return NotFound();
            }

            return View(agendamentoServico);
        }

        // POST: AgendamentoServicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agendamentoServico = await _context.AgendamentoServicos.FindAsync(id);
            if (agendamentoServico != null)
            {
                _context.AgendamentoServicos.Remove(agendamentoServico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendamentoServicoExists(int id)
        {
            return _context.AgendamentoServicos.Any(e => e.AgendamentoServicoId == id);
        }
    }
}
