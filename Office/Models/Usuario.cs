using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    [Table("Usuario")]
    public class Usuario : IdentityUser
    {
        [Display(Name = "Nome Completo")]
        [Required]
        [Column("Nome")]
        public string Nome { get; set; }

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

        [NotMapped]
        [Display(Name = "Perfil")]
        public string Perfis { get; set; }
    }
}
