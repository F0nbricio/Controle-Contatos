using ControleContatos.Enuns;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do seu usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do seu usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do seu usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Selecione o tipo de perfil do seu usuário")]
        public PerfilEnum? Perfil { get; set; }
    }
}