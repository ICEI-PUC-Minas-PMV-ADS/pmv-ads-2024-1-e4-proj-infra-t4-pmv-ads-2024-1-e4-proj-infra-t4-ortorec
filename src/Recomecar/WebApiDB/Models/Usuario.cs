using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Name")]
        [StringLength(60, MinimumLength = 3)]

        [Display(Name = "Name")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Email")]
        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        public string? Image { get; set; }

        public IList<Pedido>? Pedidos { get; set; } 
    }   
}
