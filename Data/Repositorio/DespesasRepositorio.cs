using ControleFinanceiro.Models;
using ControleFinanceiro.Data.Repositorio.Interfaces;


namespace ControleFinanceiro.Data.Repositorio
{
    public class DespesasRepositorio : IDespesasRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public DespesasRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<DespesasModel> BuscarDespesas()
        {
            return _bancoContexto.Despesas.ToList();
        }

        public void AddDespesas(DespesasModel despesas)
        {
            _bancoContexto.Despesas.Add(despesas);
            _bancoContexto.SaveChanges();

        }

        public DespesasModel BuscarId(int id)
        {
            return _bancoContexto.Despesas.FirstOrDefault(x => x.Id == id);
        }

        public void EditarDespesas(DespesasModel despesas)
        {
            _bancoContexto.Despesas.Update(despesas);
            _bancoContexto.SaveChanges();
        }

        public void Excluir(DespesasModel despesas)
        {
            _bancoContexto.Despesas.Remove(despesas);
            _bancoContexto.SaveChanges();
        }





    }
}
