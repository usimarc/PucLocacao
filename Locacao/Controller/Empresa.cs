using System.ComponentModel.DataAnnotations;

namespace Locacao.Controller
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }

        public string? Nome { get; set; }

        public string? CPF { get; set; }

        public string? Endereco { get; set; }
    }
}
