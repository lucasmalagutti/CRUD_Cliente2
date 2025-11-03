using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Cliente2.Web.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string TipoResidencia { get; set; }

        [Required]
        public string TipoLogradouro { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }

        public string? Observacoes { get; set; }

        public string? NomeIdentificador { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}
