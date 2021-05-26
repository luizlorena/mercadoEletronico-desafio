using ME.Pedidos.Domain.Models.Pedido;
using ME.Pedidos.Domain.Models.PedidoStatus;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Interfaces.IPedidoStatus
{
    /// <summary>
    /// Interface de Mudança de Status do Pedido
    /// </summary>
    public interface IPedidoChangeStatusService
    {
        PedidoStatusValidateResult ValidarStatus(PedidoChangeStatusModel pedidoStatusModel, EnumTipoValidacao enumTipoValidacao, PedidoModel currentPedidoModel);
    }
}
