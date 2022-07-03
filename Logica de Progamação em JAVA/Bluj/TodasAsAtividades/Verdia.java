import java.util.Scanner;
public class Verdia{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        Semana s1 = new Semana();
        
        System.out.println("digite de 1 a 7");
        s1.setDia(ler.nextInt());
        
        System.out.println(s1.verDia());
    }
}