using System.ComponentModel.DataAnnotations;

namespace API_Recomecar_Login.Models
{
    public class Compra : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Produto { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public TipoPagamento TipoPagamento { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }

    public enum TipoPagamento {         
           CartaoCredito = 1,
           Boleto = 2,
           Pix = 3
       }
}
