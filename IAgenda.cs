namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato _contato);
         
         void Excluir(Contato _contato);

         void Listar();
         
    }
}