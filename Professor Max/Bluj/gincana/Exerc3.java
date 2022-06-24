import java.util.Scanner;
public class Exerc3 {
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        double salario, acrecimo, menos, total;
        
        System.out.println("digite salario:");
        salario=ler.nextDouble();
        
        acrecimo= (salario*15)/100;
        menos=(salario*9)/100;
        total=salario+acrecimo-menos;
        
        System.out.println("salario mais 15%:" + acrecimo);
        System.out.println("salario menos 9%:" + menos);
        System.out.println("salario com final:" + total);
    }
}