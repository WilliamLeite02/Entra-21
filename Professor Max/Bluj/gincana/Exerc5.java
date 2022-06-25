import java.util.Scanner;
public class Exerc5 {
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        double n1;
        
        System.out.print("digite numero: ");
        n1=ler.nextDouble();
        
        if(n1%2==0){
            System.out.print("par");
        }else{
            System.out.print("impar");
        }
        
    }
}