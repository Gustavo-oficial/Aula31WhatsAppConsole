namespace Aula31WhatsAppConsole
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }

        public Contato Destinatario { get; set; }
 
        /// <summary>
        /// Metodo criado para enviar mensagem
        /// </summary>
        /// <param name="_contato"></param>
        /// <param name="Texto">Mostrar o texto enviado</param>
        /// <returns>Retorna a mensagem com destinario e a mensagem enviada</returns>
        public string EnviarMensagem(Contato _contato,string Texto){
            return $"Para: {_contato.Nome} \n Voce:{Texto}";
        }
    }
}