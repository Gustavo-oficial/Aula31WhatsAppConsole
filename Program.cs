using System;
using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> contato1 = new List<Contato>();
            List<Agenda> contatos = new List<Agenda>();
            Agenda conta = new Agenda ();

            Contato cont1 = new Contato("Bruno", 949991357);
            Contato cont2 = new Contato("Barbara", 920356063);
            Contato cont3 = new Contato("Marina", 925957834);
            Contato cont4 = new Contato("Tobias", 924513384);
            
            conta.Adicionar(cont1);
            conta.Adicionar(cont2);
            conta.Adicionar(cont3);
            conta.Adicionar(cont4);
            conta.Cadastrar(cont1);
            conta.Cadastrar(cont2);
            conta.Cadastrar(cont3);
            conta.Cadastrar(cont4);


            System.Console.WriteLine("Deseja mandar uma mensagem? \n Digite sim para mandar, caso ao contrario digite nao");
            string condicao = Console.ReadLine();
            Console.Clear();
            
            switch (condicao)
            {
                case "sim":System.Console.WriteLine("Selecione o contato para que deseja enviar a mensagem");
                string Destinatario = Console.ReadLine();
                Console.Clear();
                Mensagem mensagem = new Mensagem();
                  if( Destinatario == "Bruno"){
                      System.Console.WriteLine("Digite sua mensagem aqui");
                      string Texto = Console.ReadLine();
                      System.Console.WriteLine(mensagem.EnviarMensagem(Texto));
                  }else if(Destinatario == "Barbara"){
                       System.Console.WriteLine("Digite sua mensagem aqui");
                      string Texto = Console.ReadLine();
                      System.Console.WriteLine(mensagem.EnviarMensagem(Texto));
                  }else if(Destinatario == "Tobias"){
                       System.Console.WriteLine("Digite sua mensagem aqui");
                      string Texto = Console.ReadLine();
                      System.Console.WriteLine(mensagem.EnviarMensagem(Texto));
                  }else if(Destinatario == "Marina"){
                     System.Console.WriteLine("Digite sua mensagem aqui");
                      string Texto = Console.ReadLine();
                      System.Console.WriteLine(mensagem.EnviarMensagem(Texto));
                      System.Console.WriteLine($"Voce:{Texto}");
                  }
                break;

                case "nao":System.Console.WriteLine("Selecione o contato que deseja excluir");
                string resposta = Console.ReadLine();
                if( resposta == "Bruno"){
                   conta.Excluir("Bruno");
                  }else if( resposta== "Barbara"){
                       conta.Excluir("Barbara");
                  }else if(resposta== "Tobias"){
                       conta.Excluir("Tobias");
                  }else if(resposta == "Marina"){
                     conta.Excluir("Marina");
                  }
                break;
                
                default:System.Console.WriteLine("Digite uma opção valida!");
                break;
            }

        }


    }
}
