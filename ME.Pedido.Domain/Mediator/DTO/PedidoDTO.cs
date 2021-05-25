using System.Collections.Generic;

namespace ME.Pedidos.Domain.Mediator.DTO
{
    public class PedidoDTO
    {
        public string CodigoPedido { get; private set; }
        public ICollection<PedidoItemDTO> Itens { get; private set; }
    }

}
