using CadastroDeContato.Models;

namespace CadastroDeContato.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
