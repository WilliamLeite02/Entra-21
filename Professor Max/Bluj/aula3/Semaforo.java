public class Semaforo{
    private String cor;
    
    
    public Semaforo(){
      this.cor = "Vermelho";
    }
    public Semaforo(String cor){
        this.cor=cor ;
    }
    public void sinalizarAtencao(){
        this.cor = "Amarelo";
    }
    public void sinalizarPare(){
        this.cor="Vermelho";
    }
    public void sinalizarSiga(){
        this.cor ="Verde";
    }
    public String toString(){
        return "O semáforo está sinalizando: "+this.cor;
    }
}