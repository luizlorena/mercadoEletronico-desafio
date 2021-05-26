
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;

namespace ME.Pedidos.Domain.Models.PedidoStatus
{
    public class PedidoChangeStatusModel
    {
      public EnumPedidoStatus PedidoStatus { get; set; }
      public int? ItensAprovados { get; set; }
      public decimal? ValorAprovado { get; set; }
      public string Pedido { get; set; }
    }

}
