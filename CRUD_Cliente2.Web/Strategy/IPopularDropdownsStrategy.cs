using CRUD_Cliente2.Web.ViewModels;

namespace CRUD_Cliente2.Web.Strategy
{
    public interface IPopularDropdownsStrategy
    {
        void Executar(EnderecoViewModel viewModel);
    }
}
