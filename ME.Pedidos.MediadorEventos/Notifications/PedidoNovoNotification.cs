using ME.Pedidos.MediadorEventos.DTO;
using MediatR;


namespace ME.Pedidos.MediadorEventos.Notifications
{
    public class PedidoNovoNotification : INotification
    {
        public PedidoDTO PedidoDTO {get; set;}
    }
}