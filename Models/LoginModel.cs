using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o seu login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite a sua senha!")]
        public string Senha { get; set; }
    }
}
