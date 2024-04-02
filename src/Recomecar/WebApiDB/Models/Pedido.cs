using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public int? Quantidade { get; set; }

        public decimal? ValorTotal { get; set; }

        public bool? PagamentoConfirmado { get; set; } = false;


        [ForeignKey("Usuario")]
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("Produto")]
        public int? ProdutoId { get; set; }
        public Produto? Produtos { get; set; }

        [ForeignKey("Servico")]
        public int? ServicoId { get; set; }
        public Servico? Servicos { get; set; }
        public IList<AgendamentoServico>? AgendamentoServicos { get; set; }
    }
}
