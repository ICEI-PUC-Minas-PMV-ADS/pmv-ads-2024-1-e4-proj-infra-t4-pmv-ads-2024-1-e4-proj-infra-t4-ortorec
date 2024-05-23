using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }
        public string? CategoriaNome { get; set; }
        public IList<Produto>? Produtos { get; set; }

    }
}
