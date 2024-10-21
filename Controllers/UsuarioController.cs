using ControleFinanceiro.Data.Repositorio.Interfaces;
using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuariorepositorio;

        public UsuarioController(IUsuarioRepositorio usuariorepositorio)
        {
            _usuariorepositorio = usuariorepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Cadastrar(UsuarioModel usuarioModel)
        {
            try
            {
                _usuariorepositorio.Cadastrar(usuarioModel);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }



        public IActionResult ValidarLogin(string email, string senha)
        {
            //// Validação dos campos
            //if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            //{
            //    ModelState.AddModelError("", "Email e senha são obrigatórios.");
            //    return View("Login"); // Retorna à view de login em caso de erro
            //}


            var usuario = _usuariorepositorio.Login(email, senha);
            if (usuario != null)
            {

                return RedirectToAction("Index", "Despesas");
            }
            else
            {
                ModelState.AddModelError("", "Email ou senha inválidos.");
                return View("Index");
            }
        }


    }
}
