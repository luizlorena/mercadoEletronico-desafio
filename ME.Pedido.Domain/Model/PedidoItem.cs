using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Model
{
    public class PedidoItem //: Entity
    {
        public PedidoItem()
        {
        }

        public PedidoItem(string descricao, decimal precoUnitario, int qtd, string codigoPedido)
        {
            this.Descricao = descricao;
            this.PrecoUnitario = precoUnitario;
            this.Qtd = qtd;
            this.CodigoPedido = codigoPedido;
        }

        public string Descricao { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public int Qtd { get; private set; }
        public string CodigoPedido { get; private set; }
        public virtual int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
