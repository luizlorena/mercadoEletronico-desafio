using System.Collections.Generic;

namespace ME.Pedidos.MediadorEventos.DTO
{
    public class PedidoDTO
    {
        public string CodigoPedido { get; private set; }
        public ICollection<PedidoItemDTO> Itens { get; private set; }
    }

}
