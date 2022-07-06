import java.util.Scanner;
public class Categoria{
    public static void main(String args[]){
        Scanner ler = new Scanner(System.in);
        
        int idade;
        
        System.out.print("qual a sua idade:");
        idade=ler.nextInt();
        
        if(idade<=4){
            System.out.print("Vocẽ nao esta qualificado a participar");
        }else if(idade>=5 && idade<=10){
            System.out.print("Vocẽ esta na categoria infantil.");
        }else if(idade>=11 && idade<=15){
            System.out.print("voce esta na categoria infanto juvenil.");
        }else if (idade>=16 && idade<=20){
            System.out.print("voce esta na categoria juvenil.");
        }else if(idade>=21 && idade<=48){
            System.out.print("voce esta na categoria adultos.");
        }else if(idade>=49 && idade<=70){
            System.out.print("voce esta na categoria senior.");
        }else{
            System.out.print("voce é muito experiente.");
        }
        
        
        
        
    }  
}