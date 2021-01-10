namespace _02_12___Criando_um_sistema_orientado_objetos.classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaAluno(){
            
            return this.mediaFinal;
        }

        public float VerMensalidade(){

            float valor;
            if(bolsista == true && mediaFinal >= 9){
                valor = this.valorMensalidade * 0.5f;
            }else{
                valor = this.valorMensalidade;
            }
            return valor;
        }

        
    }
}