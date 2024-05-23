using Microsoft.EntityFrameworkCore;
using WebApiDB.Models;

namespace WebApiDB.Data
{
    public class RecomecarDBContext(DbContextOptions<RecomecarDBContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public  DbSet<Produto> Produtos { get; set; }
        public  DbSet<Categorias> Categorias { get; set; }
        public  DbSet<Servico> Servicos { get; set; }
        public  DbSet<Pedido> Pedidos { get; set; }
        public  DbSet<AgendamentoServico> AgendamentoServicos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
            new Usuario() { UsuarioId = 1, Nome = "Janaina Leal", Email = "janinhabbs@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin },
            new Usuario() { UsuarioId = 2, Nome = "Ian Merlo Corrêa", Email = "iancorrea@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin },
            new Usuario() { UsuarioId = 3, Nome = "Leandro Henrique de Oliveira Reis", Email = "leandroreis@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin },
            new Usuario() { UsuarioId = 4, Nome = "Marcos Paulo Assiz Maciel", Email = "marcosmaciel@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin },
            new Usuario() { UsuarioId = 5, Nome = "Ricardo Moreira Siqueira Junior", Email = "ricardojunior@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin },
            new Usuario() { UsuarioId = 6, Nome = "Silmara Eugênia Barbosa", Email = "silbarbosa@hotmail", Password = "123456*", Image = ".", TipoUsuario = TipoUsuario.Admin }

                );

            modelBuilder.Entity<Produto>().HasData(
              new Produto() { ProdutoId = 1, NomeProduto = "Cadeira de Rodas Breezy 90", Preco = 150, Descricao = "Cadeira de rodas Breezy 90: a solução econômica perfeita. Com detalhes surpreendentes, como cruzeta tubular e tecido de nylon com tela dupla no assento para maior suporte. Possui bolsa nas costas e inclui kit de ferramentas e bomba. Disponível em versões Trânsito ou Autopropulsável, com rodas traseiras grandes ou pequenas.", CategoriaID = 1, Imagem = "/img/cadeira-de-rodas-breezy-90.webp" },
              new Produto() { ProdutoId = 2, NomeProduto = "Andarilho fixo em Alumínio A1 / A2", Preco = 150, Descricao = "Andarilho fixo em alumínio. Um auxiliar óptimo para o treino da marcha com maior segurança. A possibilidade de regulação em altura permite a correcta adaptação ao usuário", CategoriaID = 2, Imagem = "/img/andarilho-fixo-de-aluminio-orthos-xxi" },
              new Produto() { ProdutoId = 3, NomeProduto = "Cama Articulada Eléctrica com Elevação", Preco = 150, Descricao = "Cama articulada elétrica com sistema elevatório tipo “tesoura”. Estrado articulado elétrico e conjunto de guardas e cabeceiras.", CategoriaID = 3, Imagem = "/img/cama-articulada-eletrica-com-elevacao-tesoura" }

                );

            modelBuilder.Entity<Categorias>().HasData(
                new Categorias() { CategoriaID = 1, CategoriaNome = "Cadeira de Rodas" },
                new Categorias() { CategoriaID = 2, CategoriaNome = "Andarilho" },
                new Categorias() { CategoriaID = 3, CategoriaNome = "Cama Articulada" }
                );

            modelBuilder.Entity<Servico>().HasData(
                new Servico() { ServicoId = 1, Descricao = "Aluguel de Equipamento", Pago = true, Preco = 50, Imagem = "" },
                new Servico() { ServicoId = 2, Descricao = "Assistente Social", Pago = false, Preco = 0, Imagem = "" },
                new Servico() { ServicoId = 3, Descricao = "Manutencao", Pago = false, Preco = 0, Imagem = "" }
                );

            modelBuilder.Entity<Pedido>().HasData(
                new Pedido() { PedidoId = 1, Quantidade = 1, ValorTotal = 200, PagamentoConfirmado = false, UsuarioId = 1, ProdutoId = 1, ServicoId = 1 }
                );

            modelBuilder.Entity<AgendamentoServico>().HasData(
                new AgendamentoServico() { AgendamentoServicoId = 1, DataAgendamento = "01/01/2030" }
                );
        }
    }
}

