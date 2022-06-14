public class Pessoa{
    public String nome;
    public int anoDeNascimento;
    public byte numeroDeFilhos;
    public double salario;
    
    public int calcularIdade(int anoAtual){
        return anoAtual - this.anoDeNascimento;
    }
}