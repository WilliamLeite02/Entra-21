public class Numero{
    private int valor;
    
    public int getValor(){
        return this.valor;

    }
    public void setValor(int valor){
        this.valor=valor;
    }
    public String verificarNumero(){
        if(this.valor%2==0 && this.valor>0){
            return "Par Positivo";
        }else if(this.valor%2==0 && this.valor<0){
            return "Par negativo";
        }else if(this.valor%2!=0 && this.valor>0){
            return "Impar positivo";
        }else if(this.valor%2!=0 && this.valor<0){
            return "Impar negativo";
        }else{
            return "Nulo";
        }
    }
}