using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int IDProduto { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Valor(R$)")]
        [Required]
        public decimal Valor { get; set; }

        [Display(Name = "Marca")]
        [Required]
        public string Marca { get; set; }

        [Display(Name = "Categoria")]
        [Required]
        public int Categoria { get; set; }
        public Categoria Categorias { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }
    }
}
