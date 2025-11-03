using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.ViewModels
{
    public class ClienteDetailsViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }
        public int Ranking { get; set; }
        public bool Ativo { get; set; }

        public Endereco EnderecoResidencial { get; set; }
        public Endereco EnderecoCobranca { get; set; }

        public List<Endereco> Enderecos { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public List<Transacao> Transacoes { get; set; }

        public ClienteDetailsViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            CPF = cliente.CPF;
            Email = cliente.Email;
            Genero = cliente.Genero;
            Telefone = $"({cliente.TelefoneDDD}) {cliente.TelefoneNumero}";
            DataNascimento = cliente.DataNascimento.ToShortDateString();
            Ranking = cliente.Ranking;
            Ativo = cliente.Ativo;
            EnderecoResidencial = cliente.EnderecoResidencial;
            EnderecoCobranca = cliente.EnderecoCobranca;
            Enderecos = cliente.Enderecos.ToList();
            Cartoes = cliente.Cartoes.ToList();
            Transacoes = cliente.Transacoes.ToList();
        }
    }
}
