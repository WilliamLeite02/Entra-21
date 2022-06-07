 import java.util.Scanner;
 public class main{
     public static void main(String args[]){
            Scanner ler = new Scanner(System.in);
            Data d1 = new Data();
            
            System.out.print("informe o dia:");
            d1.setDia(ler.nextInt());
            System.out.print("informe o numero do mes:");
            d1.setMes(ler.nextInt());
            System.out.print("informe o ano:");
            d1.setAno(ler.nextInt());
            System.out.println("visualizando a data:");
            System.out.print(d1);
            
        }
    }