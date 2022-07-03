import java.util.Scanner;
public class Pessoamain{
    public static void main (String args[]){
        Scanner ler = new Scanner(System.in);
        Pessoa p1 = new Pessoa();
        
        System.out.print("digite o seu nome:");
        p1.nome=ler.nextLine();
        System.out.print("digite o seu ano de nascimento:");
        p1.anoDeNascimento=ler.nextInt();
        System.out.print("digite o numero de filhos:");
        p1.numeroDeFilhos=ler.nextByte();
        System.out.print("digite o seu salario:");
        p1.salario=ler.nextDouble();
        System.out.print("informe o ano atual:");
        int anoAtual =ler.nextInt();
        int idade = p1.calcularIdade(anoAtual);
        System.out.println("seu nome é "+p1.nome);
        System.out.println("voce nasceu no ano "+p1.anoDeNascimento);
        System.out.println("voce possui "+p1.numeroDeFilhos + " filhos(a)");
        System.out.println("seu salario é "+p1.salario);
        System.out.println("sua idade é "+idade + " anos");
        
    }
}
