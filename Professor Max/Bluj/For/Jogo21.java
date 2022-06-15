
import java.util.;
public class Jogo21 {	
	static Scanner leitor = new Scanner (System.in);
	
	static String jogadorUm;
	static String jogadorDois;
	static int j1[]=new int[3];		
	static int j2[]=new int[3];
	static int somaj1=0;
	static int somaj2=0;
	
	static void acao() throws InterruptedException {		
		Random random = new Random ();
		
		int r1=0;
		int r2=0;
		
		System.out.println("Sorteio dos números iniciado...\n");
		Thread.sleep(1500);
		
		System.out.println("Primeiramente vamos sortear os números do "+jogadorUm+".\n");
		Thread.sleep(1500);
		
		j1[0]=random.nextInt(11);
		System.out.println("O primeiro número sorteado foi: "+j1[0]+".\nDeseja outro número?\n1. Sim\n2. Não");
		r1=leitor.nextInt();
		
		if (r1==1) {
			int r1_1=0;
			j1[1]=random.nextInt(11);
			Thread.sleep(1500);
			System.out.println("\nO segundo número sorteado foi: "+j1[1]+".\nDeseja outro número?\n1. Sim\n2. Não");
			r1_1=leitor.nextInt();	
			
			if (r1_1==1) {
				Thread.sleep(1500);
				j1[2]=random.nextInt(11);
				System.out.println("\nO segundo número sorteado foi: "+j1[2]+".\nSorteio Encerrado!");
				
				for (int i=0; i<j1.length; i++) {			
					somaj1=somaj1+j1[i];
				}				
				}
			
			else {
				Thread.sleep(1500);
				for (int i=0; i<j1.length; i++) {			
					somaj1=somaj1+j1[i];
				}
			}
			}
		else {
			Thread.sleep(1500);
			for (int i=0; i<j1.length; i++) {			
				somaj1=somaj1+j1[i];
			}
		}
		
		System.out.println("\n\nAgora, vamos ao sorteio do "+jogadorDois+":");
		Thread.sleep(1500);
		
		j2[0]=random.nextInt(11);
		System.out.println("\nO primeiro número sorteado foi: "+j2[0]+".\nDeseja outro número?\n1. Sim\n2. Não");
		r2=leitor.nextInt();
		
		if (r2==1) {
			Thread.sleep(1500);
			int r2_1=0;
			j2[1]=random.nextInt(11);
			System.out.println("\nO segundo número sorteado foi: "+j2[1]+".\nDeseja outro número?\n1. Sim\n2. Não");
			r2_1=leitor.nextInt();	
			
			if (r2_1==1) {
				Thread.sleep(1500);
				j2[2]=random.nextInt(11);
				System.out.println("\nO segundo número sorteado foi: "+j2[2]+".\nSorteio Encerrado!\n\n");
				for (int i=0; i<j2.length; i++) {			
					somaj2=somaj2+j2[i];
				}
				condicoes();
			}
			
			else {
				Thread.sleep(1500);
				for (int i=0; i<j2.length; i++) {			
					somaj2=somaj2+j2[i];
				}
				condicoes();
			}
		}		
		else {
			Thread.sleep(1500);
			for (int i=0; i<j2.length; i++) {			
				somaj2=somaj2+j2[i];
			}
			condicoes();
		}
		
	}
	static void condicoes() throws InterruptedException {
		
		if (somaj1<=21 & somaj1<=21 & somaj1==somaj2) {			
			System.out.println("Vocês tem noção da probabilidade disso acontecer?\nVocês empataram, o(a) "+jogadorUm+" fez "+somaj1+"e o(a) "+jogadorDois+
					" fez "+somaj2+" vamos rodar de novo e ver quem vence!");
			acao();		
		}
		
		if (somaj1>21 & somaj2>21) {			
			System.out.println("Vocês dois estouraram, rodada empatada.\n\nVamos mais uma vez!");
			acao();			
		}		
		
		if (somaj1>21 & somaj2<21) {
			System.out.println("Viiiiiiish, estorou em brother, "+jogadorUm+"?");
			System.out.println("\n"+jogadorDois+" é vencedor dessa rodada!!!");
			System.out.println("\n\tVam BORA "+jogadorDois+"!!");
		}
		
		if (somaj2>21 & somaj1<21) {
			System.out.println("\nViiiiiiish, estorou em, "+jogadorDois+"?!");
			System.out.println("Você tirou: "+somaj2+".");
			System.out.println("\n"+jogadorUm+" é vencedor dessa rodada!!!\nVocê tirou: "+somaj1+".");
			System.out.println("\n\tVam BORA "+jogadorUm+"!!");
		}
		
		if (somaj1<21 & somaj2<21) {
			
			if (somaj1>somaj2) {				
				System.out.println("Foi duro em, o "+jogadorDois+" fez "+somaj2+" e acabou perdendo...");
				System.out.println("Enquanto...");
				Thread.sleep(1500);
				System.out.println("O "+jogadorUm+" fez "+somaj1+" e é o grande vencedor dessa rodada!!!");
				System.out.println("\n\tVam BORA "+jogadorUm+"!!");				
			}
			
			else {
				System.out.println("Foi duro em, o "+jogadorUm+" fez "+somaj1+" e acabou perdendo...");
				System.out.println("Enquanto...");
				Thread.sleep(1500);
				System.out.println("O "+jogadorDois+" fez "+somaj2+" e é o grande vencedor dessa rodada!!!");
				System.out.println("\n\tVam BORA "+jogadorDois+"!!");	
			}
			
		}
		
		
	}
}