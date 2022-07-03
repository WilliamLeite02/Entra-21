import java.util.Scanner;
public class Exerc6 {
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        int n1,n2;
        
        System.out.println("digite um numero:");
        n1=ler.nextInt();
        System.out.println("digite um numero:");
        n2=ler.nextInt();
        
        if(n1>n2){
            System.out.println(n1+" e "+n2);
        }else{
            System.out.println(n2+" e "+n1);
        }
        
        
        
    }
}