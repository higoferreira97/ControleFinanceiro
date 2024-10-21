using ControleFinanceiro.Models;


namespace ControleFinanceiro.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {

        UsuarioModel Login(string email, string senha);
        void Cadastrar(UsuarioModel usuarioModel);

    }
}
