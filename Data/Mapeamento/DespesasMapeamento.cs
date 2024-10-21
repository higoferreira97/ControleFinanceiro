using ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ControleFinanceiro.Data.Mapeamento
{
    public class DespesasMapeamento : IEntityTypeConfiguration<DespesasModel>
    {
        public void Configure(EntityTypeBuilder<DespesasModel> builder)
        {
            builder.ToTable("Despesas");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnType("int");
            builder.Property(t => t.DataTransacao).HasColumnType("datetime");
            builder.Property(t => t.Valor).HasColumnType("money");
            builder.Property(t => t.Categoria).HasColumnType("varchar(30)");
            builder.Property(t => t.Descricao).HasColumnType("varchar(200)");
          



        }
    }
}


//CREATE DATABASE ControleFinanceiro
//USE ControleFinanceiro
//CREATE TABLE Despesas (
//Id INT IDENTITY(1,1) NOT NULL,
//DataTransacao DATETIME DEFAULT GETDATE(),
//Valor MONEY NOT NULL,
//Categoria Varchar(30) NOT NULL,
//Descricao VARCHAR(200)  NULL,
//PRIMARY KEY(Id)
//)
