using APIPedidosRecomecar.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using APIPedidosRecomecar.Models;

namespace APIPedidosRecomecar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrinhoCompraController : ControllerBase
    {
        private readonly CarrinhoCompraService _carrinhoCompraService;
        public CarrinhoCompraController(CarrinhoCompraService carrinhoCompraService)
        {
            _carrinhoCompraService = carrinhoCompraService;
        }
        [HttpGet]
        public async Task<ActionResult<CarrinhoCompra>> Get(ulong UserId)
        {
            var carrinhoCompra = await _carrinhoCompraService.GetCarrinhoCompraByUserIdAsync(UserId);
            if (carrinhoCompra == null)
            {
                return NotFound();
            }
            return carrinhoCompra;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CarrinhoCompra newCarrinhoCompra)
        {
            Func<string> V = BsonObjectId.GenerateNewId().Value.ToString;
            newCarrinhoCompra.Id = V();
            await _carrinhoCompraService.CreateCarrinhoCompraAsync(newCarrinhoCompra);
            return CreatedAtAction(nameof(Get), new { id = newCarrinhoCompra.Id, newCarrinhoCompra });
        }

    }
}
