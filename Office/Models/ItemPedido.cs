using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    [Table("Item_Pedido")]
    public class ItemPedido
    {
        [Key]
        public int IDItemPedido { get; set; }

        [Display(Name = "Produto")]
        [Required]
        public int IDProduto { get; set; }
        public Produto Produto { get; set; }

        [Display(Name = "Pedido")]
        [Required]
        public int IDPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}
