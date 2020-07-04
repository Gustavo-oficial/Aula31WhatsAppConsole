namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato _contato);

         void Excluir(string _contato);

         void Listar();
         
    }
}