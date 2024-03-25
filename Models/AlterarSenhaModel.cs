using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a senha atual do usuário!")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Digite a nova senha do usuário!")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a nova senha do usuário!")]
        [Compare("NovaSenha", ErrorMessage = "A senha não confere com a nova senha!")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
