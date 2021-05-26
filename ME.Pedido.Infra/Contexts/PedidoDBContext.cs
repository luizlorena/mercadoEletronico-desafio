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

        public DbSet<Domain.Model.PedidoModel> Pedidos { get; set; }
        public DbSet<Domain.Model.PedidoItemModel> PedidoItens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }

}