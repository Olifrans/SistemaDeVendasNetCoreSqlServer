using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.BLL.Interfaces
{
	public interface IEmailServico
	{
		Task<bool>EnviarEmail(string EmailDestino, string Assunto, string Mensagem);
	}
}
