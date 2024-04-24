using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class UsuarioDto
    {
        [Key]
        public int UsuarioId { get; set; }
        public string? Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
