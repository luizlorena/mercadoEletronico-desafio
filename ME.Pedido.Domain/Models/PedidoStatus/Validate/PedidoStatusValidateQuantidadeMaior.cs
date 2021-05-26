using ME.Pedidos.Domain.Interfaces.IPedidoStatus;
using ME.Pedidos.Domain.Models.Pedido;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;



namespace ME.Pedidos.Domain.Models.PedidoStatus.Validate
{
    /// <summary>
    /// Implementacao da Regra de Validadacao QuantidadeMaior
    /// </summary>
    public class PedidoStatusValidateQuantidadeMaior : BasePedidoStatusValidate, IPedidoChangeStatusValidate 
    {

        public PedidoStatusValidateQuantidadeMaior(IPedidoChangeStatusValidate proximaValidacao)
            :base(proximaValidacao)
        { 
            base.enumTipoValidacao = EnumTipoValidacao.ValidarQuantidadeAMaior;
        }

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
