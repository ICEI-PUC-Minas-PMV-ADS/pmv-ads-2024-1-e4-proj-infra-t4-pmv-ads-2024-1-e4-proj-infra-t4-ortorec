using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class Categoria
    {
        [Key]
        [Display(Name = "CategoriaID")]
        public int CategoriaID { get; set; }

        [Display(Name = "Categoria")]
        public string CategoriaNome { get; set; }

        public IList<Produto> Produtos { get; set; }

    }
}
