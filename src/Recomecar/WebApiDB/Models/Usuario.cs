using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApiDB.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string? Email { get; set; }
        [JsonIgnore]
        public string? Password { get; set; }
        public string? Image { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public IList<Pedido>? Pedidos { get; set; } 
    }   

    public enum TipoUsuario
    {
        [Display(Name = "Usuario")]
        User,
        [Display(Name = "Administrador")]
        Admin
    }
}
