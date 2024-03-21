using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public IList<Produto>? Produtos { get; set; }

        public IList<Servico>? Servicos { get; set; }

        public decimal ValorTotal { get; set; } = 0;

        public bool PagamentoConfirmado { get; set; }
    }
}
