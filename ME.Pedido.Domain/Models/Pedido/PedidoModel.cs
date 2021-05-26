using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Models.Pedido
{
    public class PedidoModel
    {
        public PedidoModel()
        {

        }

        public PedidoModel(string codigoPedido)
        {
            Itens = new List<PedidoItemModel>();
            this.CodigoPedido = codigoPedido;
        }


        public string CodigoPedido { get; private set; }
        public ICollection<PedidoItemModel> Itens { get; private set; }
    }
}
