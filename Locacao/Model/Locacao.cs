using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locacao.Model
{
    public class Locacao
    {
        [Key]
        public int IdLocacao { get; set; }

        // Foreign key for Empresa
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; } 

        // Foreign key for Cliente
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } 

        // Foreign key for Funcionario
        [ForeignKey("Funcionario")]
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; } 

        // Foreign key for Veiculo
        [ForeignKey("Veiculo")]
        public int IdVeiculo { get; set; }
        public Veiculo Veiculo { get; set; } 

        public string? DataInicio { get; set; }
        public string DataFinal { get; set; }
        public string Valor { get; set; }
    }
}

