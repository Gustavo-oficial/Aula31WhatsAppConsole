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

        List<string> linhas = new List<string>();
        public void Excluir(Contato _cont, string _contato)
            {
                contato.Remove(_cont);
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null){
                    linhas.Add(linha);
                }
            }

            linhas.RemoveAll(z => z.Contains(_contato));

            ReescreverCsv(linhas);

        }
        public void Listar()
        {
            foreach(Contato con in contato)
            {
                Console.WriteLine($"Nome: {con.Nome} ");
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