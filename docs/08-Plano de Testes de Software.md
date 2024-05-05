# Plano de Testes de Software

| Plano de Testes | Nome do Plano de Testes |
| --------------- | ----------------------- |
| PT - 01 | Teste do Sistema de Registro |
| PT - 02 | Teste do Sistema de Login |
| PT - 03 | Teste de Recuperação de Senha |
| PT - 04 | Teste do Sistema de Autenticação |
| PT - 05 | Teste do Sistema de Compras |
| PT - 06 | Teste de Pesquisa de Produtos |
| PT - 07 | Teste de Serviços de Manutenção |

# Explicando os Testes
## PT - 01 Teste do Sistema de Registro

### Requisito Funcional: 

RF001 - O sistema deve permitir o cadastro, alteração e cancelamento de perfil do usuário

### Objetivos:
Verificar se o usuário consegue se registrar com detalhes válidos.

### Procedimento:
	1 - Acessar a página de registro
	2 - Preencher os detalhes do usuário: os campos de nome, email, etc.
	3 - Submeter o formulário.
	4 - Receber a confirmação de registro.

### Êxito: 
O usuário consegue registrar no site com sucesso e suas credenciais aparecem no banco de dados.

## PT - 02 Teste do Sistema de Login

### Requisito Funcional:
 
RF001 - O sistema deve permitir o cadastro, alteração e cancelamento de perfil do usuário

### Objetivos:
Verificar se o usuário consegue fazer login com credenciais válidas.

### Procedimento:
	1 - Acessar a página de login.
	2 - Preencher as credenciais do usuário.
	3 - Submeter o formulário de login.
	4 - Entrar na conta registrada.

### Êxito:
O usuário consegue entrar na sua conta e visualizar suas informações.

## PT - 03 Teste de Recuperação

### Requisito Funcional: 

RF002 - O sistema deve permitir ao usuário criar, alterar e recuperar sua senha.

### Objetivos:
Verificar se a opção de redefinição de senha está funcionando corretamente.

### Procedimento:
	1 - Acessar a página de login.
	2 - Clicar no link esqueceu a senha.
	3 - Preencher o endereço de e-mail.
	4 - Submeter o pedido de recuperação de senha.
	5 - Verificar o e-mail de recuperação de senha.
	6 - Clicar no link de recuperação de senha.
	7 - Redefinir a senha
	8 - Verificar a confirmação de redefinição de senha.
	9 - Fazer login com a senha nova.
	
### Êxito:
O usuário consegue recuperar sua senha com sucesso e entra em sua conta.

## PT - 04 Teste do Sistema de Autenticação

### Requisito Funcional: 

RF001 - O sistema deve permitir o cadastro, alteração e cancelamento de perfil do usuário

### Objetivos: 
Verificar se a validação de erro é exibida para credenciais inválidas.

### Procedimento:
	1 - Acessar a página de Login
	2 - Inserir credenciais inválidas

### Êxito:
O sistema impede o usuário de entrar com credenciais inválidas.

## PT - 05 Teste do Sistema de Compras

### Requisito Funcional: 

RF008 - O sistema deve ter integração com meios de pagamento online e offline (cartões de crédito, débito, boleto bancário, pix).

### Objetivos: 
1 - Verificar se o usuário consegue adicionar produtos ao carrinho.

2 - Verificar se o usuário consegue remover produtos do carrinho.

3 - Verificar se o usuário consegue alterar a quantidade de produtos no carrinho.

### Procedimento:
#### 1
1 - Acessar a Loja.
2 - Clicar em um produto.
3 - Clicar no botão “Adicionar ao carrinho”
4 - Verificar se o produto foi adicionado ao carrinho.

#### 2
1 - Acessar o Carrinho
2 - Clicar no botão “Remover Produto”

#### 3
1 - Acessar o Carrinho
2 - Alterar a quantidade do produto

### Êxito:
	1 - O usuário consegue adicionar itens ao carrinho com sucesso.

	2 - O usuário é capaz de remover os produtos adicionados.

	3 - O usuário é capaz de alterar a quantidade de produtos no carrinho.

4 - O sistema verifica se há campos faltantes ou incorretos no formulário de pagamento.

## PT - 06 Teste de Pesquisa de Produtos

### Requisito Funcional: 

RF005 - O sistema deve possibilitar a busca de um produto específico.

### Objetivos:
1 - Verificar se a pesquisa retorna os resultados corretos com base na consulta de pesquisa.

2 - Verificar se a pesquisa retorna uma mensagem apropriada quando não há resultados.

3 - Verificar se as categorias de pesquisa estão funcionando corretamente.

### Procedimento:
#### 1
1 - Clicar na barra de pesquisa.
2 - Escrever o nome de um produto e apertar o botão “Enter”

#### 2
1 - Clicar na barra de pesquisa.
2 - Pesquisar por um produto não registrado.

#### 3
1 - Clicar nas categorias.
2 - Escolher uma categoria de produtos.

### Êxito:
	1 - O usuário recebe os resultados de sua pesquisa com sucesso.
	2 - O sistema envia uma mensagem de que os produtos pesquisados não	       	 
 foram encontrados
	3 - A pesquisa por categorias mostra os produtos filtrados com sucesso.

## PT - 07 Teste de Serviços de Manutenção
	
### Requisito Funcional: 

RF011 - O sistema deve oferecer ao usuário opções de agendamento (data) para execução de manutenção de equipamentos/

### Objetivos:
1 - Verificar se o usuário consegue solicitar serviços de manutenção.
2 - Verificar se o usuário consegue cancelar solicitações de serviços de                                                                              manutenção.

### Procedimento:
#### 1
1 - Acessar a página de Serviços de Manutenção.
2 - Selecionar o serviço de manutenção.
3 - Preencher os detalhes do serviço de manutenção
4 - Submeter o pedido de serviço de manutenção.
5 - Verificar a confirmação do pedido de manutenção

#### 2 
1 - Acessar a página de Serviços Solicitados
2 - Clicar no botão "Cancelar Serviço"

### Êxito:
	1 - O usuário consegue solicitar um serviço com sucesso.
	2 - O usuário cancela a solicitação de serviços com sucesso.

