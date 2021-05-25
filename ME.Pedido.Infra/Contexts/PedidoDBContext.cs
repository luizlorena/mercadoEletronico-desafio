using ME.Pedidos.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace ME.Pedidos.Infra.Contexts
{
    public class PedidoDBContexto : DbContext
    {
        public PedidoDBContexto(DbContextOptions<PedidoDBContexto> options) : base(options)
        {

        }

        public DbSet<Domain.Model.Pedido> Pedidos { get; set; }
        public DbSet<Domain.Model.PedidoItem> PedidoItens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

}