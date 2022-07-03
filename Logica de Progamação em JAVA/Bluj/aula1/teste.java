import java.util.Scanner;

public class teste {
    public static void main(String args[]){
    Scanner input = new Scanner(System.in);
    
    int x,y,z,w,b;

    
    System.out.print("Digite o primeiro numero:");
    x = input.nextInt();
    
    System.out.print("Digite o segundo numero:");
    y = input.nextInt();
    
    System.out.print("Digite o terceiro numero:");
    w = input.nextInt();
    
    System.out.print("Digite o quarto numero:");
    z = input.nextInt();
    
    System.out.print("Digite o quinto numero:");
    b = input.nextInt();
    
    int soma =x+y;
    int subt =x-y;
    double div =x/y;
    int mult =x*y;
    int media =(x+y+w+z)/4;
    int tudo =(x+y+w+z+b)/2*4;
    
    System.out.println("A soma é:" + soma);
    System.out.println("A subtração é:" + subt);
    System.out.println("A divisão é:" + div);
    System.out.println("A multiplicação é:" + mult);
    System.out.println("A media é:" + media);
    System.out.println("A tudo somado /2*4 é:" +tudo);
}
}