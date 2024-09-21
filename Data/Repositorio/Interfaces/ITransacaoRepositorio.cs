using ControleFinanceiro.Models;

namespace ControleFinanceiro.Data.Repositorio.Interfaces
{
    public interface ITransacaoRepositorio
    {
        Transacao BuscarId(int id);

        void Registro(Transacao transacao);
    }
}
