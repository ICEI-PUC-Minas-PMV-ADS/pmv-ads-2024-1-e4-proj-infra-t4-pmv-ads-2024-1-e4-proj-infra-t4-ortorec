using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDB.Data;
using WebApiDB.Models;

namespace WebApiExternalAccess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoServicosController : ControllerBase
    {
        private readonly RecomecarDBContext _context;

        public AgendamentoServicosController(RecomecarDBContext context)
        {
            _context = context;
        }

        // GET: api/AgendamentoServicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgendamentoServico>>> GetAgendamentoServicos()
        {
            return await _context.AgendamentoServicos.ToListAsync();
        }

        // GET: api/AgendamentoServicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AgendamentoServico>> GetAgendamentoServico(int id)
        {
            var agendamentoServico = await _context.AgendamentoServicos.FindAsync(id);

            if (agendamentoServico == null)
            {
                return NotFound();
            }

            return agendamentoServico;
        }

        // PUT: api/AgendamentoServicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamentoServico(int id, AgendamentoServico agendamentoServico)
        {
            if (id != agendamentoServico.AgendamentoServicoId)
            {
                return BadRequest();
            }

            _context.Entry(agendamentoServico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendamentoServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AgendamentoServicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AgendamentoServico>> PostAgendamentoServico(AgendamentoServico agendamentoServico)
        {
            _context.AgendamentoServicos.Add(agendamentoServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgendamentoServico", new { id = agendamentoServico.AgendamentoServicoId }, agendamentoServico);
        }

        // DELETE: api/AgendamentoServicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamentoServico(int id)
        {
            var agendamentoServico = await _context.AgendamentoServicos.FindAsync(id);
            if (agendamentoServico == null)
            {
                return NotFound();
            }

            _context.AgendamentoServicos.Remove(agendamentoServico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendamentoServicoExists(int id)
        {
            return _context.AgendamentoServicos.Any(e => e.AgendamentoServicoId == id);
        }
    }
}
