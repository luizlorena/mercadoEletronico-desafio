using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.MediadorEventos.DTO
{
    public class PedidoStatusDTO
    {
        public string CodigoPedido { get; private set; }

        public List<string> StatusPedido { get; private set; }
    }

    public class StatusDTO
    {
        public string CodigoPedido { get; private set; }

        public List<string> StatusPedido { get; private set; }
    }

}
