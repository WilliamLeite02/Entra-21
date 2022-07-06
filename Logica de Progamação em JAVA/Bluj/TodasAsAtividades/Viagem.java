import java.util.Scanner;
public class Viagem{
    public static void main(String args[]){
    float kml, litro, kmd, combustivel, preco, total;
    
    Scanner ler = new Scanner(System.in);
    
    System.out.println("digite a distancia a ser percorrida:");
    kmd=ler.nextFloat();
    System.out.println("Digite o quilometro por litro do carro:");
    kml=ler.nextFloat();
    System.out.println("digite o valor da gasolina:");
    litro=ler.nextFloat();
    
    combustivel= kmd/kml;
    preco=litro/kml;
    total=preco*kmd;
    
    System.out.println("quantidade de litros gastos="+combustivel);
    System.out.println("Valor da gasolina pro KM="+preco);
    System.out.println("Gasto total de gasolina="+total);
    
    }
}