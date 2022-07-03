import java.util.Scanner;
public class Exerc11{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        double valor,celcius, fireheingth,kelvin;
        
        System.out.println("digite o valor a ser convertido:");
        valor=ler.nextDouble();
        
        fireheingth=(valor*9)/5+32;
        kelvin=valor+273;
        
        System.out.print("celcius "+valor+ " fireheingth "+fireheingth+" kelvin "+kelvin);
        
}
}