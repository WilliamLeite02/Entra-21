import java.util.Scanner;
public class Empresa{
    public static void main(String args[]){
        Scanner input=new Scanner(System.in);
            String nomeEmpresa;
            double rendimentoEmpresa, despesasEmpresa, lucroAproximado;
        System.out.println("nome da empresa:");
        nomeEmpresa=input.nextLine();
        System.out.println("digite o valor de rendimento:");
        rendimentoEmpresa=input.nextDouble();
        System.out.println("digite o valor despesas:");
        despesasEmpresa=input.nextDouble();
            lucroAproximado =rendimentoEmpresa-despesasEmpresa;
        System.out.println("lucro final aproximado:"+lucroAproximado);
    }
}