using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using SistemaDeVendas.Entity;

namespace SistemaDeVendas.DAL.Interfaces
{
	public interface IVendaRepository : IGenericRepository<Venda>
	{
		Task<Venda> Registrar(Venda entity);
		Task<List<Venda>> Relatorio(DateTime Inicio, DateTime Fim);

	}
}
