using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Strategy
{
    public interface IAdicionarEnderecoStrategy
    {
        Task ExecutarAsync(int clienteId, Endereco endereco);
    }
}
