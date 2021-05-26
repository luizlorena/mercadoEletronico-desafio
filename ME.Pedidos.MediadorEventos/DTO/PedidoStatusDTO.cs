using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.MediadorEventos.DTO
{
    public class PedidoStatusChangeDTO
    {
        public string PedidoStatus { get; }
        public int? ItensAprovados { get; }
        public decimal? ValorAprovado { get; }
        public string Pedido { get; }
    }

}
