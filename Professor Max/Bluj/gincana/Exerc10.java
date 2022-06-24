import java.util.Scanner;
public class Exerc10{
    public static void main (String args[]){
    Scanner ler=new Scanner(System.in);
    String joao, pedro, lucas, maria, ana;
    int voto;
    int pedroo =0;
    int joaoo=0;
    int lucass=0;
    int mariaa=0;
    int anaa=0;
   
    
      System.out.println("Em quem voce vota?");
      System.out.println("joao vote 1");
      System.out.println("pedro vote 2");
      System.out.println("lucas vote 3");
      System.out.println("maria vote 4");
      System.out.println("ana vote 5");
      System.out.println("digite o seu voto:");
    for (int i=0; i<5; i++){
      voto=ler.nextInt();
      
      if(voto==1){
          joaoo+=1;
      }else if(voto==2){
          pedroo+=1;
      }else if(voto==3){ 
        lucass+=1;
      }else if(voto==4){
         mariaa+=1;
      }else if(voto==5){
        anaa+=1;
      }else{System.out.print("numero nao conta");}
    }
    System.out.print("votos finalizados");
    System.out.println("joao "+joaoo+" pedro "+pedroo+" lucas "+lucass+" maria "+mariaa+" ana "+anaa);
    
    }
}