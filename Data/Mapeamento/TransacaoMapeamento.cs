using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.SqlTypes;

namespace ControleFinanceiro.Data.Mapeamento
{
    public class TransacaoMapeamento : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("Transacao");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnType("int");
            builder.Property(t => t.Descricao).HasColumnType("varchar(200)");
            builder.Property(t => t.Valor).HasColumnType("money");
            builder.Property(t => t.Tipo).HasColumnType("bit");
            builder.Property(t => t.DataTransacao).HasColumnType("datetime");
        }
    }
}


//CREATE DATABASE ControleFinanceiro
//USE ControleFinanceiro
//CREATE TABLE Transacao (
//Id INT IDENTITY(1,1) NOT NULL,
//Descricao VARCHAR(200) NOT NULL,
//Valor MONEY NOT NULL,
//Tipo BIT NOT NULL,
//DataTransacao Date NOT NULL,
//PRIMARY KEY(Id)
//)
