using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    public class UserLoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Incorreta!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
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
        [StringLength(50, ErrorMessage = "Senha muito curta!", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coincidem!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Perfil de Acesso")]
        public string Perfis { get; set; }

        [Display(Name = "Cidade")]
        [Required]
        [Column("Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required]
        [Column("DataNascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CPF")]
        [Required]
        [Column("Cpf")]
        public string Cpf { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

        [Required]
        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
