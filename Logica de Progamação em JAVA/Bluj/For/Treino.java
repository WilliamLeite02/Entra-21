import java.util.Arrays;
public class Treino{
    private String nome;
    private double []marcas;
    
    public Treino(){
        this.marcas = new double[10];
    }   
    public String getNome(){
        return this.nome;}
    public double[] getMarcas(){
        return this.marcas;
    }
    public void setNome(String nome){
        this.nome=nome;
    }
    public void setMarcas(double[] marcas){
        this.marcas=marcas;
    }
    
    public void armazenarMarca(int numero, double marca){
        if(numero>=0 && numero<this.marcas.length){
            this.marcas[numero] = marca;
        }
    }
    public double calcularMediaDeMarcas(){
        double soma = 0;
        for(int i=0; i<this.marcas.length; i++){
            soma = soma + this.marcas[i];
        }
        return soma/this.marcas.length;
    }
    public double obterMaiorMarca(){
        double maior= this.marcas[0];
        for (int i=1; i<this.marcas.length; i++){
            if(this.marcas[i] > maior){
                maior = this.marcas[i];
            }
        }   
        return maior;
    }
    public String toString(){
        return this.nome + "\nMarcas:" + Arrays.toString(this.marcas);
    }
}