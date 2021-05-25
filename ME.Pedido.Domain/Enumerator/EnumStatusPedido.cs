using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Pedidos.Domain.Enumerator
{
	public enum EnumStatusPedido
	{
		[Description("APROVADO")]
		Aprovado = 0,

		[Description("APROVADO_VALOR_A_MENOR")]
		AprovadoValorAMenor = 1,

		[Description("APROVADO_VALOR_A_MAIOR")]
		AprovadoValorAMaior = 3,

		[Description("APROVADO_QTD_A_MAIOR")]
		AprovadoQuantidadeAMaior = 4,

		[Description("REPROVADO")]
		Reprovado = -1,

		[Description("CODIGO_PEDIDO_INVALIDO")]
		CodigoPedidoInvalido = -2,

		[Description("APROVADO_QTD_A_MENOR")]
		AprovadoQuantidadeAMenor = -3
	}
}
