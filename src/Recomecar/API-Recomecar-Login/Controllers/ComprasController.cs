using API_Recomecar_Login.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Recomecar_Login.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ComprasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Compra>> GetAll()
        {
            var model = await _context.Compras.ToListAsync();
            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Compra model)
        {
            _context.Compras.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }

        [Authorize(Roles = "Administrador, Usuario")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Compra>> GetById(int id)
        {
            var model = await _context.Compras
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model == null) return NotFound();

            GerarLinks(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Compra model)
        {
            if (id != model.Id) return BadRequest();

            var modeloDb = await _context.Compras.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (modeloDb == null) return NotFound();

            _context.Compras.Update(model);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Compras.FindAsync(id);

            if (model == null) return NotFound();

            _context.Compras.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private void GerarLinks(Compra model)
        {
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "self", method: "GET"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "update", method: "PUT"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "delete", method: "DELETE"));

        }
    }
}

