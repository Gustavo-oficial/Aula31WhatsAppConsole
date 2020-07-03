namespace Aula31WhatsAppConsole
{
    public class Contato : Agenda
    {
        public string Nome { get; set; }

        public int Numero { get; set; }

        public Contato(string _nome, int _numero){
           this.Nome = _nome;
           this.Numero = _numero;
        }
    }
}