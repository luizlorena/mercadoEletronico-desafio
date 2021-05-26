using ME.Pedidos.Domain.Interfaces.IRepository;
using ME.Pedidos.Domain.Models.Pedido;
using System.Linq;
using System.Threading.Tasks;
using ME.Pedidos.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ME.Pedidos.Infra.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly PedidoDBContexto pedidoDBContexto;

        public PedidoRepository(PedidoDBContexto pedidoDBContexto)

        {
            this.pedidoDBContexto = pedidoDBContexto;
        }

        public async Task<PedidoModel> GetByCodigoPedido(string codigoPedido)
        {
            return await pedidoDBContexto
                .Pedidos
                .Include("Itens")
                .AsNoTracking()
                .Where(x => x.CodigoPedido == codigoPedido)
                .FirstOrDefaultAsync();
        }

        public async Task Save(PedidoModel pedido)
        {
            await pedidoDBContexto.Pedidos.AddAsync(pedido);
        }

        public void Update(PedidoModel pedido)
        {
            pedidoDBContexto.Entry(pedido).State = EntityState.Modified;
        }
    }
}
