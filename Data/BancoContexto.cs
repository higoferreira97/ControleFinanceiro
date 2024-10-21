using System.Data;
using ControleFinanceiro.Data.Mapeamento;
using ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore;


namespace ControleFinanceiro.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.ApplyConfiguration(new DespesasMapeamento());
            
        }

        public DbSet<DespesasModel> Despesas { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
