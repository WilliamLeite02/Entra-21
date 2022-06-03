import java.util.Scanner;
//crie um código que imprima o nome de uma empresa e que calcule os rendimentos basicos da empresa
// diminuindo os gastos da empresa resultando em um lucro aproximado.
public class Empresa_exercio{   
    public static void main(String args[]){
        Scanner input=new Scanner(System.in);
        
    String nomeEmpresa;
    double rendimentoEmpresa;
    double despesasEmpresa;
    double lucroAproximado;
    
    System.out.print("Nome da Empresa:");
    nomeEmpresa=input.nextLine();
    
    System.out.print("Digite o valor de rendimento:");
    rendimentoEmpresa=input.nextDouble();
    
    System.out.print("Digite o valor de despesas:");
    despesasEmpresa=input.nextDouble();
    
    lucroAproximado= rendimentoEmpresa-despesasEmpresa;
    
    System.out.println("Lucro final aproximado:"+lucroAproximado);
    
    
    
    }
}