using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class Produto
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Nome Produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Price")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }

        [StringLength(200, MinimumLength = 3)]
        public string Descricao { get; set; } = string.Empty;
        public string Imagem { get; set; }



        [ForeignKey("Categoria")]
        public int? CategoriaID { get; set; }
        public Categoria Categorias { get; set; }


        public IList<Pedido> Pedidos { get; set; } 
    }
}
