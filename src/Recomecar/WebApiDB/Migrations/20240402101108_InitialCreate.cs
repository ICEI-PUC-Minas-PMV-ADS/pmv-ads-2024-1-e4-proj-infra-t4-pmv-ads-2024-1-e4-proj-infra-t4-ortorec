using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiDB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    ServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pago = table.Column<bool>(type: "bit", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID");
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: true),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PagamentoConfirmado = table.Column<bool>(type: "bit", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    ServicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                    table.ForeignKey(
                        name: "FK_Pedidos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId");
                    table.ForeignKey(
                        name: "FK_Pedidos_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "ServicoId");
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "AgendamentoServicos",
                columns: table => new
                {
                    AgendamentoServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAgendamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendamentoServicos", x => x.AgendamentoServicoId);
                    table.ForeignKey(
                        name: "FK_AgendamentoServicos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId");
                });

            migrationBuilder.InsertData(
                table: "AgendamentoServicos",
                columns: new[] { "AgendamentoServicoId", "DataAgendamento", "PedidoId" },
                values: new object[] { 1, "01/01/2030", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "CategoriaNome" },
                values: new object[,]
                {
                    { 1, "Cadeira de Rodas" },
                    { 2, "Andarilho" },
                    { 3, "Cama Articulada" }
                });

            migrationBuilder.InsertData(
                table: "Servicos",
                columns: new[] { "ServicoId", "Descricao", "Imagem", "Pago", "Preco" },
                values: new object[,]
                {
                    { 1, "Aluguel de Equipamento", "", true, 50m },
                    { 2, "Assistente Social", "", false, 0m },
                    { 3, "Manutencao", "", false, 0m }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Email", "Image", "Nome", "Password" },
                values: new object[,]
                {
                    { 1, "janinhabbs@hotmail", ".", "Janaina Leal", "123456*" },
                    { 2, "iancorrea@hotmail", ".", "Ian Merlo Corrêa", "123456*" },
                    { 3, "leandroreis@hotmail", ".", "Leandro Henrique de Oliveira Reis", "123456*" },
                    { 4, "marcosmaciel@hotmail", ".", "Marcos Paulo Assiz Maciel", "123456*" },
                    { 5, "ricardojunior@hotmail", ".", "Ricardo Moreira Siqueira Junior", "123456*" },
                    { 6, "silbarbosa@hotmail", ".", "Silmara Eugênia Barbosa", "123456*" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaID", "Descricao", "Imagem", "NomeProduto", "Preco" },
                values: new object[,]
                {
                    { 1, 1, "Cadeira de rodas Breezy 90: a solução econômica perfeita. Com detalhes surpreendentes, como cruzeta tubular e tecido de nylon com tela dupla no assento para maior suporte. Possui bolsa nas costas e inclui kit de ferramentas e bomba. Disponível em versões Trânsito ou Autopropulsável, com rodas traseiras grandes ou pequenas.", "/img/cadeira-de-rodas-breezy-90.webp", "Cadeira de Rodas Breezy 90", 150m },
                    { 2, 2, "Andarilho fixo em alumínio. Um auxiliar óptimo para o treino da marcha com maior segurança. A possibilidade de regulação em altura permite a correcta adaptação ao usuário", "/img/andarilho-fixo-de-aluminio-orthos-xxi", "Andarilho fixo em Alumínio A1 / A2", 150m },
                    { 3, 3, "Cama articulada elétrica com sistema elevatório tipo “tesoura”. Estrado articulado elétrico e conjunto de guardas e cabeceiras.", "/img/cama-articulada-eletrica-com-elevacao-tesoura", "Cama Articulada Eléctrica com Elevação", 150m }
                });

            migrationBuilder.InsertData(
                table: "Pedidos",
                columns: new[] { "PedidoId", "PagamentoConfirmado", "ProdutoId", "Quantidade", "ServicoId", "UsuarioId", "ValorTotal" },
                values: new object[] { 1, false, 1, 1, 1, 1, 200m });

            migrationBuilder.CreateIndex(
                name: "IX_AgendamentoServicos_PedidoId",
                table: "AgendamentoServicos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ProdutoId",
                table: "Pedidos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ServicoId",
                table: "Pedidos",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UsuarioId",
                table: "Pedidos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaID",
                table: "Produtos",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendamentoServicos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
