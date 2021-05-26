using ME.Pedidos.MediadorEventos.Commands;
using ME.Pedidos.MediadorEventos.Notifications;
using ME.Pedidos.Domain.Models;
using ME.Pedidos.Domain.Interfaces.IRepository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using ME.Pedidos.Domain.Models.PedidoStatus;

namespace ME.Pedidos.MediadorEventos.DTO.Handlers
{
    /// <summary>
    /// Controlador responsavel pela logica da mudanca dos status do pedido
    /// </summary>
    public class PedidoStatusChangeCommandHandler : IRequestHandler<PedidoStatusChangeCommand, string>
    {
        private readonly IMediator mediator;

        public PedidoStatusChangeCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<string> Handle(PedidoStatusChangeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await mediator.Publish(new PedidoStatusChangeNotification { PedidoStatusChangeDTO = request.PedidoStatusChangeDTO });
                
                return await Task.FromResult("Pedido criado com sucesso");
            }
            catch (Exception ex)
            {
                await mediator.Publish(new PedidoStatusChangeNotification { PedidoStatusChangeDTO = request.PedidoStatusChangeDTO });
                await mediator.Publish(new ErroNotification { Erro = ex.Message, PilhaErro = ex.StackTrace });
                return await Task.FromResult("Ocorreu um erro no momento da mudanca do status do pedido");
            }
        }
    }
}