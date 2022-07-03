import java.util.Scanner;
public class Calcular2{
    public static void main (String args[]){
        int a=3;
        int b=10;
        int c=7;
        boolean r1,r2,r3,r4,r5;
        Scanner ler = new Scanner(System.in);
        
        r1=(b-a==c);
        r2=(c<=b);
        r3=(b<=a);
        r4=(b<=c);
        r5=(b-a>a-c);
        
        System.out.println("a "+r1+" b "+r2+ " c "+r3+" d "+r4+" e "+r5);
        
        
    
    }
}