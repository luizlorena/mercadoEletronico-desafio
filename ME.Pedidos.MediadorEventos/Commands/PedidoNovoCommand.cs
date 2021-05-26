using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ME.Pedidos.MediadorEventos.Commands
{
    public class PedidoNovoCommand : IRequest<string>
    {
        public DTO.PedidoDTO PedidoDTO { get; private set; }
        public ICollection<DTO.PedidoItemDTO> Itens { get; private set; }
    }


}
