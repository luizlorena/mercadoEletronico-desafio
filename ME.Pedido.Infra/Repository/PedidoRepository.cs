using ME.Pedidos.Domain.Repository;
using ME.Pedidos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Infra.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        //private readonly MercadoEletronicoContext context;
        private readonly dynamic context;


        //public PedidoRepository(MercadoEletronicoContext context)
        public PedidoRepository(dynamic context)

        {
            this.context = context;
        }

        public async Task<ICollection<Domain.Model.Pedido>> GetAll()
        {
            return null;
            //return await context
            //    .Pedidos
            //    .Include("Itens")
            //    .AsNoTracking()
            //    .OrderBy(x => x.CodigoPedido)
            //    .ToListAsync();
        }

        public async Task<Domain.Model.Pedido> GetByCodigoPedido(string codigoPedido)
        {
            return null;
            //return await context
            //    .Pedidos
            //    .Include("Itens")
            //    .AsNoTracking()
            //    .Where(x => x.CodigoPedido == codigoPedido)
            //    .FirstOrDefaultAsync();
        }

        public async Task Save(Domain.Model.Pedido pedido)
        {
            //await context.Pedidos.AddAsync(pedido);
        }

        public void Update(Domain.Model.Pedido pedido)
        {
            //context.Entry(pedido).State = EntityState.Modified;
        }
    }
}
