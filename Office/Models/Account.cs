using System.ComponentModel.DataAnnotations;

namespace Office.Models
{
    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }

    public class UserRegistrationModel
    {
        [Required(ErrorMessage = "Informe o nome de usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário uma senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "As senhas não coincidem!")]
        public string ConfirmPassword { get; set; }
    }
}
