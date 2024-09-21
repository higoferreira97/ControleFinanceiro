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
            modelBuilder.ApplyConfiguration(new TransacaoMapeamento());
            //modelBuilder.ApplyConfiguration(new ProfessorMapeamento());
        }

        public DbSet<Transacao> Transacao { get; set; }
        //public DbSet<Professor> Professor { get; set; }
    }
}
