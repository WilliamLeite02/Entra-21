import java.util.Scanner;
public class Verificar{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        Numero n1 = new Numero();
        
        System.out.println("digite um numero:");
        n1.setValor(ler.nextInt());
        
        System.out.println(n1.verificarNumero());
    }
}
