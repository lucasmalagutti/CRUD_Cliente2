using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.Data
{
    public class DbInitializer
    {
        public static void Inicializar(AppDbContext context)
        {
            if (!context.Paises.Any())
            {
                var brasil = new Pais { Nome = "Brasil" };
                context.Paises.Add(brasil);
                context.SaveChanges();

                var sp = new Estado { Nome = "São Paulo", PaisId = brasil.Id };
                var rj = new Estado { Nome = "Rio de Janeiro", PaisId = brasil.Id };
                context.Estados.AddRange(sp, rj);
                context.SaveChanges();

                var mogi = new Cidade { Nome = "Mogi das Cruzes", EstadoId = sp.Id };
                var santos = new Cidade { Nome = "Santos", EstadoId = sp.Id };
                context.Cidades.AddRange(mogi, santos);
                context.SaveChanges();
            }
        }
    }
}
