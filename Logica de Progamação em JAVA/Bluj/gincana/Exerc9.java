import java.util.Scanner;
public class Exerc9{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        double valor,real,euro,iene;
        
        System.out.println("digite o valor a ser convertido:");
        valor=ler.nextDouble();
        
        real=valor*5.17;
        euro=valor*0.94;
        iene=valor*136.2;
        
        
        System.out.println("valor em real:"+real);
        System.out.println("valor em euro:"+euro);
        System.out.println("valor em iene:"+iene);
    
    
    
    }
   
}