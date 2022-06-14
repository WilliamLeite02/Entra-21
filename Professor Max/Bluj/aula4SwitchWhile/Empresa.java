    public class Empresa {
        private int andar;
        
        public void setAndar(int andar){
            this.andar = andar;
        }
        public int getAndar(){
            return this.andar;
        }
        public String toString(){
        switch(this.andar){
        case 1: if(this.andar==1){
                return "Andar principal";
        }else if(this.andar==2){
            return "Andar de lojas";
        }else if(this.andar==3){
            return "Andar Salas Comercial";
        }else if(this.andar==4){
            return "Andar de Mercado";
        }else if(this.andar==5){
            return "Andar de Jogos";
        }else if(this.andar==6){
            return "Andar de Restaurante";
        }else if(this.andar==7){
            return "Andar Vendas";
        }default:
            return "Andar fechado";
        
       }
    }
}