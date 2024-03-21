using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDB.Models
{
    public class AgendamentoServico
    {
        [Key]
        public int AgendamentoServicoId { get; set; }

        public DateTime DataAgendamento {  get; set; }


        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuarios { get; set; }

        [ForeignKey("Servico")]
        public int ServicoId { get; set; }
        public Servico? Servicos { get; set; }


    }
}
