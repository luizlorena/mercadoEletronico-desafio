using ME.Pedidos.Domain.Models.Pedido;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Interfaces.IRepository
{
    /// <summary>
    /// Interface repositorio de persistencia
    /// </summary>
    public interface IPedidoRepository
    {
        Task<PedidoModel> GetByCodigoPedido(string codigoPedido);
        Task Save(PedidoModel pedido);
        void Update(PedidoModel pedido);
    }
}
