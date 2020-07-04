namespace Aula31WhatsAppConsole
{
    public class Contato
    {
        public string Nome { get; set; }

        public int Numero { get; set; }

        public Contato(){

        }
        public Contato(string _nome, int _numero){
            this.Nome = _nome;
            this.Numero = _numero;
        }

    }
}