using System.ComponentModel.DataAnnotations;

namespace WebApiDB.Models
{
    public class TipoServico
    {
        [Key]
        [Display(Name = "TipoServicoID")]
        public int TipoServicoId { get; set; }

        [Display(Name = "Tipo de Serviço")]
        public string NomeTipoServico { get; set; }

        public IList<Servico> TipoServicos { get; set; }

    }
}
