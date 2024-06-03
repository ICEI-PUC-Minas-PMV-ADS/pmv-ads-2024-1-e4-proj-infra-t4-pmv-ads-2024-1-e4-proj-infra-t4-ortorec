using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Numerics;
using ThirdParty.Json.LitJson;
namespace APIPedidosRecomecar.Models
{
    public class Pedido
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("NumeroPedido")]
        public ulong NumeroPedido { get; set; }

        [BsonElement("DataHoraPedido")]
        public DateTime DataHoraPedido { get; set; } = DateTime.Now;

        [BsonElement("ValorTotal")]
        public double ValorTotal { get; set; }

        [BsonElement("TotalItens")]
        public int TotalItens { get; set; } = 0;

        [BsonElement("ProdutosIds")]
        public ulong[] ProdutosIds { get; set; } = new ulong[0];

        [BsonElement("Cliente")]
        public Cliente? Cliente { get; set; }

        [BsonElement("Pagamento")]
        public Pagamento? Pagamento { get; set; }


    }

    public class Cliente {
        [BsonElement("NomeCliente")]
        public string NomeCliente { get; set; } = null!;

        [BsonElement("Endereco")]
        public string Endereco { get; set; } = null!;

        [BsonElement("CPF")]
        public string CPF { get; set; } = null!;

    }

    public class Pagamento
    {
        [BsonElement("FormaPagamento")]
        public int FormaPagamento { get; set; } = 0;

        [BsonElement("Descricao")]
        public string Descricao { get; set; } = null!;

    }

}
