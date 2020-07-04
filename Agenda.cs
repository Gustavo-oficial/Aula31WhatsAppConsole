using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {
        private const string PATH = "Database/contato.csv";


        public Agenda(){

        }
        public Agenda(string Nome, int Numero)
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


        public void Cadastrar(Contato _contato)
        {
            string [] linha = new string []  { CriarLinha(_contato)};
            File.AppendAllLines(PATH, linha);
        }

        List<Contato> contato = new List<Contato>();
        public void Adicionar(Contato _contato){
            contato.Add(_contato);
        
        }

        public void Excluir(Contato _contato)
        {
             contato.Remove(_contato);
             
        }
        
        public void Listar()
        {
            
        }
            public void Ler()
        {
            foreach(Contato con in contato)
            {
                Console.WriteLine($"{con.Nome} ");
            }
        }

        private void ReescreverCsv(List<string> lines){
             
             using(StreamWriter output = new StreamWriter(PATH)){
              foreach(string ln in lines){
                output.Write(ln + "\n");
              }
            }
        }

        //  public List<Contato> Buscar(string Nome)
        // {
        //     return Ler().FindAll(x => x.Nome == Nome);
        // }

        public string CriarLinha(Contato c){
              return $"{c.Nome};{c.Numero} \n";
          }
    }
}