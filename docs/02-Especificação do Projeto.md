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
#### 2. Visão Geral da Arquitetura
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

![Recomece (6)](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/2fcd7c3b-57e7-49e5-a470-75fe1e8ab8a1)

# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)


# Gerenciamento de Projeto

Considerando o desenvolvimento do código de programação para a nossa loja online de aparelhos ortopédicos, é fundamental abordar as áreas-chave de gerenciamento de projetos para garantir o sucesso da iniciativa, onde são elas:

## Integração
Na área de Integração, enfocamos a coordenação de todos os aspectos do projeto de desenvolvimento de software, desde a definição dos requisitos do cliente até a entrega final do produto. Isso inclui a criação de um plano de projeto abrangente que leve em consideração todas as etapas do desenvolvimento, desde a configuração do ambiente de desenvolvimento até a implantação do código.

## Escopo
O Gerenciamento de Escopo concentra-se em definir claramente quais funcionalidades e características estarão presentes na loja online. Isso inclui estabelecer os limites do projeto de codificação, identificar os requisitos do cliente e garantir que todas as expectativas estejam alinhadas com as capacidades técnicas da equipe de desenvolvimento.

## Cronograma (Tempo)
O Gerenciamento do Cronograma é crucial para garantir que o desenvolvimento do código ocorra dentro do prazo previsto. Isso envolve a criação de um cronograma detalhado que mapeia todas as atividades de codificação necessárias, desde a configuração do ambiente de desenvolvimento até os testes finais e a implantação.

## Custos
No Gerenciamento de Custos, estamos focados em estimar e controlar os recursos financeiros necessários para o desenvolvimento do código. Isso inclui a alocação de fundos para a contratação de desenvolvedores, aquisição de ferramentas de desenvolvimento e infraestrutura de hospedagem, bem como despesas operacionais contínuas.

## Qualidade
A qualidade do código é fundamental para garantir o desempenho e a segurança da loja online. Portanto, o Gerenciamento da Qualidade envolve a definição de padrões de codificação, a realização de revisões de código e a execução de testes de unidade e integração para garantir que o código atenda aos requisitos do cliente e esteja livre de erros.

## Recursos
O Gerenciamento de Recursos aborda a alocação eficiente de recursos humanos e tecnológicos para o desenvolvimento do código. Isso inclui a identificação das habilidades necessárias da equipe de desenvolvimento, a configuração de ambientes de desenvolvimento adequados e o uso eficaz de ferramentas de colaboração e controle de versão.

## Comunicações
A comunicação eficaz entre os membros da equipe de desenvolvimento é essencial para o sucesso do projeto. O Gerenciamento de Comunicações envolve o estabelecimento de canais de comunicação claros, a realização de reuniões regulares de acompanhamento e o compartilhamento de informações relevantes sobre o progresso do desenvolvimento.

## Riscos
O Gerenciamento de Riscos é fundamental para identificar e mitigar possíveis problemas que possam surgir durante o desenvolvimento do código. Isso inclui a análise de riscos relacionados a bugs de software, atrasos no desenvolvimento e mudanças nos requisitos do cliente, bem como a implementação de planos de contingência para lidar com esses desafios.

## Aquisições
No Gerenciamento de Aquisições, consideramos a aquisição de ferramentas e recursos externos necessários para o desenvolvimento do código. Isso pode incluir a compra de licenças de software, contratação de serviços de hospedagem na web e aquisição de plugins e bibliotecas de terceiros para estender a funcionalidade do sistema.

## Partes Interessadas
O Gerenciamento das Partes Interessadas aborda o envolvimento e gerenciamento de todas as partes interessadas no projeto de desenvolvimento de software. Isso inclui os clientes, a equipe de desenvolvimento, os investidores e quaisquer outras partes interessadas que possam ser afetadas pelo projeto. É importante garantir que todas as partes estejam alinhadas com os objetivos do projeto e informadas sobre o progresso do desenvolvimento.

Ao abordar todas essas áreas de gerenciamento de projetos de forma integrada e holística, estamos posicionando nosso projeto de desenvolvimento de software para a loja online de aparelhos ortopédicos para alcançar seus objetivos com sucesso, entregando um código de alta qualidade que atenda às necessidades dos clientes e proporcione uma experiência de usuário excepcional.

| Atividade                      | Duração Estimada | Área          |
|--------------------------------|------------------|---------------|
| Planejamento e Análise         | 2 semanas        | Integração    |
| Definição de Escopo            | 1 semana         | Escopo        |
| Definição de Cronograma        | 1 semana         | Cronograma    |
| Estimativa de Custos           | 1 semana         | Custos        |
| Planejamento de Qualidade      | 1 semana         | Qualidade     |
| Aloc. de Recursos e Equipe     | 2 semanas        | Recursos      |
| Plano de Comunicações          | 1 semana         | Comunicações  |
| Identificação de Riscos        | 1 semana         | Riscos        |
| Planejamento de Aquisições     | 1 semana         | Aquisições    |
| Engajamento de Partes Interess.| 2 semanas        | Partes Int.   |



## Gerenciamento de Tempo

![Diagrama de Rede Simplificado](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/115120672/657f4d2d-9e18-4167-95bd-5e554aa64855)


## Gerenciamento de Equipe
 

![Gerenciamento_Tarefas](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/115120672/2aaf88b7-5a34-41e7-afe0-a47c92753596)


## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

![Orçamento](img/02-orcamento.png)
