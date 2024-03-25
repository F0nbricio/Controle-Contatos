using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do seu contato")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o e-mail do seu contato")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set;}
        
        [Required(ErrorMessage = "Digite o celular do seu contato")]
        [Phone(ErrorMessage = "O celular informado não é valido!")]
        public string Celular { get; set;}
    
        public int? UsuarioId { get; set; }
        
        public UsuarioModel Usuario { get; set; }
    }
}
