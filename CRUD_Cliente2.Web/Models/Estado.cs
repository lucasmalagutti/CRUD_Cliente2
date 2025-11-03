using System.ComponentModel.DataAnnotations;

namespace CRUD_Cliente2.Web.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public int PaisId { get; set; }

        public Pais Pais { get; set; }
        public ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();
    }
}
