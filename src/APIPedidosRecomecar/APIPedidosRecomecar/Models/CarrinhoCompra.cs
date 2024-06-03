using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Numerics;
using ThirdParty.Json.LitJson;

namespace APIPedidosRecomecar.Models
{
    public class CarrinhoCompra
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("NomeProduto")]
        public string NomeProduto { get; set; } = null!;
        [BsonElement("Preco")]
        public double Preco { get; set; }
        [BsonElement("UserId")]
        public ulong UserId { get; set; }

    }
}
