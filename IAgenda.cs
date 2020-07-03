namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato _nome, Contato _numero);

         void Excluir(Contato _nome, Contato _numero);

         void Listar();
         
    }
}