
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Relação de Ambientes de Trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito deverá ser apresentada em uma tabela que especifica que detalha Ambiente, Plataforma e Link de Acesso. 
Nota: Vide documento modelo do estudo de caso "Portal de Notícias" e defina também os ambientes e frameworks que serão utilizados no desenvolvimento de aplicações móveis.

| Ambiente | Plataforma | Link de Acesso | 
|----------|------------|----------------|
| Repositório do Código Fonte | Github | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec |
| Desenvolvimento da API | Visual Studio | https://visualstudio.microsoft.com/pt-br/ |
| Design do Projeto | Figma | https://www.figma.com/ |
| Gerenciamento de equipe | Trello | https://trello.com/b/8sILiOpm/grupo-1-turma-4-projeto-recome%C3%A7ar |
| Serviços de Cloud Computing | AWS | https://aws.amazon.com/pt/free/?trk=0c09a3fd-f26f-4a26-8dcf-12a3016d392d&sc_channel=ps&s_kwcid=AL!4422!10!71605922711135!71606443844155&ef_id=303b2ef3aed21cf7ab604b0367b7095a:G:s |

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software.
- `release`: são usadas para preparar uma nova versão do software para lançamento. Elas permitem correções de bugs e ajustes finais antes da implantação.
- `hotfix`: versão para pequenas correções de erros.
- `dev`: versão de desenvolvimento do software.
- `feature`: uma branch para a criação de novas funcionalidades.

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação.
- `feature`: indica novas funcionalidades.
- `bug`: uma funcionalidade encontra-se com problemas.
- `enhancement`: uma funcionalidade precisa ser melhorada.
- `help wanted`: indica que a equipe precisa de ajuda para resolver o problema.
- `priority`: define a prioridade do item (por exemplo: alta, média, baixa).
- `duplicate`: quando um problema é duplicado, essa etiqueta é aplicada.
- `invalid`: para problemas que não são válidos ou não se aplicam.
- `wontfix`: indica que o problema não será corrigido.
- `question`: usada para perguntas ou dúvidas.

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

A ferramenta de configuração do projeto escolhida foi o Git, por ser a de conhecimento da equipe e a recomendada pela faculdade. A gerência das branchs foi realizada de acordo com o fluxo estabelecido pelo Git Flow, que mostra um trabalho claro para o desenvolvimento colaborativo, que garante que as mudanças sejam gerenciadas de forma eficiente. A gerência das Issues foi realizada buscando categorizar os problemas, tarefas e melhorias que o projeto de desenvolvimento venha a ter, ajudando a contextualizar e a entender o estado de cada item.
 

> **Links Úteis**:
> - [Microfundamento: Gerência de Configuração](https://pucminas.instructure.com/courses/87878/)
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

Exemplificação: A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. A equipe está organizada da seguinte maneira:
- Scrum Master: Ricardo Moreira;
- Product Owner: Silmara Eugênio;
- Equipe de Desenvolvimento: Janaina Marilda, Marcos Maciel, Leandro Henrique;
- Equipe de Design: Ian Merlo.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)
> - [Os papéis do Scrum e a verdade sobre cargos nessa técnica](https://www.atlassian.com/br/agile/scrum/roles)

### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo deverá fazer uso do recurso de gerenciamento de projeto oferecido pelo GitHub, que permite acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.

A implementação do método Scrum está sendo feita utilizando a ferramenta de gerenciamento de projeto Trello. Lá estão os cards que estamos trabalhando junto com as divisões de tarefas, status e o andamento do projeto.

Link do Trello: https://trello.com/b/8sILiOpm/grupo-1-turma-4-projeto-recome%C3%A7ar
 
> **Links Úteis**:
> - [Planejamento e Gestáo Ágil de Projetos](https://pucminas.instructure.com/courses/87878/pages/unidade-2-tema-2-utilizacao-de-ferramentas-para-controle-de-versoes-de-software)
> - [Sobre quadros de projeto](https://docs.github.com/pt/issues/organizing-your-work-with-project-boards/managing-project-boards/about-project-boards)
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

- Visual Studio
- Visual Studio Code
- Figma
- Google Meet

O Visual Studio e o Visual Studio Code foram escolhidos porque eles possuem uma integração com o sistema de versão. O Figma foi escolhido para criar os diagramas, pois será a ferramenta que melhor capta as necessidades da nossa solução. O google meet foi escolhido pela facilidade de uso.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
