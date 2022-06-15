import java.util.Scanner;
public class Bhaskara{
    public static void main (String args[]){
    double a,b,c, delta, xM, xm;
    double raiz;
    //delta=b²-4*a*c
    
    Scanner ler = new Scanner(System.in);
    
    System.out.println("digite o valor A: ");
    a=ler.nextDouble();
    System.out.println("digite o valor de B: ");
    b=ler.nextDouble();
    System.out.println("digite o valor de C: ");
    c=ler.nextDouble();
    
    delta=b*b-4*a*c;
    
    System.out.println("valor do delta: "+delta);
    System.out.println("");
    System.out.println("Segunda parte do calculo +e-");
    
    raiz=Math.sqrt(delta);
    xM=((-b+raiz)/(2*a));
    
    xm=((-b-raiz)/(2*a));
    
    if(xM<0){
        System.out.println("valor negativo, invalido.");
    
    }else if (xM>=0){
        System.out.println("valor, valido "+xM + " X+");
    }else if(xm<0){
        System.out.println("valor negativo, invalido.");
    }else if(xm>=0){
        System.out.println("valor, valido "+xm + " X-");
    }else{
        System.out.print("X+:"+xM + " e X-:"+xm);
    }
    
    
    
    }
}