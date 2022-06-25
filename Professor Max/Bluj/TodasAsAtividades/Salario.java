import java.util.Scanner;
public class Salario{
    public static void main(String args[]){
        Scanner input=new Scanner(System.in);
            String nomeVendedor;
            double salarioFixo, vendas, comissao, salarioLiquido;
            
        System.out.println("digite o nome do vendedor:");
        nomeVendedor=input.nextLine();
        System.out.println("digite o salario fixo do vendedor:");
        salarioFixo=input.nextDouble();
        System.out.println("digite o total de vendas:");
        vendas=input.nextDouble();
            comissao=(vendas*15)/100;
            salarioLiquido=comissao+salarioFixo;
        System.out.println("Nome do vendedor:"+nomeVendedor);
        System.out.println("salario fixo:"+salarioFixo+" reais");
        System.out.println("salario liquido:"+salarioLiquido+" reais");
        
    }
}