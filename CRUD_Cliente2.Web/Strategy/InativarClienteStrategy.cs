using CRUD_Cliente2.Web.Data;
using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Strategy
{
    public class InativarClienteStrategy : IClienteStrategy
    {
        private readonly IClienteDAO _clienteDAO;

        public InativarClienteStrategy(IClienteDAO clienteDAO)
        {
            _clienteDAO = clienteDAO;
        }

        public async Task ExecutarAsync(Cliente cliente)
        {
            if (cliente == null || cliente.Id == 0)
                throw new ArgumentException("Cliente inválido para inativação.");

            await _clienteDAO.InativarAsync(cliente.Id);
        }
    }
}
