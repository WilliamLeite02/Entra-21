import java.util.Scanner;
public class Boletim{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        double n1,n2,n3,n4, media;
        
        System.out.println("digite nota 1:");
        n1=ler.nextDouble();
        System.out.println("digite nota 2:");
        n2=ler.nextDouble();
        System.out.println("digite nota 3:");
        n3=ler.nextDouble();
        System.out.println("digite nota 4:");
        n4=ler.nextDouble();
        
        media = (n1+n2+n3+n4)/4;
        
        System.out.println("media = "+media);
        
    }
}