public class Funcionario{
    public String nome;
    public double salarioBase;
    
    public void dobrarSalario(){
        this.salarioBase = this.salarioBase * 2;
    }
    public double calcularFerias(){
        return this.salarioBase *1.33;
    }
    public void descontarAdiantamento(double valor){
        this.salarioBase = this.salarioBase - valor;
    }
    public double calcularHoraExtra(double totalDeHoras){
        return this.salarioBase/220 *2 *totalDeHoras;
    }
}