    public class Semana {
        private int dia;
        
        public void setDia(int dia){
            this.dia = dia;
        }
        public int getDia(){
            return this.dia;
        }
        public String verDiaDaSemana(){
        if(this.dia==1){
                return "Domingo";
        }else if(this.dia==2){
            return "Segunda-Feira";
        }else if(this.dia==3){
            return "Terça-Feira";
        }else if(this.dia==4){
            return "Quarta-feira";
        }else if(this.dia==5){
            return "Quinta-feira";
        }else if(this.dia==6){
            return "Sexta-Feira";
        }else if(this.dia==7){
            return "Sabado!";
        }else{
            return "Dia inválido";
        }
    }
}