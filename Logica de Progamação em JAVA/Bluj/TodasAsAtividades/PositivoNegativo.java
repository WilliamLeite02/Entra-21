import java.util.Scanner;
public class PositivoNegativo{
    public static void main(String args[]){
        Scanner ler=new Scanner(System.in);
        Numero n1=new Numero();
        
        System.out.print("digite o numero:");
        n1.setNumero(ler.nextInt());
        
        String resultado = n1.verificarNumero();
        
        System.out.println(resultado);
        System.out.println(n1.verificarNumero());
        
    }
}