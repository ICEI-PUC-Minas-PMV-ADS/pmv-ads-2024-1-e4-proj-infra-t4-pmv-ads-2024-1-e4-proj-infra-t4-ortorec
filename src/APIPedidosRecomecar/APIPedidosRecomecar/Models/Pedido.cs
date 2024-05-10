using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace APIPedidosRecomecar.Models
{
    public class Pedido
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public ulong NumeroPedido { get; set; }
        [BsonElement("Name")]

        public DateTime DataHoraPedido { get; set; } = DateTime.Now;
       

        public decimal ValorTotalPedido { get; } = 0;
    

        public int TotalItens { get; set; } = 0;
 

        public Array ListaProdutosId = new Array[0];
        
    }

    public class Cliente {
        public string NomeCliente { get; set; } = null!;

        public string Endereco { get; set; } = null!;

        public string CPF { get; set; } = null!;

    }

    public class MetodoPagamento
    {
        public int TipoPagamento { get; set; } = 0;

        public string Descricao { get; set; } = null!;

    }
}
