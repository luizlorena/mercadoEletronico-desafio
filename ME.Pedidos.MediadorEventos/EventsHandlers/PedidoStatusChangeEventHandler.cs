using ME.Pedidos.MediadorEventos.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace ME.Pedidos.MediadorEventos.DTO.EventsHandlers
{
    public class PedidoStatusChangeEventHandler : INotificationHandler<PedidoStatusChangeNotification>
    {

        public PedidoStatusChangeEventHandler(IServiceProvider serviceProvider)
        { 
        }

        public Task Handle(PedidoStatusChangeNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
