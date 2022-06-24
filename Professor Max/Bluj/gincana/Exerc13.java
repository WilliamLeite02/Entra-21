
import java.util.Scanner;
public class Exerc13{
    public static void main (String args[]){
        Scanner leitor = new Scanner(System.in);
        
        String[] nDvd= new String [5];
        double[] preco = new double[5];
        int escolha = 0;
        int total = 0;
        System.out.println("1 homem de ferro");
        System.out.println("2 homem arranha");
        System.out.println("3 homem largato");
        System.out.println("4 homem dinosauro");
        System.out.println("5 homem papagaio");
        nDvd[0] = "homem ferro";
        preco[0] = 3.99;
        nDvd[1] = "homem arranha";
        preco[1] = 9.99;
        nDvd[2] = "homem largato";
        preco[2] = 8.99;
        nDvd[3] = "homem dinosauro";
        preco[3] = 6.99;
        nDvd[4] = "homem papagaio";
        preco[4] = 5.99;
        for(int i=4; i>0; i--){
            escolha = leitor.nextInt();
            total += preco[escolha];
            System.out.println(nDvd[escolha]);
            System.out.println(preco[escolha]);
            System.out.println(total);
        }
        
        }
        }
