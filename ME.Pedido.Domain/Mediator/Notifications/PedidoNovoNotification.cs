using ME.Pedidos.Domain.Mediator.DTO;
using MediatR;


namespace ME.Pedidos.Domain.Mediator.Notifications
{
    public class PedidoNovoNotification : INotification
    {
        public PedidoDTO PedidoDTO {get; set;}
    }
}