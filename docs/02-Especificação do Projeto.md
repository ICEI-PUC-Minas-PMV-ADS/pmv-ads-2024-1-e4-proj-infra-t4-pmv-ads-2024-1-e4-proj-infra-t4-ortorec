# Especificações do Projeto

A determinação exata do problema, suas personas, requisitos funcionais e não-funcionais foram acordadas em reuniões online entre os membros da equipe. Através de pesquisas e observações, foi possível reunir as informações que auxiliaram na construção de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

![Persona-1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-1.png)

![Persona-2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-2.png)

![Persona-3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-3.png)

![Persona-4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-4.png)

![Persona-5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-5.png)

![Persona-6](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/1042692c54aa19026282def7fbaa1064fbe462ca/docs/img/Persona-6.png)


## Histórias de Usuários

A partir da análise das personas, foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Camila Larissa    | Uma cadeira ergonômica e suporte para laptop ajustável ou almofada ergonómica.                 | Melhorar minha postura durante longas horas de pesquisa sobre benefícios alimentares e análise de opções disponíveis. |
|Marina Silva   | Almofadas ergonômicas para suporte lombar.                 | As almofadas ergonômicas proporcionarão suporte lombar, melhorando a postura durante longas horas de trabalho como gerente de projetos. |
|Marina Silva   | Joelheiras para corrida.                 | As joelheiras garantirão conforto e proteção durante minhas corridas, permitindo-me manter minha rotina de exercícios sem preocupações com lesões. |
|Caio Lucas  | Opção de aluguel na loja online de produtos ortopédicos para muletas temporárias e outros produtos ortopédicos.               | Alugar muletas temporárias e obter outros produtos ortopédicos, como suportes para tornozelo, joelheiras ou itens que proporcionem conforto e acelerem o processo de recuperação.  |
|Isabela Rodrigues | Uma solução rápida e eficiente para a manutenção da cama hospitalar da avó, que teve uma peça essencial quebrada.     | Oferta de serviços de manutenção para cadeiras de rodas e uma variedade de acessórios ergonômicos na loja online de produtos ortopédicos, garantindo durabilidade, eficiência e conforto personalizado. |
|Carolina Lemos | Serviços de manutenção especializada para minha cadeira de rodas e acessórios que proporcionem melhor conforto durante o uso diário.     | Oferta de serviços de manutenção para cadeiras de rodas |
|Carolina Lemos | Acessórios que proporcionem melhor conforto durante o uso diário.     | Variedade de acessórios ergonômicos na loja online de produtos ortopédicos, garantindo durabilidade, eficiência e conforto personalizado. |
|Soraia Alves | Sistema online de empréstimo de equipamentos ortopédicos na loja, oferecendo uma variedade de opções e agilidade no processo para atender às necessidades imediatas da comunidade     | Garantir que todos, independentemente de suas circunstâncias financeiras, tenham acesso a recursos essenciais para promover a melhoria de seu bem-estar. Como assistente social, quero atuar como facilitadora, proporcionando o suporte necessário para aqueles que atendo. |


## Modelagem do Processo de Negócio 

### Análise da Situação Atual

O projeto da loja online de aparelhos de produtos ortopedicos, apresenta uma abordagem robusta e bem estruturada, destacando-se pela escolha da arquitetura distribuída, que visa garantir escalabilidade, disponibilidade e desempenho.
O projeto está bem estruturado e alinhado com boas práticas de desenvolvimento, mas exige uma atenção contínua aos desafios específicos de uma loja online, como a gestão eficiente do tráfego variável e a manutenção da segurança dos dados. O monitoramento proativo e a rápida adaptação às mudanças nas demandas do sistema são aspectos críticos para o sucesso contínuo do projeto. 
A seguir, são destacados alguns pontos relevantes.


### Descrição Geral da Proposta

