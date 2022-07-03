import java.util.Scanner;
public class TreinoMain{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        Treino t1 = new Treino();
        
        System.out.print("informe o nome do atleta:");
        t1.setNome(ler.nextLine());
        
        for (int i=0; i<10; i++){
            System.out.print("informe a marca " + i + ": ");
            t1.armazenarMarca(i, ler.nextDouble());
        }
        
        System.out.print(t1);
        double media= t1.calcularMediaDeMarcas();
        double maior = t1.obterMaiorMarca();
        
        System.out.println("media de marcas: " + media);
        System.out.println("maior marca: " + maior);
      
    }
}