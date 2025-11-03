using CRUD_Cliente2.Web.Data;

namespace CRUD_Cliente2.Web.Strategy
{
    public class AlterarSenhaStrategy : IClienteSenhaStrategy
    {
        private readonly AppDbContext _context;

        public AlterarSenhaStrategy(AppDbContext context)
        {
            _context = context;
        }

        public async Task AlterarSenhaAsync(int clienteId, string novaSenha)
        {
            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 8)
                throw new ArgumentException("Senha deve ter pelo menos 8 caracteres.");

            var cliente = await _context.Clientes.FindAsync(clienteId);
            if (cliente == null)
                throw new ArgumentException("Cliente não encontrado.");

            // Criptografar senha (mesma regra usada no cadastro)
            cliente.Senha = CriptografarSenha(novaSenha);

            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        private string CriptografarSenha(string senha)
        {
            // Placeholder simples: usar hashing real em produção
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(senha));
        }
    }
}
