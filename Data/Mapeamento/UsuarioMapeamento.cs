using ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace primeiroprojetoMVC.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {

            builder.ToTable("Usuario");

            builder.HasKey(t => t.Id);
           

            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Email).HasColumnType("varchar(40)");
            builder.Property(t => t.Senha).HasColumnType("varchar(40)");


        }
    }
}
