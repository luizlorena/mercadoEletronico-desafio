using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Pedidos.Domain.Model;


namespace ME.Pedidos.Domain.Repository
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetByCodigoPedido(string codigoPedido);
        Task<ICollection<Pedido>> GetAll();
        Task Save(Pedido pedido);
        void Update(Pedido pedido);
    }
}
