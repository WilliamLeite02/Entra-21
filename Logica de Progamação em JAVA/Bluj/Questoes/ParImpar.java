import java.util.Scanner;
public class ParImpar{
    public static void main (String args[]){
        Scanner ler=new Scanner(System.in);
        
        double num;
        
        System.out.print("digite numero:");
        num=ler.nextDouble();
        
        if(num > 0 && num%2==0){
            System.out.print("par positivo");
        }else{
            System.out.print("impar positivo");
        }
        
    
    }
}