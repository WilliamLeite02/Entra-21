public class JogoMain{


public static void main (String []args) throws InterruptedException {		
		
		System.out.println("\t\t\tJogo do 21!\t\t\t\n\n");
		Thread.sleep(1500);
		System.out.println("Regras: Vamos aleatorizar 3 valores entre 0 e 10."
				+ "\nA soma dos valores de cada jogador deve corresponder a 21, estourou PERDEU.\nCaso nínguem alcance o valor, o mais proximo vence.\n ");		
		Thread.sleep(3000);
		System.out.println("Insira o nome do jogador um:");
		jogadorUm=leitor.next();		
		System.out.println("\nInsira o nome do jogador dois:");
		jogadorDois=leitor.next();
		System.out.println("\n");
		
		acao();
	}

}