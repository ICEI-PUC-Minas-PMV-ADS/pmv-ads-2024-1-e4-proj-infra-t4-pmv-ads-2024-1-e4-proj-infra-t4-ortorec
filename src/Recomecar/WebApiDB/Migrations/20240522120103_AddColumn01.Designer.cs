﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiDB.Data;

#nullable disable

namespace WebApiDB.Migrations
{
    [DbContext(typeof(RecomecarDBContext))]
    [Migration("20240522120103_AddColumn01")]
    partial class AddColumn01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiDB.Models.AgendamentoServico", b =>
                {
                    b.Property<int>("AgendamentoServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgendamentoServicoId"));

                    b.Property<string>("DataAgendamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("AgendamentoServicoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("AgendamentoServicos");

                    b.HasData(
                        new
                        {
                            AgendamentoServicoId = 1,
                            DataAgendamento = "01/01/2030"
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaID"));

                    b.Property<string>("CategoriaNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaID = 1,
                            CategoriaNome = "Cadeira de Rodas"
                        },
                        new
                        {
                            CategoriaID = 2,
                            CategoriaNome = "Andarilho"
                        },
                        new
                        {
                            CategoriaID = 3,
                            CategoriaNome = "Cama Articulada"
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<bool?>("PagamentoConfirmado")
                        .HasColumnType("bit");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal?>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("ServicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            PedidoId = 1,
                            PagamentoConfirmado = false,
                            ProdutoId = 1,
                            Quantidade = 1,
                            ServicoId = 1,
                            UsuarioId = 1,
                            ValorTotal = 200m
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<int?>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CategoriaID = 1,
                            Descricao = "Cadeira de rodas Breezy 90: a solução econômica perfeita. Com detalhes surpreendentes, como cruzeta tubular e tecido de nylon com tela dupla no assento para maior suporte. Possui bolsa nas costas e inclui kit de ferramentas e bomba. Disponível em versões Trânsito ou Autopropulsável, com rodas traseiras grandes ou pequenas.",
                            Imagem = "/img/cadeira-de-rodas-breezy-90.webp",
                            NomeProduto = "Cadeira de Rodas Breezy 90",
                            Preco = 150m
                        },
                        new
                        {
                            ProdutoId = 2,
                            CategoriaID = 2,
                            Descricao = "Andarilho fixo em alumínio. Um auxiliar óptimo para o treino da marcha com maior segurança. A possibilidade de regulação em altura permite a correcta adaptação ao usuário",
                            Imagem = "/img/andarilho-fixo-de-aluminio-orthos-xxi",
                            NomeProduto = "Andarilho fixo em Alumínio A1 / A2",
                            Preco = 150m
                        },
                        new
                        {
                            ProdutoId = 3,
                            CategoriaID = 3,
                            Descricao = "Cama articulada elétrica com sistema elevatório tipo “tesoura”. Estrado articulado elétrico e conjunto de guardas e cabeceiras.",
                            Imagem = "/img/cama-articulada-eletrica-com-elevacao-tesoura",
                            NomeProduto = "Cama Articulada Eléctrica com Elevação",
                            Preco = 150m
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Pago")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServicoId");

                    b.ToTable("Servicos");

                    b.HasData(
                        new
                        {
                            ServicoId = 1,
                            Descricao = "Aluguel de Equipamento",
                            Imagem = "",
                            Pago = true,
                            Preco = 50m
                        },
                        new
                        {
                            ServicoId = 2,
                            Descricao = "Assistente Social",
                            Imagem = "",
                            Pago = false,
                            Preco = 0m
                        },
                        new
                        {
                            ServicoId = 3,
                            Descricao = "Manutencao",
                            Imagem = "",
                            Pago = false,
                            Preco = 0m
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Email = "janinhabbs@hotmail",
                            Image = ".",
                            Nome = "Janaina Leal",
                            Password = "123456*",
                            TipoUsuario = 1
                        },
                        new
                        {
                            UsuarioId = 2,
                            Email = "iancorrea@hotmail",
                            Image = ".",
                            Nome = "Ian Merlo Corrêa",
                            Password = "123456*",
                            TipoUsuario = 1
                        },
                        new
                        {
                            UsuarioId = 3,
                            Email = "leandroreis@hotmail",
                            Image = ".",
                            Nome = "Leandro Henrique de Oliveira Reis",
                            Password = "123456*",
                            TipoUsuario = 1
                        },
                        new
                        {
                            UsuarioId = 4,
                            Email = "marcosmaciel@hotmail",
                            Image = ".",
                            Nome = "Marcos Paulo Assiz Maciel",
                            Password = "123456*",
                            TipoUsuario = 1
                        },
                        new
                        {
                            UsuarioId = 5,
                            Email = "ricardojunior@hotmail",
                            Image = ".",
                            Nome = "Ricardo Moreira Siqueira Junior",
                            Password = "123456*",
                            TipoUsuario = 1
                        },
                        new
                        {
                            UsuarioId = 6,
                            Email = "silbarbosa@hotmail",
                            Image = ".",
                            Nome = "Silmara Eugênia Barbosa",
                            Password = "123456*",
                            TipoUsuario = 1
                        });
                });

            modelBuilder.Entity("WebApiDB.Models.AgendamentoServico", b =>
                {
                    b.HasOne("WebApiDB.Models.Pedido", null)
                        .WithMany("AgendamentoServicos")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("WebApiDB.Models.Pedido", b =>
                {
                    b.HasOne("WebApiDB.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("WebApiDB.Models.Servico", "Servicos")
                        .WithMany("Pedidos")
                        .HasForeignKey("ServicoId");

                    b.HasOne("WebApiDB.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Produtos");

                    b.Navigation("Servicos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApiDB.Models.Produto", b =>
                {
                    b.HasOne("WebApiDB.Models.Categorias", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaID");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("WebApiDB.Models.Categorias", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("WebApiDB.Models.Pedido", b =>
                {
                    b.Navigation("AgendamentoServicos");
                });

            modelBuilder.Entity("WebApiDB.Models.Servico", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("WebApiDB.Models.Usuario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}