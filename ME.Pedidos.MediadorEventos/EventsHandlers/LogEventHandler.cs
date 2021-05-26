using ME.Pedidos.Domain.Mediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace ME.Pedidos.MediadorEventos.DTO.EventsHandlers
{
    public class LogEventHandler :
                            INotificationHandler<PedidoNovoNotification>,
                            INotificationHandler<ErroNotification>
    {
        public Task Handle(PedidoNovoNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
            });
        }
        public Task Handle(ErroNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"ERRO: '{notification.Erro} \n {notification.PilhaErro}'");
            });
        }
    }
}
