using System.ComponentModel.DataAnnotations;

namespace CRUD_Cliente2.Web.ViewModels
{
    public class ClienteFormViewModel
    {
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
    }
}
