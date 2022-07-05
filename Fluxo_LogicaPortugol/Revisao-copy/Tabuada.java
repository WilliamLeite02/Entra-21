public class Tabuada{
    private int valor;
    
    public int getValor(){
        return this.valor;
    }
    public void setValor(int valor){
        this.valor = valor;
    }
    public String gerarTabuada(int multiplicador){
        return this.valor + " X " + multiplicador + " = " + this.valor*multiplicador;
    }
}