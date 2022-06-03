import java.util.Scanner;

public class salario {
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);
        
        String nomeVendedor;
        double salarioFixo;
        double vendas;
        double comissao;
        double salarioLiquido;    //fixo mais comissao
        
        System.out.print("Digite o nome do vendedor:");
        nomeVendedor=input.nextLine();
        
        System.out.print("Digite o salário fixo do vendedor:");
        salarioFixo=input.nextDouble();
        
        System.out.print("Digite o total de vendas efetuadas pelo vendedor:");
        vendas=input.nextDouble();
        
        comissao=(vendas*15)/100;
        salarioLiquido=comissao+salarioFixo;
        
        System.out.println("Nome do vendedor:" +nomeVendedor);
        System.out.println("Salario fixo:" +salarioFixo+ " reais");
        System.out.println("Salario liquido:" +salarioLiquido+ " reais");
        
        
        
        
    }
}