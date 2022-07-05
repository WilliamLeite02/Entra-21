public class NumeroSemana{
    private int valor;
    
    public NumeroSemana(int valor){
        this.valor=valor;
    }
    public void setValor(int valor){
        this.valor =valor;
    }
    public int getValor(){
        return this.valor;
    }
    public int calcularFatorial(){
        int cont = 1;
        int fatorial = 1;
        do{
            fatorial = fatorial * cont;
            cont = cont+1;
        }while(cont<=this.valor);
        return fatorial;
    }
    public int calcularSomatorio(){
        int soma=0;
        int cont =1;
        do{
            soma = soma + cont;
            cont ++;
        }while(cont<=this.valor);
        return soma;
    }
    public int contarMultiplos(){
        int contMultiplos = 0 ;
        int cont = 1;
        do{
            if (this.valor%cont == 0){
               contMultiplos++; 
            }
            cont++;
        }while(cont<=this.valor);
        return contMultiplos;
    }
    public String verificarSeEPrimo(){
        int contM = contarMultiplos();
        if (contM == 2) {
            return this.valor+ " é primo ";
        }else {
            return this.valor+ " é composto";
        }
    }
}