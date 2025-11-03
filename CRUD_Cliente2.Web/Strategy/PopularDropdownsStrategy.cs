using CRUD_Cliente2.Web.Data;
using CRUD_Cliente2.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Cliente2.Web.Strategy
{
    public class PopularDropdownsStrategy : IPopularDropdownsStrategy
    {
        private readonly IEnderecoDAO _enderecoDAO;

        public PopularDropdownsStrategy(IEnderecoDAO enderecoDAO)
        {
            _enderecoDAO = enderecoDAO;
        }

        public void Executar(EnderecoViewModel viewModel)
        {
            viewModel.Paises = _enderecoDAO.ObterPaises()
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Nome
                }).ToList();

            viewModel.Estados = _enderecoDAO.ObterEstados()
                .Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Nome
                }).ToList();

            viewModel.Cidades = _enderecoDAO.ObterCidades()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                }).ToList();
        }
    }
}
