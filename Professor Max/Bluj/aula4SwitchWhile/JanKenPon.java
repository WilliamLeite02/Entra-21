public class JanKenPon{
    private byte jogada;
    
    public JanKenPon(byte jogada){
        this.jogada =jogada;
    }
    public byte getJogada(){
        return jogada;
    }
    public String toString(){
        switch(this.jogada){
            case 1: return "Pedra";
            case 2: return "Papel";
            case 3: return "Tesoura";
            default: return "Cachorro";
        }
    }
}