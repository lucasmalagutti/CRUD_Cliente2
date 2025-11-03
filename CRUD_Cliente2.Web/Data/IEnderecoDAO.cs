using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Data
{
    public interface IEnderecoDAO
    {
        List<Pais> ObterPaises();
        List<Estado> ObterEstados();
        List<Cidade> ObterCidades();
    }
}
