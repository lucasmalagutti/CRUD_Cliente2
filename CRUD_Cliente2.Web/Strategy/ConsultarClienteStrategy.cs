using CRUD_Cliente2.Web.Data;
using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Strategy
{
    public class ConsultarClienteStrategy
    {
        private readonly IClienteDAO _clienteDAO;

        public ConsultarClienteStrategy(IClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }

        public async Task<IEnumerable<Cliente>> ExecutarAsync(string filtro)
        {
            return await _clienteDAO.BuscarPorFiltroAsync(filtro);
        }
    }
}
