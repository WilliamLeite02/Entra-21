
public class Data{
    private int dia;
    private int mes;
    private int ano;
    //set
    public void setDia(int dia){
        this.dia=dia;
    }
    public void setMes(int mes){
        this.mes=mes;
    }
    public void setAno(int ano){
        this.ano=ano;
    }
    //Gets
    public int getDia(){
        return this.dia;
    }
    public int getMes(){
        return this.mes;
    }
    public int getAno(){
        return this.ano;
    }
    public String toString(){
        return this.dia + "/"+this.mes+"/"+this.ano;
    }
}