using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }
        public string? Descricao { get; set; }
        public bool? Pago { get; set; }
        public decimal? Preco { get; set; }
        public string? Imagem { get; set; }

        public IList<Pedido>? Pedidos { get; set; } 

    }
}
