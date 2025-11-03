using System.ComponentModel.DataAnnotations;
using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.ViewModels
{
    public class ClienteEditViewModel : ClienteFormViewModel
    {
        [Required]
        public int Id { get; set; }

        public List<Endereco> Enderecos { get; set; } = new();
        public List<Cartao> Cartoes { get; set; } = new();

        public Cliente ToEntity()
        {
            return new Cliente
            {
                Id = this.Id,
                Nome = this.Nome,
                DataNascimento = this.DataNascimento,
                CPF = this.CPF,
                Email = this.Email,
                Genero = this.Genero,
                TelefoneTipo = this.TelefoneTipo,
                TelefoneDDD = this.TelefoneDDD,
                TelefoneNumero = this.TelefoneNumero,
                Enderecos = this.Enderecos ?? new List<Endereco>(),
                Cartoes = this.Cartoes ?? new List<Cartao>()
            };
        }

        public static ClienteEditViewModel FromEntity(Cliente cliente)
        {
            return new ClienteEditViewModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                DataNascimento = cliente.DataNascimento,
                Email = cliente.Email,
                CPF = cliente.CPF,
                Genero = cliente.Genero,
                TelefoneTipo = cliente.TelefoneTipo,
                TelefoneDDD = cliente.TelefoneDDD,
                TelefoneNumero = cliente.TelefoneNumero,
                Enderecos = cliente.Enderecos.ToList(),
                Cartoes = cliente.Cartoes.ToList()
            };
        }
    }
}
