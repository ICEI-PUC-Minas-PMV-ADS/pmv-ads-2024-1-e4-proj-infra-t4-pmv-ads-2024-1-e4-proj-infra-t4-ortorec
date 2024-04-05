# Arquitetura da Solução

![image](https://github.com/sil-barbosa/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106809153/6bcbd85b-a330-4d31-a957-cef3ec9693c3)

#### **Legenda:** 
Camada de API Gateway: ícones azuis \
Camada de Cache: ícone amarelo \
Camada de Segurança: ícone verde \
Camada de Serviços: ícones laranja \
Camada de Banco de dados: ícones cinza

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
### API-Recomecar-Login
![Criação do Banco de Dados 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/54b16136-6312-4462-8a52-300e64679152)
![Criação do Banco de Dados 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e4-proj-infra-t4-pmv-ads-2024-1-e4-proj-infra-t4-ortorec/assets/106103247/12fb28c6-045d-4a97-bdcc-cbc9e5eb0b5c)



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
