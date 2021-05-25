using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ME.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoStatusController : ControllerBase
    {

        private readonly ILogger<PedidoStatusController> _logger;

        public PedidoStatusController(ILogger<PedidoStatusController> logger)
        {
            _logger = logger;
        }

    }
}
