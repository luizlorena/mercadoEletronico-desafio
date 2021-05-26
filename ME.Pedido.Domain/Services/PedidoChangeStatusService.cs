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

        public PedidoStatusValidateResult ValidarStatus(PedidoChangeStatusModel pedidoChangeStatusModel, EnumTipoValidacao enumTipoValidacao, PedidoModel currentPedidoModel)
        {
            if (enumTipoValidacao != this.enumTipoValidacao)
                return ProximaValidacao.ValidarStatus(pedidoChangeStatusModel, enumTipoValidacao, currentPedidoModel);


            if (pedidoChangeStatusModel.ItensAprovados > currentPedidoModel.Itens.Count)
            {
                return new PedidoStatusValidateResult
                {
                    CodigoPedido = currentPedidoModel.CodigoPedido,
                    EnumPedidoStatus = EnumPedidoStatus.AprovadoQuantidadeAMaior
                };
            }

            return null;
        }
    }

}
