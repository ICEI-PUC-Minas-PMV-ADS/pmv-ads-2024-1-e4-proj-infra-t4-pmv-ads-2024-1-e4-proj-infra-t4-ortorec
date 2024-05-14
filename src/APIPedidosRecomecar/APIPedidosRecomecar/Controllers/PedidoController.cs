using APIPedidosRecomecar.Models;
using APIPedidosRecomecar.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace APIPedidosRecomecar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoService _pedidoService;
        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        [HttpGet]
        public async Task<List<Pedido>> Get() =>
            await _pedidoService.GetPedidosAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Pedido>> Get(string id)
        {
            var pedido = await _pedidoService.GetPedidosAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return pedido;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Pedido newPedido)
        {
            Func<string> V = BsonObjectId.GenerateNewId().Value.ToString;
            newPedido.Id = V();
            await _pedidoService.CreateAsync(newPedido);
            return CreatedAtAction(nameof(Get), new { id = newPedido.Id, newPedido });
        }
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Pedido updatedPedido)
        {

            var pedido = await _pedidoService.GetPedidosAsync(id);
            if (pedido is null)
                return NotFound();
            updatedPedido.Id = pedido.Id;
            await _pedidoService.UpdateAsync(id, updatedPedido);
            return NoContent();
        }
        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {

            var pedido = await _pedidoService.GetPedidosAsync(id);
            if (pedido is null)
                return NotFound();
            await _pedidoService.RemoveAsync(id);
            return NoContent();
        }

    }
}
