using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int IDCategoria { get; set; }

        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }
    }
}
