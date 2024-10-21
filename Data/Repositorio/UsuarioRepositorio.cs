using ControleFinanceiro.Models;
using ControleFinanceiro.Data.Repositorio.Interfaces;
using Azure.Messaging;
using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public UsuarioModel Login(string email, string senha)
        {
            
            return _bancoContexto.Usuario.SingleOrDefault(x => x.Email == email && x.Senha == senha);

        }

        public void Cadastrar(UsuarioModel usuarioModel)
        {
            _bancoContexto.Usuario.Add(usuarioModel);
            _bancoContexto.SaveChanges();
          

            //try
            //{
            //    if (VerificarSeEmailExiste(usuarioModel))
            //    {
            //        throw new InvalidOperationException("O email já está cadastrado.");

            //    }

            //    _bancoContexto.Usuario.Add(usuarioModel);
            //    _bancoContexto.SaveChanges();
            //    throw new InvalidOperationException("Usuário cadastrado com sucésso.");

            //}
            //catch (Exception ex)
            //{

            //    throw new Exception("Ocorreu um erro inesperado. Detalhes: " + ex.Message, ex);
            //}

        }

        //private bool VerificarSeEmailExiste(UsuarioModel usuarioModel) 
        //{
        //    var usuario = _bancoContexto.Usuario.FirstOrDefault(x => x.Email == usuarioModel.Email);

        //    if (usuario == null)
            
        //        return false;
        //    return true;
            
        //}



    }
}
