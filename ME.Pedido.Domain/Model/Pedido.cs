using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Model
{
    public class Pedido
    {
        public Pedido()
        {

        }

        public Pedido(string codigoPedido)
        {
            Itens = new List<PedidoItem>();
            this.CodigoPedido = codigoPedido;
        }


        public string CodigoPedido { get; private set; }
        public ICollection<PedidoItem> Itens { get; private set; }
    }
}
