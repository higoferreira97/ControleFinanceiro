using ControleFinanceiro.Models;
using ControleFinanceiro.Data.Repositorio.Interfaces;

namespace ControleFinanceiro.Data.Repositorio.Interfaces
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public TransacaoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Transacao BuscarId(int id) 
        {
            return _bancoContexto.Transacao.FirstOrDefault(x => x.Id == id);
        }

        public void Registro(Transacao transacao)
        {
            _bancoContexto.Transacao.Add(transacao);
            _bancoContexto.SaveChanges();
        }
    }
}
