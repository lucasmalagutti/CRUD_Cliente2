using System.Text;

namespace CRUD_Cliente2.Web.Strategy
{
    public class CriptografarSenhaStrategy : ICriptografarSenhaStrategy
    {
        public string Criptografar(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Senha não pode ser vazia.");

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(senha));
        }
    }
}
