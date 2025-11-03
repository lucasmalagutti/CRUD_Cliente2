using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Data
{
    public interface IClienteDAO
    {
        Task<Cliente> ObterPorIdAsync(int id);
        Task<IEnumerable<Cliente>> ObterTodosAsync();
        Task<IEnumerable<Cliente>> BuscarPorFiltroAsync(string filtro);
        Task AdicionarAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
        Task InativarAsync(int id);
        Task AdicionarCartaoAsync(Cartao cartao);
        Task AdiconarEnderecoAsync(int clienteId, Endereco endereco);
    }
}
