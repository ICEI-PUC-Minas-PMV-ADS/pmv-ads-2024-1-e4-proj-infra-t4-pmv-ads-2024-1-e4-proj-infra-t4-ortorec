using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }
        public IList<Pedido>? Pedidos { get; set; } 
    }   
}
