using System.ComponentModel.DataAnnotations;
using CRUD_Cliente2.Web.Models;

namespace CRUD_Cliente2.Web.ViewModels
{
    public class ClienteCreateViewModel
    {
        public ClienteCreateViewModel()
        {
            EnderecoResidencial = new EnderecoViewModel();
            EnderecoCobranca = new EnderecoViewModel();
        }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string TelefoneTipo { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}$")]
        public string TelefoneDDD { get; set; }

        [Required]
        [RegularExpression(@"^\d{8,9}$")]
        public string TelefoneNumero { get; set; }

        [Required]
        [MinLength(8)]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmarSenha { get; set; }
        [Required]
        public EnderecoViewModel EnderecoResidencial { get; set; } 
        [Required]
        public EnderecoViewModel EnderecoCobranca { get; set; }

        [Required]
        [StringLength(19, MinimumLength = 13, ErrorMessage = "O número do cartão deve ter entre 13 e 19 dígitos.")]
        [RegularExpression(@"^\d{13,19}$", ErrorMessage = "O número do cartão deve conter apenas dígitos.")]
        public string NumeroCartao { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomeImpresso { get; set; }

        [Required]
        [MaxLength(20)]
        public string Bandeira { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 3)]
        public string CodigoSeguranca { get; set; }

        public bool Preferencial { get; set; } = true;

        public Cliente ToEntity()
        {
            var cliente = new Cliente
            {
                Nome = Nome,
                DataNascimento = DataNascimento,
                CPF = CPF,
                Email = Email,
                Genero = Genero,
                TelefoneTipo = TelefoneTipo,
                TelefoneDDD = TelefoneDDD,
                TelefoneNumero = TelefoneNumero,
                Senha = Senha,
                EnderecoResidencial = EnderecoResidencial.ToEntity(),
                EnderecoCobranca = EnderecoCobranca.ToEntity(),
                Cartoes = new List<Cartao>
            {
                new Cartao
                {
                    NumeroCartao = NumeroCartao,
                    NomeImpresso = NomeImpresso,
                    Bandeira = Bandeira,
                    CodigoSeguranca = CodigoSeguranca,
                    Preferencial = Preferencial
                }
            }
            };

            return cliente;
        }
    }
}
    

