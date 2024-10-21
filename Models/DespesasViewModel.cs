namespace ControleFinanceiro.Models
{
    public class DespesasViewModel
    {
        public IEnumerable<DespesasModel> Despesas { get; set; }
        public IEnumerable<dynamic> DadosGrafico { get; set; }
    }
}
