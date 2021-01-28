using System.ComponentModel.DataAnnotations;

namespace curso.web.mvc.Models.Usuarios
{
    public class RegistrarUsuarioViewModelInput
    {
        [Required(ErrorMessage ="O login � obrigat�rio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O e-mail � obrigat�rio")]
        [EmailAddress(ErrorMessage ="O e-mail � inv�lido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha � obrigat�ria")]
        public string Senha { get; set; }
    }
}