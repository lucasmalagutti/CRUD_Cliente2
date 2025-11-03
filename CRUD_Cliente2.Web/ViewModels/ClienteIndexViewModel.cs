namespace CRUD_Cliente2.Web.ViewModels
{
    public class ClienteIndexViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Ranking { get; set; }
        public bool Ativo { get; set; }
    }
}
