using ME.Pedidos.MediadorEventos.DTO;
using MediatR;


namespace ME.Pedidos.MediadorEventos.Notifications
{
    public class PedidoStatusChangeNotification : INotification
    {
        public PedidoStatusChangeDTO PedidoStatusChangeDTO {get; set;}
    }
}