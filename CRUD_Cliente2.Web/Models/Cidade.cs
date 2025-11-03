using System.ComponentModel.DataAnnotations;

namespace CRUD_Cliente2.Web.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }
    }
}
