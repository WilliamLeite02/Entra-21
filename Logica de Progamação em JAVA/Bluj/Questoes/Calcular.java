public class Calcular{
    public static void main (String args[]){
        int a=3;
        int b=2;
        int c=8;
        boolean resultado,r2,r3,r4,r5;
        
        resultado=(a+b<c || b!=a && a>0);
        r2=(c<=a*a || c<=a*b || c<=a+b);
        r3=(a<b && b<c && c<a);
        //r4=(!a<b && !a<c && !c<a);
        r5=(a!=b || b>c && b-a>0);
        
        System.out.println("a "+resultado+" "+r2+ " "+r3+" "+r5);
        
        
    
    }
}
    