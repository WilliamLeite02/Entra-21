import java.util.Scanner;
public class Exerc12{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        int valor;
        
        System.out.print("digite um valor:");
        valor=ler.nextInt();
        
        int nota2=valor/2;
        int nota5=valor/5;
        int nota10=valor/10;
        int nota20=valor/20;
        int nota50=valor/50;
        
        System.out.println("notas de 2: "+nota2);
        System.out.println("notas de 5: "+nota5);
        System.out.println("notas de 10: "+nota10);
        System.out.println("notas de 20: "+nota20);
        System.out.println("notas de 50:" +nota50);
        
    }
}
//digitar um valor e ele separar em notas 