
Funcionalidade: REQ001RegistrarUsuario
	Como uma usuário anônimo
	Eu quero poder me cadastrar no sistema

Cenário: REQ001 Cadastrar um usuário com sucesso
Dada a abertura da página "/Account/Register"
	E preencher o campo texto "Email" com o valor "cristian.mathias@gmail.com"
	E preencher o campo texto "Password" com o valor "123Mud@r"
	E preencher o campo texto "ConfirmPassword" com o valor "123Mud@r"
Quando clicar no botão "Register"
Então deve exibir uma página contendo o texto "Hello cristian.mathias@gmail.com!"

Cenário: REQ001 Não permitir o cadastro de um usuário já cadastrado
Dada a abertura da página "/Account/Register"
	E preencher o campo texto "Email" com o valor "cristian.mathias@gmail.com"
	E preencher o campo texto "Password" com o valor "123Mud@r"
	E preencher o campo texto "ConfirmPassword" com o valor "123Mud@r"
Quando clicar no botão "Register"
Então deve exibir uma página contendo o texto "Name cristian.mathias@gmail.com is already taken"

