import java.util.Scanner;
public class Cor{
    public static void main (String args[]){
        Scanner id = new Scanner (System.in);
        
        int a1,a2,a3, a4, n;
        String t1;
        
        System.out.println("1) Informe a cor do seu celular");
        System.out.println("2) Informe a cor do seu carro");
        System.out.println("3) Informe a cor do seu cachorro");
        System.out.println("Selecione uma das opções: ");
        a1=id.nextInt();
        if (a1==1){
            System.out.println("Qual a cor do seu celular?");
            System.out.println("1) Preto");
            System.out.println("2) Branco");
            System.out.println("3) Prata");
            System.out.println("4) Rosa");
            System.out.println("5) Azul");
            a2=id.nextInt();
            if (a2==1){
                System.out.println("Seu celular é Preto");
            }else if (a2==2){
                System.out.println("Seu celular é Branco");
            }else if (a2==3){
                System.out.println("Seu celular é Prata");
            }else if (a2==4){
                System.out.println("Seu celular é Rosa");
            }else if (a2==5){
                System.out.println("Seu celular é Azul");
            }else{
                System.out.println("Seu celular é estranho");
            }
        }else if (a1==2){
            System.out.println("Qual a cor do seu carro?");
            System.out.println("1) Preto");
            System.out.println("2) Branco");
            System.out.println("3) Prata");
            System.out.println("4) Vermelho");
            System.out.println("5) Azul");
            a3=id.nextInt();
            if (a3==1){
                System.out.println("Seu carro é Preto");
            }else if (a3==2){
                System.out.println("Seu carro é Branco");
            }else if (a3==3){
                System.out.println("Seu carro é Prata");
            }else if (a3==4){
                System.out.println("Seu carro é Vermelho");
            }else if (a3==5){
                System.out.println("Seu carro é Azul");
            }else{
                System.out.println("Seu carro é estranho");
            }
        }else if (a1==3){
            System.out.println("Qual a cor do seu cachorro?");
            System.out.println("1) Preto");
            System.out.println("2) Branco");
            System.out.println("3) Marron");
            System.out.println("4) Amarelo");
            System.out.println("5) Misto");
            a4=id.nextInt();
            if (a4==1){
                System.out.println("Seu carro é Preto");
            }else if (a4==2){
                System.out.println("Seu carro é Branco");
            }else if (a4==3){
                System.out.println("Seu carro é Marron");
            }else if (a4==4){
                System.out.println("Seu carro é Amarelo");
            }else if (a4==5){
                System.out.println("Seu carro é Misto");
            }else{
                System.out.println("Seu cachorro é estranho");
            }
        }else{
            System.out.println("Inválido");
        }
        
        
    }
}