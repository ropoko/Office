namespace Office.Models
{
    public class PedidoViewModel
    {
        public Usuario Cliente { get; set; }

        public Pedido Pedido { get; set; }

        public ItemPedido ItemPedido { get; set; }

        public Produto Produto { get; set; }
    }
}
