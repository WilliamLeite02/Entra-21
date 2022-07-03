import java.util.Scanner;
public class Loja{
    public static void main (String args[]){            
        Scanner ler = new Scanner(System.in);
        Empresa emp = new Empresa();
        byte escolha;
        do{
            System.out.println("1-Escolher andar");
            System.out.println("0-sair do prédio");
            escolha = ler.nextByte();
            
            switch(escolha){
                case 1:
                    System.out.println("Escolha o andar");
                    System.out.println("(1)");
                    System.out.println("(2)");
                    System.out.println("(3)");
                    System.out.println("(4)");
                    System.out.println("(5)");
                    System.out.println("(6)");
                    System.out.println("(7)");
                    
                    System.out.println("Resultado:" + emp.entrarNoSetor());
                    break;
                case 0:
                    System.out.println("Você saiu do prédio");
            }
        }while(escolha!=0);
        System.out.println("digite o andar a ir: ");
        emp.setAndar(ler.nextInt());
        
        System.out.println("RESPOSTA:");
        String andar = emp.entrarNoSetor();
        System.out.println(andar);
        
    }
}