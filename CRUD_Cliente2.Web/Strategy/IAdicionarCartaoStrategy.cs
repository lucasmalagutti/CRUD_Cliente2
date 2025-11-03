using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Strategy
{
    public interface IAdicionarCartaoStrategy
    {
        Task ExecutarAsync(Cartao cartao);
    }
}
