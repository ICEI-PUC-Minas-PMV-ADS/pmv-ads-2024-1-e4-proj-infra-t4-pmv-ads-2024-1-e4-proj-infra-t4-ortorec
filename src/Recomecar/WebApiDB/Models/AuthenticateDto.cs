using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class AuthenticateDto
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
