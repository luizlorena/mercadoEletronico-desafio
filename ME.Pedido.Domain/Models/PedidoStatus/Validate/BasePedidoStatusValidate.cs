using ME.Pedidos.Domain.Interfaces.IPedidoStatus;
using ME.Pedidos.Domain.Models.PedidoStatus.Enumerator;


namespace ME.Pedidos.Domain.Models.PedidoStatus.Validate
{
    public class BasePedidoStatusValidate
    {
        protected EnumTipoValidacao enumTipoValidacao;
        protected IPedidoChangeStatusValidate ProximaValidacao;


        public BasePedidoStatusValidate(IPedidoChangeStatusValidate proximaValidacao) 
            => ProximaValidacao = proximaValidacao;
    }

}
