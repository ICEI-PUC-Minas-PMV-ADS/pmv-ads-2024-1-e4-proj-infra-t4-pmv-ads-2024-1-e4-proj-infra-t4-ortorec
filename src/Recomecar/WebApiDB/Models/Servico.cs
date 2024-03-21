using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }
        public string Nome { get; set; }    
        public string Tipo { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }



        [ForeignKey("TipoServico")]
        public int TipoServicoId { get; set; }    
        public TipoServico TipoServicos { get; set; }    


        public IList <Pedido> Pedidos { get; set; } 
    }
}
