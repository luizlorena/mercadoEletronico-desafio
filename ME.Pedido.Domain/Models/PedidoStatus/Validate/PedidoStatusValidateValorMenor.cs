using ME.Pedidos.Domain.Interfaces.IPedidoStatus;
using ME.Pedidos.Domain.Models.Pedido;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;
using System.Linq;

namespace ME.Pedidos.Domain.Models.PedidoStatus.Validate
{
    /// <summary>
    /// Implementacao da Regra de Validacao Valor à Menor
    /// </summary>
    public class PedidoStatusValidateValorMenor : BasePedidoStatusValidate, IPedidoChangeStatusValidate 
    {

        public PedidoStatusValidateValorMenor(IPedidoChangeStatusValidate proximaValidacao)
            :base(proximaValidacao)
        { 
            base.enumTipoValidacao = EnumTipoValidacao.ValidarQuantidadeAMenor;
        }

        public PedidoStatusValidateResult ValidarStatus(PedidoChangeStatusModel pedidoChangeStatusModel, EnumTipoValidacao enumTipoValidacao, PedidoModel currentPedidoModel)
        {
            if (enumTipoValidacao != this.enumTipoValidacao)
                return ProximaValidacao.ValidarStatus(pedidoChangeStatusModel, enumTipoValidacao, currentPedidoModel);


            if (pedidoChangeStatusModel.ValorAprovado < currentPedidoModel.Itens.Sum(x=> x.Qtd * x.PrecoUnitario))
            {
                return new PedidoStatusValidateResult
                {
                    CodigoPedido = currentPedidoModel.CodigoPedido,
                    EnumPedidoStatus = EnumPedidoStatus.AprovadoValorAMenor
                };
            }

            return null;
        }
    }

}
