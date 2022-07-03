import java.util.Scanner;
public class JogoMain{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        byte escolha;
        do{
            System.out.println("1-jogar");
            System.out.println("0-sair");
            escolha = ler.nextByte();
            
            switch(escolha){
                case 1:
                    System.out.println("Escolha sua jogada!");
                    System.out.println("(1)pedra");
                    System.out.println("(2)papel");
                    System.out.println("(3)tesoura");
                    System.out.println("(4)Cachorro");
                    byte jogadaUsuario = ler.nextByte();
                    Jogo j1 = new Jogo(jogadaUsuario);
                    System.out.println(j1);
                    System.out.println("Resultado:" + j1.verificarVencedor());
                    break;
                case 0:
                    System.out.println("jogo encerrado");
            }
        }while(escolha!=0);
}
}