import java.util.Scanner;
public class exec2{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        
        int a;
        int b;
        int c;
        
        System.out.println("digite o numero:");
        a=ler.nextInt();
        System.out.println("digite o numero:");
        b=ler.nextInt();
        System.out.println("digite o numero:");
        c=ler.nextInt();
        
        int soma= a+b+c;
        
        System.out.println("soma: "+soma);
        
        
    }
}