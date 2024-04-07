# Arquitetura da Solução

![image](https://github.com/sil-barbosa/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106809153/6bcbd85b-a330-4d31-a957-cef3ec9693c3)

#### **Legenda:** 
Camada de API Gateway: ícones azuis \
Camada de Cache: ícone amarelo \
Camada de Segurança: ícone verde \
Camada de Serviços: ícones laranja \
Camada de Banco de dados: ícones cinza



#### **Banco De Dados NoSQL:** 

O que é e como funciona o MongoDB?
 O MongoDB é um sistema de gerenciamento de banco de dados não relacional, que utiliza documentos flexíveis em vez de tabelas e linhas para processar e armanezenar os dados. Sendo categorizado como um banco de dados não sequencial (NoSQL), não necessita de nenhum gerenciamento de tabelas ou bancos com esquemas relacionais, ele oferece um modelo de armazenamento de dados flexível, que permite aos usuários armazenar e consultar muitos dados diferentes com facilidade. Isso não apenas simplifica o gerenciamento do banco mas também cria um ambiente poderoso e escalável para serviços, aplicações e etc.
Os documentos ou coleções de documentos do MongoDB são as unidades básicas de dados, representando as tabelas no modelo relacional, são salvos como Binary JSON dentro do esquema, e podem armazenar vários tipos de dados simultâneos e ser distribuídos para diversos sistemas. A consulta desses dados são feitas atraves dos agregados, que trazem um documento podendo conter multiplas informações do, ou dos, objetos.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/DiagramaNoSQL.png?raw=true)


Por quê o MongoDB e quais as vantagens dessa escolha?
 O MongoDB possui um altissímo desempenho, bastante escalável e intuitívo, a escolha desse modelo de banco para o projeto foi escolhida principalmente visando o alto desempenho, praticidade e visando trabalhar com multiplas plataformas ao mesmo tempo, como web e mobile.
O MongoDB não é somente um banco NoSQL que armazena grandes quantidades de informações, mas tambem possui diversas funções e vantagens:
	-  Soluções de armazenamento baseadas em cloud.
	- Análises em tempo real convertendo documentos em objetos.
	- Balanceamento de carga através da sua funcionalidade de fragmentação, escalonamento horizontal e etc.
	- Consultas de banco de dados ad hoc.
	- Aceita diversas linguagens de programação. 

Alinhado com a expectativa de nosso projeto, ao termos o objeto de criar um softaware robusto e com otimo tempo de resposta, optamos por localizar uma parte dos dados no MongoDB, para manter a perfomance  de acordo com os requisitos RNF001, RNF002 e RNF005.

Exemplos práticos de suas funcionalidades:
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/IntroducaoAtlas.png?raw=true) 

Tela Inicial usando o Data Explorer, funcionalidade web do próprio MongoDB.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/ConectarMongoDb.png?raw=true)

Diferentes maneiras de se conectar e comunicar aos softwares, serviços, IDE´s e etc.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/AnalisePerformance.png?raw=true)

Análise em tempo real da perfomance e processo do banco.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/ExibirColecoes.png?raw=true)

Exibição das coleções, contendo os dados dos objetos, os diferentes bancos e etc.


 
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/CriandoColecao.png?raw=true)

Teste criando o primeiro database e a primeira coleção.


 
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/CriandoDocumento.png?raw=true)

Teste criando o primeiro documento.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/CRUD.png?raw=true)

Funcionalidades de atualizar, copiar, clonar ou excluir o documento.


 
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/CriandoEAtualizandoDocumentos.png?raw=true)

Clonando coleções e alterando os atributos.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/DadosDiferentes.png?raw=true)

Adicionando diferentes dados a diferentes documentos.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/FuncaoAgregacao.png?raw=true)

Função de agregar em ação.




Benefícios e razões do porquê o MongoDB foi escolhido para uma parte do projeto:

- Escalabilidade: Os bancos de dados NoSQL são projetados para escalar horizontalmente, o que significa que podem lidar com grandes volumes de dados distribuindo-os em vários servidores. Essa escalabilidade é particularmente útil para lidar com aplicativos de big data e aplicativos em escala web.
- Flexibilidade de Esquema: Bancos de dados NoSQL geralmente oferecem flexibilidade de esquema, permitindo que desenvolvedores armazenem vários tipos de dados sem precisar de um esquema pré-definido. Isso é particularmente útil em cenários onde a estrutura de dados é dinâmica ou evolui rapidamente.

- Alto Desempenho: Bancos de dados NoSQL são frequentemente otimizados para tipos específicos de consultas ou padrões de acesso aos dados, levando a um melhor desempenho em comparação com bancos de dados relacionais tradicionais em determinados cenários. Isso pode ser especialmente benéfico para aplicativos com alto throughput ou requisitos de baixa latência.

- Suporte para Dados Não Estruturados e Semi-estruturados: Bancos de dados NoSQL excelentes em lidar com formatos de dados não estruturados ou semi-estruturados, como JSON, XML ou pares chave-valor. Isso os torna adequados para casos de uso envolvendo tipos de dados complexos ou estruturas de dados hierárquicas.

- Facilidade de Desenvolvimento: Bancos de dados NoSQL geralmente têm APIs e modelos de dados mais simples em comparação com bancos de dados relacionais tradicionais, tornando-os mais fáceis de aprender e usar para os desenvolvedores, especialmente em ambientes de desenvolvimento ágil onde os requisitos podem mudar frequentemente.

- Suporte para Computação Distribuída: Bancos de dados NoSQL são adequados para ambientes de computação distribuída, como computação em nuvem ou arquiteturas de microsserviços, onde os dados precisam ser distribuídos e processados entre vários nós ou serviços.


#### **Estrutura do Banco De Dados NoSQL Usado:** 

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/main/docs/img/EstruturaNoSQL.png?raw=true)



## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

As referências abaixo irão auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico

### Banco de dados - criação de tabelas SQL Server (APIs)



            nammespace WebApiDB.Migrations
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
                name: "Servicos"
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




### API-Recomecar-Login
![API-Recomecar-Login Banco de Dados 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/174811fa-b316-4407-909c-4e58d1dc8013)
![API-Recomecar-Login Banco de Dados 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/6d7e087d-d7c9-44b3-90db-520141357f19)
[Uploading 20240405170611_M01.cs…]()


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)

## Qualidade de Software

**CARACTERÍSTICA**|**SUBCARACTERÍSTICA**|**JUSTIFICATIVA**|
--------------|-----------------|-------------|
Usabilidade|Inteligibilidade <br> Apreensibilidade <br> Operacionalidade |O objetivo deste projeto é desenvolver uma aplicação distribuída acessível tanto através da web quanto em dispositivos móveis. Esta aplicação fornecerá informações e mensagens, entre outros recursos, para garantir uma compreensão completa de seu funcionamento. Além disso, será criada uma interface amigável que permitirá aos usuários realizar operações de forma fácil e precisa.|
Funcionalidade| Acurácia <br>Conformidade <br>Segurança de Acesso|A aplicação será desenvolvida utilizando a Lei Geral de proteção de dados (LGPD) como base, com a autenticação do usuário através de senha e login. Se comprometendo também a alcançar o atendimento das necessidades do usuário através dos requisitos levantados.|
Portabilidade| Adaptabilidade |Apesar de ser funcional na web, o plano de desenvolvimento desse produto contempla também os usuários mobile.|
Eficiência| Comportamento em relação ao tempo | A construção da aplicação distribuída se dará observando os aspectos necessários para que o produto final seja uma ferramenta leve, capaz de gerar respostas rápidas às requisições do usuário.|
