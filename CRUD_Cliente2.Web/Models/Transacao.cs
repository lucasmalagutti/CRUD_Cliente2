using System.ComponentModel.DataAnnotations;

namespace CRUD_Cliente2.Web.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataTransacao { get; set; }

        public decimal Valor { get; set; }

        public string? Descricao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
