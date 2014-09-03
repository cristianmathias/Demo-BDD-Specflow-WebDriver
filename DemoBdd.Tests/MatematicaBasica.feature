Funcionalidade: Matemática Básica
	A fim de evitar erros
	Como um péssimo matemático
	Eu quero que me digam a soma de dois números


Cenário: Exemplo 1 - Somar dois número
	Dado que o número 50 seja o valor do primeiro operando da calculadora
		E que o número 70 seja o valor do segundo operando da calculadora
	Quando eu pressionar "somar"
	Então o resultado deve ser igual ao 120


Esquema do Cenário: Exemplo 2 - Somar dois número
	Dado que o número <valor1> seja o valor do primeiro operando da calculadora
		E que o número <valor2> seja o valor do segundo operando da calculadora
	Quando eu pressionar <operacao>
	Então o resultado deve ser igual ao <resultadoEsperado>

	Exemplos: 
		| valor1 | operacao | valor2 | resultadoEsperado |
		| 50     | "somar"  | 70     | 120               |
		| 30     | "somar"  | 50     | 80                |


