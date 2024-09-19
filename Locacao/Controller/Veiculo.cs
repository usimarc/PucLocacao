using System.ComponentModel.DataAnnotations;

namespace Locacao.Controller
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public string? ano { get; set; }
        public string? Km { get; set; }
    }
}
