using System.ComponentModel.DataAnnotations;

namespace ControleFinanceiro.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite seu nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite seu e-mail!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Cadastre uma senha!")]
        public string Senha { get; set; }
        //[Required(ErrorMessage = "Digite a confirmação de senha!")]
        //public string ConfirmaSenha { get; set; }
    }
}

//CREATE DATABASE ControleFinanceiro
//USE ControleFinanceiro
//CREATE TABLE Usuario (
//Id INT IDENTITY(1,1) NOT NULL,
//Nome VARCHAR(40) NOT NULL,
//Email Varchar(40) NOT NULL,
//Senha VARCHAR(40)  NULL,
//PRIMARY KEY(Id)
//)
