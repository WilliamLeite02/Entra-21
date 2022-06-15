import java.util.Scanner;
public class For{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        int[] numeros = new int[6];
        
        for(int i=0; i<6; i++){
            System.out.print("digite o numero:");
            numeros[i] = ler.nextInt();
            System.out.print("");
        }
    }
}