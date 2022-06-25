import java.util.Scanner;
public class Matematica{
    public static void main (String args[]){
        Scanner input = new Scanner(System.in);
            int x,y,z,w,b;
        
        System.out.println("digite o primeiro numero:");
        x=input.nextInt();
            System.out.println("digite o segundo numero:");
            y=input.nextInt();
                System.out.println("digite o terceiro numero:");
                z=input.nextInt();
                    System.out.println("digite o quarto numero:");
                    w=input.nextInt();
                        System.out.println("digite o quinto numero:");
                        b=input.nextInt();
        int soma=x+y+z+w+b; int sub=x-y-z-w-b; double div=x/y/z/w/b;
        int mult=x*y*z*w*b; int media=soma/4; 
            System.out.println("Soma: "+soma);
                System.out.println("Subtração: "+sub);
                    System.out.println("Divisão: "+div);
                        System.out.println("Multiplicação: "+mult);
                            System.out.println("Media: "+media);
        
    }
}