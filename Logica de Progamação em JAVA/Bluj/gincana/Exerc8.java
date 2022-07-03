import java.util.Scanner;
public class Exerc8{
    public static void boletim(){
        Scanner ler = new Scanner(System.in);
   
        System.out.print("Informe percentual de frequência: ");
        float freq = ler.nextFloat();
        float nota=0;
        for(int i=0;i<3;i++){
        System.out.print("Informe nota: ");
          nota += ler.nextFloat(); 
        }
        float media = nota/3;
        
        if((media>=7)&&(freq>=75)){
           System.out.println("Aprovado"); 
        }else{
            System.out.println("Reprovado");
        }
                
    }
}