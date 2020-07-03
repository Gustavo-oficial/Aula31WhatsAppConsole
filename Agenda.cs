using System.Collections.Generic;
using System.IO;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {
        private const string PATH = "Database/contato.csv";

        public Agenda()
        {         
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Contato _nome, Contato _numero)
        {
            List<Contato> contatos = new List<Contato>();

            string [] linha = new string []  { CriarLinha(_nome,_numero)};
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(Contato _nome, Contato _numero)
        {
            
        }
        public void Listar()
        {
            
        }

        private string CriarLinha(Contato _nome, Contato _numero){
              return $"{_nome};{_numero} \n";
          }
    }
}