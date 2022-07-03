import java.util.Scanner;
public class Semanamain{
    public static void main (String args[]){
        Scanner input = new Scanner(System.in);
        Semana sem = new Semana();
        
        System.out.println("digite o numero da semana: ");
        sem.setDia(input.nextInt());
        
        System.out.println("RESPOSTA:");
        String dia = sem.verDiaDaSemana();
        System.out.println(dia);
        
    }
}