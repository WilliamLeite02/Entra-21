import java.util.Scanner;
public class Exerc14{
    public static void main (String args[]){
    Scanner ler = new Scanner(System.in);
    double deposito=0, saque=0, pagamento=0, saldo=0, n1;
    int fazer;
    
    System.out.print("continuar 1");
    System.out.print("parar 0");
    fazer=ler.nextInt();
    
    do{
    System.out.println("1 deposito");
    System.out.println("2 saque");
    System.out.println("3 pagamento");
    System.out.println("4 saldo");
    System.out.println("digite o numero desejado:");
    n1=ler.nextDouble();
        if(n1==1){
        System.out.print("digite o valor a depositar:");
        deposito=ler.nextDouble();
        saldo+=deposito;
    }else if (n1==2){
        System.out.print("digite o valor a sacar:");
        saque=ler.nextDouble();
        if(saldo<saque){
            System.out.print("saldo menor  que o saque");
        }else{saldo-=saque;}
    }else if (n1==3){
        System.out.print("digite o valor do boleto:");
        pagamento=ler.nextDouble();
        saldo -=pagamento;
    }else if (n1==4){
        System.out.print("seu saldo é:"+saldo);
    }else{System.out.print("numero incorreto");}
    
    }while(fazer !=0);
    }  
}