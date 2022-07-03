public class Numero{
            private int numero;
            
            public void setNumero(int numero){
                this.numero=numero;
            }
            public int getNumero(){
                return this.numero;
            }
            public String verificarNumero(){
                if(this.numero==0){
                    return "numero nulo";
                }else if(this.numero>0){
                    return "numero positivo";
                }else{
                    return "numero negativo";
                }
            }
        }