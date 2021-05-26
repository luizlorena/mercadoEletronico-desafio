using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Models.PedidoStatus.Enumerator
{
	/// <summary>
	/// Tipos de Validacao para Status do Pedido
	/// </summary>
	public enum EnumTipoValidacao
	{
		ValidarCodigoPedido = 0,

		ValidarValorAMenor = 1,

		ValidarValorAMaior = 2,

		ValidarQuantidadeAMaior = 3,

		ValidarQuantidadeAMenor = 4
	}
}
