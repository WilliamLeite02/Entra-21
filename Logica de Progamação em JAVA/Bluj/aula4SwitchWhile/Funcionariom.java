import java.util.Scanner;
public class Funcionariom{
    public static void main (String args[]){
        Scanner input = new Scanner(System.in);
        Funcionario f1 = new Funcionario();
        
        f1.nome = "will";
        f1.salarioBase = 1200;
        
        f1.dobrarSalario();
        f1.descontarAdiantamento(300);
        double ferias = f1.calcularFerias();
        double horasExtras = f1.calcularHoraExtra(10);
        
        System.out.println("olá," + f1.nome + ",seu salario é: " + f1.salarioBase);
        System.out.println("o valor de suas ferias será: "+ ferias);
        System.out.println("o valor de suas horas extras é: "+ horasExtras);
    }
}