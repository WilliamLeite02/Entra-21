
programa 
{ 
	funcao inicio () 
	{ 
		inteiro numero1, numero2, numero3, numero4
		real soma, div, total
		
		escreva("Digite nota 1: ")
		leia(numero1)
		escreva("Digite nota 2: ")
		leia(numero2)
		escreva("Digite nota 3: ")
		leia (numero3)
		escreva("Digite nota 4: ")
		leia(numero4)
		soma = numero1 + numero2 + numero3 +numero4
		div = soma / 4
		total = div

		limpa()
		escreva("media: ", total)

		
-------------------------------------------------------
		inteiro v1, v2, v3, total
		cadeia p1, p2, p3

		escreva("Nome do produto: ")
		leia(p1)
		escreva("Valor do produto: ")
		leia(v1)
		escreva("Nome do produto: ")
		leia(p2)
		escreva("Valor do produto: ")
		leia(v2)
		escreva("Nome do produto: ")
		leia(p3)
		escreva("Valor do produto: ")
		leia(v3)
		total = v1+ v2+ v3

		limpa()
		escreva("Produtos: ")
		escreva("\nProduto: ", p1," valor " ,v1)
		escreva("\nProduto: ", p2," valor " ,v2 )
		escreva("\nProduto: ", p3," valor " ,v3)
		escreva("\nTotal da compra: ",total)
		

/*----ativaidade1*/-------------------------------------------
		
		real valor1, valor2, soma
		escreva("Digite o primeiro número: ")
		leia(valor1)

		escreva("Digite o segundo número: ")
		leia(valor2)

		soma= valor1+valor2

		escreva("valor total dos numeros: ",soma)
	

/*----atividade2*/===========-----------------------

		
		real n1, n2, soma, sub, mult, div
		
		escreva("Digite o primeiro número: ")
		leia(n1)

		escreva("Digite o segundo número: ")
		leia(n2)

		soma = n1 + n2 
		sub  = n1 - n2 
		mult = n1 * n2 
		div  = n1 / n2 

		escreva("\nA soma dos números é igual a: ", soma) 	
		escreva("\nA subtração dos números é igual a: ", sub) 		
		escreva("\nA multiplicação dos números é igual a: ", mult) 	
		escreva("\nA divisão dos números é igual a: ", div, "\n")
		

/*----atividade 3*/-----------------------------------------

		
		inteiro anoatual, anonascimento, sub, idade, 
		ano= 2022

		escreva("Digite o ano atual: ")
		leia(anoatual)
		escreva("Digite o ano de nascença: ")
		leia(anonascimento)

		sub= ano - anonascimento
		idade=sub

		escreva("Idade atual: ",idade ," anos")
		

/*----atividade 4*/----------------------------------------

		
		real litros, km ,soma, distancia
		
		escreva("quantos KM por litro: ")
		leia(km)

		escreva("quantos quilometros serão percoridos: ")
		leia(distancia)

		litros =1.5
		soma= litros/km*distancia

		escreva("media de litros por km: ",soma)
		
	
/*----atividade 5*/-----------------------------------------

		
		cadeia nome
		real salario, vendas, comissao, salariofinal, quantidade

		escreva("nome do vendedor: ")
		leia(nome)
		escreva("salario: ")
		leia(salario)
		escreva("quantidade de vendas feitas no mes: ")
		leia(quantidade)

		vendas=100*quantidade
		comissao= 0.15 *vendas
		salariofinal= salario + comissao

		escreva("vendedor ",nome,"salario final do mes ",salariofinal)
		

/*----atividade 6*/-------------------------------

		
		real compra, vezes

		escreva("valor do produto: ")
		leia(compra)

		vezes=compra/5

		escreva("valor de parcelas, 5 de ",vezes," R$ cada")
		


/*----atividade7*/-------------------------------


		real ligacao, ligacao2, ligacao3, minutos, valor

		escreva("numero a ser discado: ")
		leia(ligacao)
		escreva("numero a ser discado: ")
		leia(ligacao2)
		escreva("numero a ser discado: ")
		leia(ligacao3)

		minutos=1.5
		ligacao=10*minutos
		ligacao2=6*minutos
		ligacao3=15*minutos

		valor= ligacao + ligacao2 + ligacao3

		escreva("valor da Fatura: ",valor)
		
		

		
	} 
}

