using ME.Pedidos.MediadorEventos.Commands;
using ME.Pedidos.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;


namespace ME.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(IMediator mediator, IPedidoRepository pedidoRepository)
        {
            _mediator = mediator;
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _pedidoRepository.GetByCodigoPedido(id));
        }

        [HttpPost]
        [Route("Pedido/SalvarPedido")]
        public async Task<IActionResult> Post([FromBody] PedidoNovoCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
