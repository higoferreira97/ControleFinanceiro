

using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class DespesasModel
    {
        public int Id { get; set; }
        public DateTime DataTransacao { get; set; }
        [Required(ErrorMessage = "Digite um valor!")]
        public Decimal Valor { get; set; }
        [Required(ErrorMessage = "Digite uma descrição")]
        public string Descricao { get; set; }
        public CategoriaDespesa Categoria { get; set; }
        public enum CategoriaDespesa
        {
            Alimentação,
            Transporte,
            Moradia,
            Saúde,
            Lazer,
            Outros
        }

    }
}
