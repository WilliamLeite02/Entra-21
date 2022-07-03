//tarefa fazer um calculo nomeFuncionario, salarioBase, inss, valeRefeicao, insalubridade,
//vendas,salarioLiquido,    salarioLiquido=salarioBase+vendas+insalubridade-inss-valeRefeicao
//descontos 9% inss  6%valerefeiçao 0,09/0,06/0,22/0,05
//lucros 22%insalubridade, 5%vendas
import java.util.Scanner;
public class Tarrefa{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        
        String nomeFuncionario;
        double salarioBase, inss, valeRefeicao, insalubridade, vendas, salarioLiquido, comissao;
        
        System.out.println("nome funcionario:");
        nomeFuncionario=ler.nextLine();
        System.out.println("salario base:");
        salarioBase=ler.nextDouble();
        System.out.println("total de vendas do funcionário:");
        vendas=ler.nextDouble();
           
        inss=0.09*salarioBase;
        valeRefeicao=0.06*salarioBase;
        insalubridade=0.22*salarioBase;
        comissao=0.05*vendas;
        
        salarioLiquido= salarioBase+insalubridade+comissao-inss-valeRefeicao;
        
        System.out.print("Salario liquido do Funcionario "+nomeFuncionario+" "+salarioLiquido);
        
        
        
        
    
    }
}