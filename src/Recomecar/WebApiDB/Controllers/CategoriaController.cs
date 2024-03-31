using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDB.Data;
using Microsoft.EntityFrameworkCore;
using WebApiDB.Models;

namespace WebApiDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly RecomecarDB _context;

        public CategoriaController(RecomecarDB context)
        {
               _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Categorias.ToListAsync();

            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Categoria model)
        {
            _context.Categorias.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
    }
}
