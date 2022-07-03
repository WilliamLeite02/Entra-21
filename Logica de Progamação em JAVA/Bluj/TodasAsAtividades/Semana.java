public class Semana{
    private int dia;
    
    public void setDia(int dia){
        this.dia=dia;
    }
    public int getDia(){
        return this.dia;
    }
    public String verDia(){
        if(this.dia==1){
            return "Domingo";
        }else if(this.dia==2){
            return "segunda";
        }else if(this.dia==3){
            return "terça";
        }else if(this.dia==4){
            return "quarta";
        }else if(this.dia==5){
            return "quinta";
        }else if(this.dia==6){
            return "sexta";
        }else if(this.dia==7){
            return "sabado";
        }else{
            return "sem dia da semana";
        }
    }
}