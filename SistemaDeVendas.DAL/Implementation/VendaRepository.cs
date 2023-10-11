
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDeVendas.DAL.DBContext;
using SistemaDeVendas.DAL.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Entity;

namespace SistemaDeVendas.DAL.Implementation
{
	public class VendaRepository : GenericRepository<Venda>, IVendaRepository
	{
		private readonly VendasnetcoreContext _contextDb;

		public VendaRepository(VendasnetcoreContext context) : base(context)
		{
			_contextDb = context;
		}


		public async Task<Venda> Registrar(Venda entity)
		{
			Venda vendaRealizada = new Venda();

			using (var transaction = _contextDb.Database.BeginTransaction())
			{
				try
				{
					foreach (DetalheVenda detalhe in entity.DetalheVenda)
					{
						Produto get_produto = _contextDb.Produtos.Where(p => p.IdProduto == detalhe.IdProduto).First();

						get_produto.Stock = get_produto.Stock - detalhe.Quantidade;
						_contextDb.Produtos.Update(get_produto);
					}
					await _contextDb.SaveChangesAsync();


					NumeroCorrelativo correlativo = _contextDb.NumeroCorrelativos.Where(p => p.Gerenciamento == "venda").First();

					correlativo.UltimoNumero = correlativo.UltimoNumero + 1;
					correlativo.FechaActualizacion = DateTime.Now;
					;
					_contextDb.NumeroCorrelativos.Update(correlativo);
					await _contextDb.SaveChangesAsync();


					string zeros = string.Concat(Enumerable.Repeat("0", correlativo.QuantidadeDigitos.Value));
					string numeroVendas = zeros + correlativo.UltimoNumero.ToString();
					numeroVendas = numeroVendas.Substring(numeroVendas.Length - correlativo.QuantidadeDigitos.Value, correlativo.QuantidadeDigitos.Value);

					entity.NumeroVenda = numeroVendas;

					await _contextDb.Venda.AddAsync(entity);
					await _contextDb.SaveChangesAsync();

					vendaRealizada = entity;

					transaction.Commit();
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					throw ex;
				}
			}
			return vendaRealizada;
		}

		public async Task<List<DetalheVenda>> Relatorio(DateTime Inicio, DateTime Fim)
		{
			List<DetalheVenda> relatorioResumido = await _contextDb.DetalheVenda
				.Include(v => v.IdVendaNavigation)
				.ThenInclude(u => u.IdUsuario)
				.Include(v => v.IdVendaNavigation)
				.ThenInclude(dtv => dtv.IdTipoDocumentoVendaNavigation)
				.Where(dv => dv.IdVendaNavigation.FechaRegistro.Value.Date >= Inicio.Date &&
					dv.IdVendaNavigation.FechaRegistro.Value.Date <= Fim.Date).ToListAsync();

			return relatorioResumido;
		}
	}
}
