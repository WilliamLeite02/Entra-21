import java.util.Scanner;
public class Mtabuada{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        
        Tabuada t1 = new Tabuada();
        
        System.out.print("informe um numero inteiro para ver a tabuada");
        t1.setValor(ler.nextInt());
        
        for(int multiplicador=1; multiplicador <=10; multiplicador++){
            System.out.println(t1.gerarTabuada(multiplicador));
        }

}
}
