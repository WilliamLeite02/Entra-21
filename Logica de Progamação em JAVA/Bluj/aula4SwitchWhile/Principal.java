import java.util.Scanner;
public class Principal{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        
        int numero;
        
        do{
            System.out.println("Informe um numero positivo:");
            numero=ler.nextInt();
            if(numero<0){
                System.out.println("apenas numeros positivos");
            }
        }while(numero<0);
        
        While n1 = new While(numero);
        int escolha;
        
        do{
            System.out.println("1 - visualizar o numero digitado");
            System.out.println("2 - alterar o numero");
            System.out.println("3 - visualizar fatorial do numero");
            System.out.println("4 - visualizar somatorio do numero");
            System.out.println("5 - visualizar quantidade de multiplos do numero");
            System.out.println("6 - ver se o numero e primo");
            System.out.println("0 - sair");
            System.out.println("->");
            escolha=ler.nextInt();
            switch(escolha){
                case 1:
                    System.out.println("numero digitado "+ n1.getValor());
                    break;
                case 2:
                    int novoNumero;
                    do{
                        System.out.println("informe o novo numero:");
                        novoNumero = ler.nextInt();
                        if(novoNumero<0){
                            System.out.println("digite apenas numeros positivos");
                        }
                    }while(novoNumero<0);
                    n1.setValor(novoNumero);
                    System.out.println("numero alterado com sucesso");
                    break;
                case 3: 
                    int fatorial = n1.calcularFatorial();
                    System.out.println("o fatorial de "+n1.getValor()+" é "+fatorial);
                    break;
                case 4:
                    int somatorio = n1.calcularSomatorio();
                    System.out.println("o somatorio de "+n1.getValor()+" é "+somatorio);
                    break;
                case 5:
                    int quantidade = n1.contarMultiplos();
                    System.out.println("a quantidade de multiplos: "+quantidade);
                    break;
                case 6:
                    System.out.println("o numero " +n1.verificarSeEPrimo());
                    break;
                case 0:
                    System.out.println("sistema encerrado!");
                    break;
                default:
                    System.out.println("opçao invalida");
                }
            }while(escolha!=0);
        }
    }