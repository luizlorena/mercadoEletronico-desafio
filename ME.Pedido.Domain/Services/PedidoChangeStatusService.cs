using ME.Pedidos.Domain.Interfaces.IPedidoStatus;
using ME.Pedidos.Domain.Models.Pedido;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;



namespace ME.Pedidos.Domain.Models.PedidoStatus.Validate
{
    /// <summary>
    /// Servico de Mudanca de Status do Pedido
    /// </summary>
    public class PedidoChangeStatusService : IPedidoChangeStatusService 
    {
        private IPedidoChangeStatusValidate PedidoChangeStatusValidate;

        public PedidoChangeStatusService(IPedidoChangeStatusValidate pedidoChangeStatusValidate)
        {
            PedidoChangeStatusValidate = pedidoChangeStatusValidate;
        }

        public void PedidoChangeStatus(PedidoChangeStatusModel pedidoChangeStatusModel)
        {


        }
    }

}
