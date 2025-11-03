using CRUD_Cliente2.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Cliente2.Web.ViewModels
{
    public class EnderecoViewModel
    {
        [Required]
        public int ClienteId { get; set; }
        [Required] public string TipoResidencia { get; set; }
        [Required] public string TipoLogradouro { get; set; }
        [Required] public string Logradouro { get; set; }
        [Required] public string Numero { get; set; }
        [Required] public string Bairro { get; set; }

        [Required, RegularExpression(@"^\d{8}$", ErrorMessage = "CEP inválido.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Selecione uma cidade.")]
        public int? CidadeSelecionada { get; set; }

        [Required(ErrorMessage = "Selecione um estado.")]
        public int? EstadoSelecionado { get; set; }

        [Required(ErrorMessage = "Selecione um país.")]
        public int? PaisSelecionado { get; set; }

        [Required] public List<SelectListItem> Cidades { get; set; } = new();
        [Required] public List<SelectListItem> Estados { get; set; } = new();
        [Required] public List<SelectListItem> Paises { get; set; } = new();

        public string? Observacoes { get; set; }
        public string? NomeIdentificador { get; set; }

        public Endereco ToEntity()
        {
            return new Endereco
            {
                TipoResidencia = TipoResidencia,
                TipoLogradouro = TipoLogradouro,
                Logradouro = Logradouro,
                Numero = Numero,
                Bairro = Bairro,
                CEP = CEP,
                NomeIdentificador = NomeIdentificador,
                Observacoes = Observacoes,
                CidadeId = CidadeSelecionada ?? throw new Exception("cidade não selecionada")
            };
        }
    }
}
