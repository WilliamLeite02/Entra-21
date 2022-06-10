1. Um objeto se caracteriza por possuir: 
ATRIBUTOS=VARIAVEIS E METODOS=FUNÇÕES.

2. Um objeto é gerado sempre a partir de uma: 
CLASSE.

3. Uma classe é formada por: 
MODELO DE OBJETO,DEFINE ATRIBUTOS E METODOS.


4. Marque o tipo de dado mais adequado para os atributos abaixo, sendo i=int, b=byte, bo=boolean, d=double e S=string
a(B) Idade
b(D) Salário
c(S) E-mail
d(I) Dia de nascimento
e(S) Signo
f(B) Número de filhos
g(D) Peso em gramas
h(I) Peso em quilos
i(I) Comprimento em metros
j(B) Comprimento em centímetros
k(I) Quilometragem do veículo
l(D) Preço por litro
m(B) cep


5. Para que serve uma classe? 
A CLASSE SERVE PARA INSTANCIAR UM OBJETO DANDO FUNÇÕES E CARACTERISTICAS A ELE.

6. O que é um método? Quais os tipos de métodos? 
METODOS SÃO AS AÇÕES QUE IRAM SER EXERCIDAS= ANDAR,CORRER,LER


1.Considere que a=3, b=2 e c=8 e são todos valores inteiros. Resolva os testes lógicos que seguem.verdaeiro ou falso:
a.(a+b< c || b!=a && a>0) (TRUE)
b.(c <= a * a || c <= a*b || c<= a + b) (TRUE)
c.a<b && b<c && c<a (FALSE)
d.!a<b && !a<c && !c<a (FALSE)
e.(a!=b || b>c) &&b-a>0 (TRUE)


2.Considere que temos os seguintes valores: a=3, b=10 e c=7. Determine o resultado dos testes lógicos, verdadeiro ou falso:
a.b – a == c (TRUE)
b.c <= b (TRUE)
c.b <= a (FALSE)
d.b <= c (FAlSE)
e.b – a > a – c (TRUE) 


3.Responda.

a)O que é classe, objeto, atributos e métodos?
CLASSE É O LOCAL ONDE IREMOR CRIAR O OBJETO, OBJETO É USADO PARA ARMAZENAR DADOS,
ATRIBUTOS SÃO CARACTERISTICAS DO OBJETO E METODOS SÃO AS AÇÕES QUE ELE IRA EXECUTAR;

b)Quais são os modificadores que podem ser utilizados na criação de um código? Conceitue-os.
SET E GET = PUBLIC,PRIVATE;


c)Porque devemos utilizar a indentação?
PARA FACILITAR A LEITURA DO CODIGO, SENDO ASSIM MELHOR PARA CORREÇÕES FUTURAS;
TAMBEM É IMPORTANTE A ORGANIZAÇÃO DO CODIGO PARA A COMPREENÇÃO DE OUTRO PROGRAMADOR;


d)Cite dois exemplos da usabilidade do Math.
Math.sqrt, Math.cbrt;


e)O que significa instanciando um objeto? De um exemplo.
INSTANCIAR É CHAMAR O OBJETO DENTRO DA CLASSE CRIADA;

f)O que fazem os métodos get e set?
SET PARA GUARDAR A INFORMAÇÃO DE FORMA PRIVADA E GET PARA RETORNAR O RESULTADO; 


g)O que é um método Construtor?
O METODO CONTRUTOR É RESPONSAVEL POR DEFINIR OS PADRÕES INICIAIS DO OBJETO;
CONTRUIR O OBJETO NA MEMORIA.


h)O que caracteriza em um código condicionais encadeadas?
QUANDO O CODIGO TEM QUE ATENDER DETERMINADA CONDIÇÃO= VERDADEIRO OU FALSO 
BOOLEAN;


i)Em qual caso devemos utilizar o Swith?
É USADO IF E ELSE QUANDO QUEREMOS DAR MAIS DE UMA RESPOSTA PARA DETERMINADO TIPO DE CONDIÇÃO


j)Qual a função do While?
REPETIR ENQUANTO FOR NESCESÁRIO;


k)De quatro exemplos de métodos condicionais.
luzAcesa=true luzApagada=false, nota<6=reprovado nota>6=aprovado
IF roupa=limpa Print=pode sair. ELSE roupa=suja Print=nao vai sair.
IF dia>00 && <12 Print=manhã, ELSE IF tarde>13 && <18 Print=tarde, ElSE Print=noite


l)Para que serve o incremento?
FAZER SOMA OU AUMENTAR QUANTIDADE;


m)O que é compilação?
COMPILAÇÃO É A TRANSCRIÇÃO DO PROGRAMA PARA LINGUAGEM DE MAQUINA;


n)Qual a utilização do Scanner na classe principal?
O SCANNER É UTILIZADO PARA LER E ARMAZENAR DADOS;


o)Qual regra é utilizada para imprimirmos um resultado no vídeo?
PRINT + A VARIÁVEL;("NOME"+NOME);


p)O que são conversões de nomenclatura?
SAO FOMAS DE ESCREVER VARIÁVEIS,METODOS,CLASSE E ATRIBUTO DE FORMA QUE SEJA FÁCIL SE IDENTAR E ENTENDER 
O CODIGO; nomeDoFuncionario;idade;lataLixo;Pessoa;atenderChamado;


q)Para que servem as estruturas de controle?Cite três delas. 
IF ELSE, WHILE, FOR;


4.Representação
a)Crie um algoritmo qualquer.
Carro
String modelo;
String placa;
int portas;
acelerar();
freiar();


b)Represente uma classe com o nome Pessoa.
public class Pessoa{
  public static void main(String args[]){
	int idade;
	String nome;
	Pessoa pe1 = new Pessoa();
}
}


5.Com base no código da classe Aluno, logo a seguir, desenvolva a classe Main, de modo que o usuário do programa precise informar o nome e as três notas do aluno, e o programa após isso apresente a média deste aluno. Uso o exemplo da Unidade 6.2 como base.
import java.util.Scanner;
public class Aluno{
	public static void main(String args[]){
    public String nome;
    publicdouble nota1;
    publicdouble nota2;
    publicdouble nota3;
	Scanner ler = new Scanner(System.in);

    System.out.println("digite nome:");
    nome=ler.nextLine();
    System.out.println("digite nota1:");
    nota1=ler.nextDouble();
    System.out.println("digite nota2:");
    nota2=ler.nextDouble();
    System.out.println("digite nota3:");
    nota3=ler.nextDouble();
    
    public double calcularMedia(){
        return (this.nota1 + this.nota2 + this.nota3) / 3;

	System.out.print("media:"+calcularMedia);
    }
}
}