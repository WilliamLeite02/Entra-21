public class Jogo{
    
    private JanKenPon usuario;
    private JanKenPon computador;
    
public Jogo(byte jogadaUsuario){
    this.usuario= new JanKenPon(jogadaUsuario);
    byte sorteio = (byte)(Math.random()*3+1);
    this.computador = new JanKenPon(sorteio);
}
public String verificarVencedor(){
    byte usu = this.usuario.getJogada();
    byte comp = this.computador.getJogada();
    if(usu == comp || usu==4 && comp==1 || comp==4 && usu==1){
        return "Empate";
    }else if(usu==1 && comp==3 || usu==2 && comp==1 || usu==3 && comp==2 || usu==4 && comp==2){
        return "Usuario vence!";
    }else{
        return "Computador vence!";
    }
}
public String toString(){
    return "Usuario jogou: " + this.usuario + "\nComputador jogou: " + this.computador;
}
}