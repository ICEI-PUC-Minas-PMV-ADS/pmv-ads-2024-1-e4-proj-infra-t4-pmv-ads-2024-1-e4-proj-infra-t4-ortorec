using Microsoft.EntityFrameworkCore;
using WebApiDB.Models;

namespace WebApiDB.Data
{
    public class RecomecarDB : DbContext
    {
        public RecomecarDB(DbContextOptions<RecomecarDB> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public  DbSet<Produto> Produtos { get; set; }
        public  DbSet<Categoria> Categorias { get; set; }
        public  DbSet<Servico> Servicos { get; set; }
        public  DbSet<TipoServico> TipoServicos { get; set;}
        public  DbSet<AgendamentoServico> AgendamentoServicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasKey(
              //  new Usuario() {UsuarioId = 1, Nome = "Alexandre Couto",Email = "aecmart@hotmail", Password = "", Image = "", Pedidos = ""}

                );

        }

    }
}
