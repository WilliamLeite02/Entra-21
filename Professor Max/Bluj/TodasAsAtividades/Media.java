import java.util.Scanner;
public class Media{
    public static void main(String args[]){
        Scanner input=new Scanner(System.in);
    String nomeEscola, nomeAluno;
    double n1,n2,n3,n4, mediaFinal;
        System.out.println("nome escola:");
        nomeEscola=input.next();
        System.out.println("nome aluno:");
        nomeAluno=input.nextLine();
        System.out.println("nota 1:");
        n1=input.nextDouble();
        System.out.println("nota 2:");
        n2=input.nextDouble();
        System.out.println("nota 3:");
        n3=input.nextDouble();
        System.out.println("nota 4:");
        n4=input.nextDouble();
            mediaFinal=n1+n2+n3+n4/4;
    System.out.print("aluno:"+nomeAluno+" media:"+mediaFinal);
   
    }
}