using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Cliente2.Web.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

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

        public int Ranking { get; set; }

        public bool Ativo { get; set; } = true;

        public int EnderecoResidencialId { get; set; }

        [ForeignKey(nameof(EnderecoResidencialId))]
        public Endereco EnderecoResidencial { get; set; }

        public int EnderecoCobrancaId { get; set; }
        [ForeignKey(nameof(EnderecoCobrancaId))]
        public Endereco EnderecoCobranca { get; set; }


        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();

        public ICollection<Cartao> Cartoes { get; set; } = new List<Cartao>();

        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
