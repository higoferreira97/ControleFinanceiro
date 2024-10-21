using ControleFinanceiro.Models;

namespace ControleFinanceiro.Data.Repositorio.Interfaces
{
    public interface IDespesasRepositorio
    {
        List<DespesasModel> BuscarDespesas();
        void AddDespesas(DespesasModel despesas);
        DespesasModel BuscarId(int id);
        void EditarDespesas(DespesasModel despesas);
        void Excluir(DespesasModel despesas);

    }
}