#### 1. Introdução
A loja online de aparelhos de reabilitação visa fornecer uma plataforma conveniente para clientes que procuram comprar produtos de reabilitação. A arquitetura distribuída foi escolhida para garantir escalabilidade, disponibilidade e desempenho.
### 2. Visão Geral da Arquitetura
A arquitetura é composta por vários componentes distribuídos, incluindo um frontend web e mobile, um backend de aplicativo, um serviço de gerenciamento de inventário, um sistema de pagamento e um banco de dados distribuído.
#### 3. Requisitos de Sistema
Funcionais: Permitir que os clientes naveguem pelos produtos, façam pedidos, realizem pagamentos e acompanhem os pedidos.
Não Funcionais: Alta disponibilidade, desempenho escalável, segurança de dados e integridade.
#### 4. Tecnologias Utilizadas
Frontend: React.js, HTML, CSS.
Backend: Node.js, Express.js.
Serviço de Gerenciamento de Inventário: Microsserviço em Node.js.
Banco de Dados: NoSQL
#### 5. Topologia da Rede
A arquitetura é hospedada em nuvem, utilizando serviços de computação e armazenamento escaláveis. O tráfego é distribuído através de um balanceador de carga.
#### 6. Componentes da Arquitetura
Frontend Web: Interface de usuário para navegar e comprar produtos.
Backend de Aplicativo: Lógica de negócios para processar pedidos, gerenciar usuários e autenticação.
Serviço de Gerenciamento de Inventário: Responsável por rastrear o estoque de produtos.
Sistema de Pagamento: Integração com um serviço de pagamento para processar transações.
Banco de Dados Distribuído: Armazenamento de dados de clientes, produtos e pedidos.
#### 7. Padrões de Projeto
Arquitetura de Microsserviços: Cada componente é desenvolvido como um microsserviço independente.
RESTful API: Comunicação entre os componentes via APIs REST.
#### 8. Segurança
Autenticação e Autorização: Utilização de tokens JWT para autenticar usuários e autorizar acessos.
HTTPS: Comunicação segura entre o cliente e o servidor.
#### 9. Monitoramento e Gerenciamento
Utilização de ferramentas de monitoramento para acompanhar o desempenho do sistema e identificar problemas.
Automação de implantação e escalabilidade usando contêineres e orquestradores como Docker e Kubernetes.
#### 10. Escalabilidade e Tolerância a Falhas
Escalabilidade Horizontal: Adição dinâmica de recursos para lidar com aumentos de tráfego.
Replicação de Dados: Dados distribuídos e replicados para garantir disponibilidade e tolerância a falhas.
#### 11. Considerações de Implantação
Implantação automatizada usando pipelines de CI/CD.
Testes de carga e estresse para validar a escalabilidade da arquitetura.
#### 12. Exemplos de Uso
Navegar pelos produtos.
Adicionar produtos ao carrinho.
Realizar pagamentos.
Acompanhar o status do pedido.


### Processo 1 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 1. Em seguida, apresente o modelo do processo 1, descrito no padrão BPMN. 

![Processo 1](img/02-bpmn-proc1.png)

### Processo 2 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 2. Em seguida, apresente o modelo do processo 2, descrito no padrão BPMN.

![Processo 2](img/02-bpmn-proc2.png)

## Indicadores de Desempenho

Apresente aqui os principais indicadores de desempenho e algumas metas para o processo. Atenção: as informações necessárias para gerar os indicadores devem estar contempladas no diagrama de classe. Colocar no mínimo 5 indicadores. 

Usar o seguinte modelo: 

![Indicadores de Desempenho](img/02-indic-desemp.png)
Obs.: todas as informações para gerar os indicadores devem estar no diagrama de classe a ser apresentado a posteriori. 

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|--------|-----------------------------------------|----|
|RF001| O sistema deve permitir o cadastro, alteração e cancelamento de perfil do usuário | ALTA | 
|RF002| O sistema deve permitir ao usuário criar, alterar e recuperar sua senha | ALTA |
|RF003| O sistema deve permitir ao usuário criar, alterar e recuperar sua senha | ALTA |
|RF004| Deve ser possível ao administrador cadastrar, alterar e excluir produtos no sistema | ALTA |
|RF005| O sistema deve possibilitar a busca de um produto específico | BAIXA |
|RF006| O sistema deve permitir o controle do estoque de produtos | MÉDIA |
|RF007| O sistema deve emitir alertas automáticos para níveis baixos de estoque | BAIXO |
|RF008| O sistema deve ter integração com meios de pagamento online e offline (cartões de crédito, débito, boleto bancário, pix) | ALTA |
|RF009| O sistema deve ter integração com sistemas de teleatendimento e chat online para oferecer suporte ao cliente em tempo real | BAIXA |
|RF010|O sistema deve permitir ao usuário visualizar os produtos oferecidos por categorias | MÉDIA |
|RF011| O sistema deve oferecer ao usuário opções de agendamento (data) para execução de manutenção de equipamentos | MÉDIA |
|RF012| O sistema deve fornecer um formulário para recebimento de doações de produtos | BAIXA |
|RF013| O sistema deve oferecer ao usuário opções de agendamento (data/horário) para ser atendido na loja (página de ação social) | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-----------|-------------------------|----|
|RNF001| O sistema deve ser executado em dispositivos móveis e em computadores | ALTA | 
|RNF002| O tempo de resposta da aplicação deve ser inferior a 5 segundos para operações críticas, como login, pesquisa de produtos e finalização de compra |  MÉDIA | 
|RNF003| O sistema deve apresentar uma interface de usuário intuitiva | ALTA |
|RNF004| O sistema deve ser distribuído executando na nuvem  | ALTA | 
|RNF005| O sistema deve utilizar o SGBD NoSQL | ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![Persona-1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/blob/3461b801b3b0dfd6709f29844ab3a814cc65de74/docs/img/diagrama%20de%20casos%20de%20uso.jpg)

# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)


# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

![Diagrama de rede simplificado notação francesa (método francês)](img/02-diagrama-rede-simplificado.png)

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.

![Gráfico de Gantt](img/02-grafico-gantt.png)

## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados. 

![Simple Project Timeline](img/02-project-timeline.png)

## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

![Orçamento](img/02-orcamento.png)
