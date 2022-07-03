import java.util.Scanner;

public class Media{
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);
        
        String nomeEscola;
        String nomeAluno;
        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double mediaFinal;
        
        System.out.print("Nome Escola:");
        nomeEscola=input.nextLine();
        
        System.out.print("Nome do Aluno:");
        nomeAluno=input.nextLine();
        
        System.out.print("Nota 1:");
        nota1=input.nextDouble();
        
        System.out.print("Nota 2:");
        nota2=input.nextDouble();
        
        System.out.print("Nota 3:");
        nota3=input.nextDouble();
        
        System.out.print("Nota 4:");
        nota4=input.nextDouble();
        
        mediaFinal=(nota1+nota2+nota3+nota4)/4;
        
        System.out.println("A média do aluno:"+nomeAluno+" na escola:"+nomeEscola+ " é "+mediaFinal);
        
        
    }
}