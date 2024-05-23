using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiDB.Migrations
{
    public partial class AddColumn01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Adicionar a coluna TipoUsuario à tabela Usuarios
            migrationBuilder.AddColumn<int>(
                name: "TipoUsuario",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            // Verificar se a tabela "Categorias" já existe antes de criar
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Categorias' AND xtype='U')
                BEGIN
                    CREATE TABLE [Categorias] (
                        [CategoriaID] int NOT NULL IDENTITY,
                        [CategoriaNome] nvarchar(max) NULL,
                        CONSTRAINT [PK_Categorias] PRIMARY KEY ([CategoriaID])
                    );
                END
            ");

            // Verificar se a tabela "Servicos" já existe antes de criar
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Servicos' AND xtype='U')
                BEGIN
                    CREATE TABLE [Servicos] (
                        [ServicoId] int NOT NULL IDENTITY,
                        [Descricao] nvarchar(max) NULL,
                        [Pago] bit NULL,
                        [Preco] decimal(18,2) NULL,
                        [Imagem] nvarchar(max) NULL,
                        CONSTRAINT [PK_Servicos] PRIMARY KEY ([ServicoId])
                    );
                END
            ");

            // Verificar se a tabela "Produtos" já existe antes de criar
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Produtos' AND xtype='U')
                BEGIN
                    CREATE TABLE [Produtos] (
                        [ProdutoId] int NOT NULL IDENTITY,
                        [NomeProduto] nvarchar(max) NULL,
                        [Preco] decimal(18,2) NOT NULL,
                        [Descricao] nvarchar(max) NULL,
                        [Imagem] nvarchar(max) NULL,
                        [CategoriaID] int NULL,
                        CONSTRAINT [PK_Produtos] PRIMARY KEY ([ProdutoId]),
                        CONSTRAINT [FK_Produtos_Categorias_CategoriaID] FOREIGN KEY ([CategoriaID]) REFERENCES [Categorias]([CategoriaID])
                    );
                END
            ");

            // Verificar se a tabela "Pedidos" já existe antes de criar
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Pedidos' AND xtype='U')
                BEGIN
                    CREATE TABLE [Pedidos] (
                        [PedidoId] int NOT NULL IDENTITY,
                        [Quantidade] int NULL,
                        [ValorTotal] decimal(18,2) NULL,
                        [PagamentoConfirmado] bit NULL,
                        [UsuarioId] int NULL,
                        [ProdutoId] int NULL,
                        [ServicoId] int NULL,
                        CONSTRAINT [PK_Pedidos] PRIMARY KEY ([PedidoId]),
                        CONSTRAINT [FK_Pedidos_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos]([ProdutoId]),
                        CONSTRAINT [FK_Pedidos_Servicos_ServicoId] FOREIGN KEY ([ServicoId]) REFERENCES [Servicos]([ServicoId]),
                        CONSTRAINT [FK_Pedidos_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios]([UsuarioId])
                    );
                END
            ");

            // Verificar se a tabela "AgendamentoServicos" já existe antes de criar
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AgendamentoServicos' AND xtype='U')
                BEGIN
                    CREATE TABLE [AgendamentoServicos] (
                        [AgendamentoServicoId] int NOT NULL IDENTITY,
                        [DataAgendamento] nvarchar(max) NULL,
                        [PedidoId] int NULL,
                        CONSTRAINT [PK_AgendamentoServicos] PRIMARY KEY ([AgendamentoServicoId]),
                        CONSTRAINT [FK_AgendamentoServicos_Pedidos_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedidos]([PedidoId])
                    );
                END
            ");

            // Inserir dados nas tabelas se estiverem vazias
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM AgendamentoServicos)
                BEGIN
                    INSERT INTO [AgendamentoServicos] ([DataAgendamento], [PedidoId]) VALUES ('01/01/2030', NULL);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM Categorias)
                BEGIN
                    INSERT INTO [Categorias] ([CategoriaNome]) VALUES
                    ('Cadeira de Rodas'),
                    ('Andarilho'),
                    ('Cama Articulada');
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM Servicos)
                BEGIN
                    INSERT INTO [Servicos] ([Descricao], [Imagem], [Pago], [Preco]) VALUES
                    ('Aluguel de Equipamento', '', 1, 50.00),
                    ('Assistente Social', '', 0, 0.00),
                    ('Manutencao', '', 0, 0.00);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM Usuarios)
                BEGIN
                    INSERT INTO [Usuarios] ([Nome], [Email], [Password], [Image], [TipoUsuario]) VALUES
                    ('Janaina Leal', 'janinhabbs@hotmail', '123456*', '.', 1),
                    ('Ian Merlo Corrêa', 'iancorrea@hotmail', '123456*', '.', 1),
                    ('Leandro Henrique de Oliveira Reis', 'leandroreis@hotmail', '123456*', '.', 1),
                    ('Marcos Paulo Assiz Maciel', 'marcosmaciel@hotmail', '123456*', '.', 1),
                    ('Ricardo Moreira Siqueira Junior', 'ricardojunior@hotmail', '123456*', '.', 1),
                    ('Silmara Eugênia Barbosa', 'silbarbosa@hotmail', '123456*', '.', 1);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM Produtos)
                BEGIN
                    INSERT INTO [Produtos] ([NomeProduto], [Preco], [Descricao], [Imagem], [CategoriaID]) VALUES
                    ('Cadeira de Rodas Breezy 90', 150.00, 'Cadeira de rodas Breezy 90: a solução econômica perfeita. Com detalhes surpreendentes, como cruzeta tubular e tecido de nylon com tela dupla no assento para maior suporte. Possui bolsa nas costas e inclui kit de ferramentas e bomba. Disponível em versões Trânsito ou Autopropulsável, com rodas traseiras grandes ou pequenas.', '/img/cadeira-de-rodas-breezy-90.webp', 1),
                    ('Andarilho fixo em Alumínio A1 / A2', 150.00, 'Andarilho fixo em alumínio. Um auxiliar óptimo para o treino da marcha com maior segurança. A possibilidade de regulação em altura permite a correcta adaptação ao usuário', '/img/andarilho-fixo-de-aluminio-orthos-xxi', 2),
                    ('Cama Articulada Eléctrica com Elevação', 150.00, 'Cama articulada elétrica com sistema elevatório tipo “tesoura”. Estrado articulado elétrico e conjunto de guardas e cabeceiras.', '/img/cama-articulada-eletrica-com-elevacao-tesoura', 3);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT 1 FROM Pedidos)
                BEGIN
                    INSERT INTO [Pedidos] ([Quantidade], [ValorTotal], [PagamentoConfirmado], [UsuarioId], [ProdutoId], [ServicoId]) VALUES
                    (1, 200.00, 0, 1, 1, 1);
                END
            ");


            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_AgendamentoServicos_PedidoId' AND object_id = OBJECT_ID('AgendamentoServicos'))
                BEGIN
                    CREATE INDEX IX_AgendamentoServicos_PedidoId ON AgendamentoServicos(PedidoId);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Pedidos_ProdutoId' AND object_id = OBJECT_ID('Pedidos'))
                BEGIN
                    CREATE INDEX IX_Pedidos_ProdutoId ON Pedidos(ProdutoId);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Pedidos_ServicoId' AND object_id = OBJECT_ID('Pedidos'))
                BEGIN
                    CREATE INDEX IX_Pedidos_ServicoId ON Pedidos(ServicoId);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Pedidos_UsuarioId' AND object_id = OBJECT_ID('Pedidos'))
                BEGIN
                    CREATE INDEX IX_Pedidos_UsuarioId ON Pedidos(UsuarioId);
                END
            ");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name='IX_Produtos_CategoriaID' AND object_id = OBJECT_ID('Produtos'))
                BEGIN
                    CREATE INDEX IX_Produtos_CategoriaID ON Produtos(CategoriaID);
                END
            ");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AgendamentoServicos_PedidoId",
            //    table: "AgendamentoServicos",
            //    column: "PedidoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pedidos_ProdutoId",
            //    table: "Pedidos",
            //    column: "ProdutoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pedidos_ServicoId",
            //    table: "Pedidos",
            //    column: "ServicoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pedidos_UsuarioId",
            //    table: "Pedidos",
            //    column: "UsuarioId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produtos_CategoriaID",
            //    table: "Produtos",
            //    column: "CategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            // Remover as tabelas criadas
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
