using ME.Pedidos.MediadorEventos.Commands;
using ME.Pedidos.Domain.Mediator.Notifications;
using ME.Pedidos.Domain.Model;
using ME.Pedidos.Domain.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ME.Pedidos.MediadorEventos.DTO.Handlers
{
    /// <summary>
    /// Controlador responsavel pela logica dos novos pedidos
    /// </summary>
    public class PedidoNovoCommandHandler : IRequestHandler<PedidoNovoCommand, string>
    {
        private readonly IMediator mediator;
        private readonly IPedidoRepository  pedidoRepository;

        public PedidoNovoCommandHandler(IMediator mediator, IPedidoRepository pedidoRepository)
        {
            this.mediator = mediator;
            this.pedidoRepository = pedidoRepository;
        }

        public async Task<string> Handle(PedidoNovoCommand request, CancellationToken cancellationToken)
        {
            var pedido = new PedidoModel(request.PedidoDTO.CodigoPedido);

            try
            {
                await pedidoRepository.Save(pedido);
                
                await mediator.Publish(new PedidoNovoNotification { PedidoDTO = request.PedidoDTO });
                
                return await Task.FromResult("Pedido criado com sucesso");
            }
            catch (Exception ex)
            {
                await mediator.Publish(new PedidoNovoNotification { PedidoDTO = request.PedidoDTO });
                await mediator.Publish(new ErroNotification { Erro = ex.Message, PilhaErro = ex.StackTrace });
                return await Task.FromResult("Ocorreu um erro no momento da criação");
            }
        }
    }
}