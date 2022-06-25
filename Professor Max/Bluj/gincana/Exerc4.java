import java.util.Scanner;
public class Exerc4 {
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        int valor;
        
        System.out.println("digite um numero de 0 a 100");
        valor=ler.nextInt();
        
        if(valor>20){
            System.out.print("ganhador");
        }else if(valor==20){
            System.out.print("empate");
        }else{
            System.out.print("perdeu");
        }
        
       
        
    }
}