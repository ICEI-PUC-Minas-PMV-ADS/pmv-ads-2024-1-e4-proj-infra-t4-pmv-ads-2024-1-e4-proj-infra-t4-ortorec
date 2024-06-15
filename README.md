# Produtos Ortopédicos - Recomeçar

`Tecnologia em Análise e Desenvolvimento de Sistemas`

`Desenvolvimento de uma Aplicação Distribuída `

`EIXO 4`

O Projeto “Recomeçar” é uma ideia criada para facilitar e incentivar o acesso de equipamentos ortopédicos para a população através de um software moderno e eficiente. Com o software sendo criado para desktops e dispositivos mobile, promovemos o acesso a várias pessoas com bastante intuição. O software permite com que os usuários se cadastrem, façam login na aplicação e realizem a compra e consulta de produtos ortopédicos disponíveis em estoque, gerenciado por administradores que são responsáveis pelos produtos.

## Integrantes

* Ian Merlo Corrêa
* Janaína Pinheiro Leal do Couto
* Leandro Henrique de Oliveira Reis
* Marcos Paulo Assiz Maciel
* Ricardo Moreira Siqueira Junior
* Silmara Eugênia Barbosa

## Orientador

* Pedro Alves de Oliveira

## Instruções de utilização

### Aplicação Mobile

O projeto mobile foi feito na versão 20.14 do node, para evitar erros é recomendado utilizar a mesma versão. Para verificar a versão instalada no seu computador abra o ``cmd`` ou o ``terminal`` de seu computador e digite: ``node -v``, este comando trará versão presente em sua máquina. Caso a versão do node seja anterior ou ele não tenha sido instalado, você pode baixar por este site: https://nodejs.org/en/download/prebuilt-installer.

Primeiro é preciso clonar o repositório do projeto. 

Para rodar de fato a aplicação mobile, será necessário instalar algumas bibliotecas, coloque os códigos no seu terminal do vscode no ambiente do projeto localizado em recomecar-mobile -> Recomecar:

```npm install```

```npm install expo-cli --global```

```npm install nativewind```

```npm install --save-dev tailwindcss@3.3.2```

```npm install node-appwrite@13.0.0```

```npm install appwrite@15.0.0```

```npm install react-native-animatable```

``npm install react-native-appwrite@0.4.0``

Agora você vai precisar rodar o tailwind para que ele crie um arquivo chamado tailwind.config.js, coloque este código no terminal: 

```npx tailwindcss init```

Depois de ser gerado, copie o código abaixo e substitua toda a página do arquivo criado: 
````
/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./app/**/*.{js,jsx,ts,tsx}", "./components/**/*.{js,jsx,ts,tsx}"],
  theme: {
    extend: {
      colors: {
        primary: "#161622",
        secondary: {
          DEFAULT: "#fb00ff",
          100: "#9C1BE0",
          200: "#861BE0",
        },
        black: {
          DEFAULT: "#000",
          100: "#1E1E2D",
          200: "#232533",
        },
        gray: {
          100: "#CDCDE0",
        },
      },
      fontFamily: {
        pthin: ["Poppins-Thin", "sans-serif"],
        pextralight: ["Poppins-ExtraLight", "sans-serif"],
        plight: ["Poppins-Light", "sans-serif"],
        pregular: ["Poppins-Regular", "sans-serif"],
        pmedium: ["Poppins-Medium", "sans-serif"],
        psemibold: ["Poppins-SemiBold", "sans-serif"],
        pbold: ["Poppins-Bold", "sans-serif"],
        pextrabold: ["Poppins-ExtraBold", "sans-serif"],
        pblack: ["Poppins-Black", "sans-serif"],
      },
    },
  },
  plugins: [],
};
````
Essas são algumas configurações que padronizam a estilização do app. Depois disso, vá no arquivo "babel.config.js" e coloque embaixo de presets:

`plugins: ["nativewind/babel"]`

Isso vair referenciar a biblioteca do nativewind para as edições. Mas para garantir o funcionamento dela crie um arquivo chamado "app.d.ts", ele deve permanecer fora das pastas, e dentro dele coloque:

`/// <reference types="nativewind/types" />`

Depois vá no seu terminal do visual studio code e coloque:

`npm expo start -c`

Com este comando ele vai limpar o cache antes de rodar o expo. Assim o app estará com todas suas depêndencias e estará pronto para ser executado.

# Documentação

<ol>
<li><a href="docs/01-Documentação de Contexto.md"> Documentação de Contexto</a></li>
<li><a href="docs/02-Especificação do Projeto.md"> Especificação do Projeto</a></li>
<li><a href="docs/03-Metodologia.md"> Metodologia</a></li>
<li><a href="docs/04-Projeto de Interface.md"> Projeto de Interface</a></li>
<li><a href="docs/05-Arquitetura da Solução.md"> Arquitetura da Solução</a></li>
<li><a href="docs/06-Template Padrão da Aplicação.md"> Template Padrão da Aplicação</a></li>
<li><a href="docs/07-Programação de Funcionalidades.md"> Programação de Funcionalidades</a></li>
<li><a href="docs/08-Plano de Testes de Software.md"> Plano de Testes de Software</a></li>
<li><a href="docs/09-Registro de Testes de Software.md"> Registro de Testes de Software</a></li>
<li><a href="docs/10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a></li>
<li><a href="docs/11-Registro de Testes de Usabilidade.md"> Registro de Testes de Usabilidade</a></li>
<li><a href="docs/12-Apresentação do Projeto.md"> Apresentação do Projeto</a></li>
<li><a href="docs/13-Referências.md"> Referências</a></li>
</ol>

# Código

<li><a href="src/README.md"> Código Fonte</a></li>

# Apresentação

<li><a href="presentation/README.md"> Apresentação da solução</a></li>
