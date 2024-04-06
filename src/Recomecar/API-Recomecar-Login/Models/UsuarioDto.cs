using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Recomecar_Login.Models
{
    public class UsuarioDto : LinksHATEOS
    {
        public int? Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public TipoUsuario TipoUsuario { get; set; }
    }
}
