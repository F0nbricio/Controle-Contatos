using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o seu login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite a seu e-mail!")]
        public string Email { get; set; }
    }
}
