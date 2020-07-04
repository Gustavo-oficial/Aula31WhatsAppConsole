namespace Aula31WhatsAppConsole
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }

        public string Destinatario { get; set; }

        public string EnviarMensagem(string Texto){
            return "Mensagem enviada!";
        }
    }
}