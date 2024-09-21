using System.Data.SqlTypes;

namespace ControleFinanceiro.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public SqlMoney Valor { get; set; }
        public bool Tipo { get; set; }
        public DateTime DataTransacao { get; set; }

    }
}
