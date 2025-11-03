namespace CRUD_Cliente2.Web.Strategy
{
    public interface IClienteSenhaStrategy
    {
        Task AlterarSenhaAsync(int clienteId, string novaSenha);
    }
}
