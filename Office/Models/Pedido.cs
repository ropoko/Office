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
        public DateTime DataPedido { get; set; }

        [Display(Name = "Usuário")]
        [Required]
        [Column("IDCliente")]
        public int IDCliente { get; set; }
        public Usuario Usuario { get; set; }

        [Display(Name = "Data da Busca")]
        [Required]
        public DateTime DataBusca { get; set; }
    }
}
