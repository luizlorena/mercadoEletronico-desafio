using ME.Pedidos.Domain.Models.Pedido;
using Microsoft.EntityFrameworkCore;
using System;

namespace ME.Pedidos.Infra.Contexts
{
    public class PedidoDBContexto : DbContext
    {
        public PedidoDBContexto(DbContextOptions<PedidoDBContexto> options) : base(options)
        {

        }

        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<PedidoItemModel> PedidoItens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

}