using MediatR;

namespace ME.Pedidos.MediadorEventos.Commands
{
    public class PedidoStatusChangeCommand : IRequest<string>
    {
        public DTO.PedidoStatusChangeDTO PedidoStatusChangeDTO { get; private set; }
    }


}
