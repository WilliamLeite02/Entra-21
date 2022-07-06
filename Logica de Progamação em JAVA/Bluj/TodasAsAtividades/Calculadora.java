import java.util.Scanner;
public class Calculadora{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        int n1, n2;
        
        System.out.println("digite o primeiro numero:");
        n1= ler.nextInt();
        System.out.println("digite o segundo numero:");
        n2= ler.nextInt();
        
        double soma = n1+n2;
        double sub = n1-n2;
        double div = n1/n2;
        double mult = n1*n2;
        
        System.out.println("soma = "+soma);
        System.out.println("subtração = "+sub);
        System.out.println("divisao = "+div);
        System.out.println("multiplicação = "+mult);
        
    }
}

