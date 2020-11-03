using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IDPedido { get; set; }

        [Display(Name = "Data do Pedido")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Usuário")]
        [Required]
        [Column("IDCliente")]
        public string IDCliente { get; set; }
        public Usuario Usuario { get; set; }

        [Display(Name = "Data da Busca")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataBusca { get; set; }
    }
}
