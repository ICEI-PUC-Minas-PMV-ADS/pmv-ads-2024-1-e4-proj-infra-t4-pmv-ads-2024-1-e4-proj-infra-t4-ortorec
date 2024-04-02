using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class AgendamentoServico
    {
        [Key]
        public int AgendamentoServicoId { get; set; }

        public string? DataAgendamento {  get; set; }
    }
}
