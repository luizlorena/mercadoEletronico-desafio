using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;
using System.Collections.Generic;

namespace ME.Pedidos.Domain.Models.PedidoStatus
{
    public class PedidoStatusValidateResult 
    {
        public string CodigoPedido { get; set; }
        public EnumPedidoStatus EnumPedidoStatus { get; set; }
        public List<string> Mensagens { get; set; } = new List<string>(); 
    }

}
