using CRUD_Cliente2.Web.Data;
using CRUD_Cliente2.Web.Models;
using CRUD_Cliente2.Web.Strategy;
using CRUD_Cliente2.Web.ViewModels;

namespace CRUD_Cliente2.Web.Facade
{
    public class ClienteFacade
    {
        private readonly IClienteDAO _clienteDAO;
        private readonly IClienteStrategy _cadastrarStrategy;
        private readonly IClienteStrategy _editarStrategy;
        private readonly IClienteStrategy _inativarStrategy;
        private readonly IClienteSenhaStrategy _senhaStrategy;
        private readonly ConsultarClienteStrategy _consultarStrategy;
        private readonly IPopularDropdownsStrategy _popularDropdownsStrategy;
        private readonly IAdicionarEnderecoStrategy _adicionarEnderecoStrategy;
        private readonly IAdicionarCartaoStrategy _adicionarCartaoStrategy;

        public ClienteFacade(
            IClienteDAO clienteDAO,
            CadastrarClienteStrategy cadastrarStrategy,
            EditarClienteStrategy editarStrategy,
            InativarClienteStrategy inativarStrategy,
            AlterarSenhaStrategy senhaStrategy,
            IPopularDropdownsStrategy popularDropdownsStrategy,
            ConsultarClienteStrategy consultarStrategy,
            IAdicionarEnderecoStrategy adicionarEnderecoStrategy,
            IAdicionarCartaoStrategy adicionarCartaoStrategy)
        {
            _clienteDAO = clienteDAO;
            _cadastrarStrategy = cadastrarStrategy;
            _editarStrategy = editarStrategy;
            _inativarStrategy = inativarStrategy;
            _senhaStrategy = senhaStrategy;
            _popularDropdownsStrategy = popularDropdownsStrategy;
            _consultarStrategy = consultarStrategy;
            _adicionarEnderecoStrategy = adicionarEnderecoStrategy;
            _adicionarCartaoStrategy = adicionarCartaoStrategy;
        }
        public async Task AdicionarCartaoAsync(Cartao cartao)
        {
            await _adicionarCartaoStrategy.ExecutarAsync(cartao);
        }
        public async Task AdicionarEnderecoAsync(int clienteId, Endereco endereco)
        {
            await _adicionarEnderecoStrategy.ExecutarAsync(clienteId, endereco);
        }
        public async Task<IEnumerable<Cliente>> ConsultarClientesAsync(string filtro)
        {
            return await _consultarStrategy.ExecutarAsync(filtro);
        }

        public async Task<Cliente> ObterPorIdAsync(int id)
        {
            return await _clienteDAO.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            return await _clienteDAO.ObterTodosAsync();
        }

        public async Task CadastrarClienteAsync(Cliente cliente)
        {
            await _cadastrarStrategy.ExecutarAsync(cliente);
        }
        public void PopularDropdowns(EnderecoViewModel enderecoViewModel)
        {
             _popularDropdownsStrategy.Executar(enderecoViewModel);
        }

        public async Task EditarClienteAsync(Cliente cliente)
        {
            await _editarStrategy.ExecutarAsync(cliente);
        }

        public async Task InativarClienteAsync(int clienteId)
        {
            var cliente = await _clienteDAO.ObterPorIdAsync(clienteId);
            if (cliente != null)
            {
                await _inativarStrategy.ExecutarAsync(cliente);
            }
        }

        public async Task AlterarSenhaAsync(int clienteId, string novaSenha)
        {
            await _senhaStrategy.AlterarSenhaAsync(clienteId, novaSenha);
        }
    }
}
