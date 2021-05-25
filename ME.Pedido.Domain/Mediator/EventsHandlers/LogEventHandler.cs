using ME.Pedidos.Domain.Mediator.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace ME.Pedidos.Domain.Mediator.EventsHandlers
{
    public class LogEventHandler :
                            INotificationHandler<PedidoNovoNotification>,
                            INotificationHandler<ErroNotification>
    {
        public Task Handle(PedidoNovoNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                //Console.WriteLine($"NOVO PEDIDO: '{notification.PedidoDTO.D} " +
                //    $"- {notification.Nome} - {notification.Preco}'");
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
