using ME.Pedidos.Domain.Interfaces.IPedidoStatus;
using ME.Pedidos.Domain.Models.Pedido;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;
using System.Linq;

namespace ME.Pedidos.Domain.Models.PedidoStatus.Validate
{
    /// <summary>
    /// Implementacao da Regra de Validacao Valor à Maior
    /// </summary>
    public class PedidoStatusValidateValorMaior : BasePedidoStatusValidate, IPedidoChangeStatusValidate 
    {

        public PedidoStatusValidateValorMaior(IPedidoChangeStatusValidate proximaValidacao)
            :base(proximaValidacao)
        { 
            base.enumTipoValidacao = EnumTipoValidacao.ValidarValorAMaior;
        }

        public PedidoStatusValidateResult ValidarStatus(PedidoChangeStatusModel pedidoChangeStatusModel, EnumTipoValidacao enumTipoValidacao, PedidoModel currentPedidoModel)
        {
            if (enumTipoValidacao != this.enumTipoValidacao)
                return ProximaValidacao.ValidarStatus(pedidoChangeStatusModel, enumTipoValidacao, currentPedidoModel);


            if (pedidoChangeStatusModel.ValorAprovado > currentPedidoModel.Itens.Sum(x=> x.Qtd * x.PrecoUnitario))
            {
                return new PedidoStatusValidateResult
                {
                    CodigoPedido = currentPedidoModel.CodigoPedido,
                    EnumPedidoStatus = EnumPedidoStatus.AprovadoValorAMaior
                };
            }

            return null;
        }
    }

}
