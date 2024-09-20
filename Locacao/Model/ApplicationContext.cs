using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Locacao.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Locacao> Locacao { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _=optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Locacao;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}
