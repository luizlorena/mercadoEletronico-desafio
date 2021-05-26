using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.MediadorEventos.DTO
{
    public class PedidoStatusResultDTO
    {
        public string CodigoPedido { get; private set; }

        public List<PedidoStatus> ListPedidoStatus { get; set; }

        public class PedidoStatus
        {
            public string StatusPedido { get; set; }
        }
    }


}
