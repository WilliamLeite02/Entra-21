import java.util.Scanner;
public class Sinal{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
            
        System.out.println("Informe a cor inicial do semáfora: ");
        String cor=ler.nextLine();
                     
        if(cor=="verde"){
            System.out.println("Sinalizar Siga");
        }else if(cor=="amarelo"){
            System.out.print("Sinalizar Atenção");
        }else if(cor=="vermelho"){
            System.out.print("Sinalizar Pare");
        }else{
            System.out.println("Cor desconhecida");
        }
        
        Semaforo s1 = new Semaforo(cor);  
         
        
        
        System.out.println(s1);
    }
}