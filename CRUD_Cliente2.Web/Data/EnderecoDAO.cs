using CRUD_Cliente2.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Cliente2.Web.Data
{
    public class EnderecoDAO : IEnderecoDAO
    {
        private readonly AppDbContext _context;

        public EnderecoDAO(AppDbContext context)
        {
            _context = context;
        }

        public List<Pais> ObterPaises()
        {
            return _context.Paises.AsNoTracking().ToList();
        }

        public List<Estado> ObterEstados()
        {
            return _context.Estados.AsNoTracking().ToList();
        }

        public List<Cidade> ObterCidades()
        {
            return _context.Cidades.AsNoTracking().ToList();
        }
    }
}
