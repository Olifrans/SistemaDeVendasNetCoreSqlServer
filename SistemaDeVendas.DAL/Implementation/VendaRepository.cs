
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
		private readonly VendasnetcoreContext _context;

		public VendaRepository(VendasnetcoreContext context)
		{
			_context = context;
		}



		public async Task<Venda> Registrar(Venda entity)
		{
			Venda vendaRealizada = new Venda();

			using (var transaction = _context.Database.BeginTransaction())
			{
				try
				{
					foreach (DetalheVenda detalhe in entity.DetalheVenda)
					{
						Produto produto = _context.Produtos.Where(p => p.IdProduto == detalhe.IdProduto).First();

						produto.Stock = produto.Stock - detalhe.Quantidade;
						_context.Produtos.Update(produto);
					}
					await _context.SaveChangesAsync();


					NumeroCorrelativo correlativo = _context.NumeroCorrelativos.Where(p => p.Gerenciamento == "venda").First();


				}
				catch (Exception ex)
				{
					transaction.Rollback();
					throw ex;
				}
			}
		}

		public async Task<List<Venda>> Relatorio(DateTime Inicio, DateTime Fim)
		{
			Venda vendaRealizada = new Venda();

			using (var transaction = _context.Database.BeginTransaction())
			{
				try
				{
                    foreach (DetalheVenda detalhe = new DetalheVenda)
                    {
                     
						
                    }

                }
				catch (Exception ex)
				{
					transaction.Rollback();
					throw ex;
				}
			}
		}


		//public async Task<bool> Update(TEntity entity)
		//{
		//	try
		//	{
		//		_context.Update(entity);
		//		//_context.Set<TEntity>().Update(entity);
		//		await _context.SaveChangesAsync();
		//		return true;
		//	}
		//	catch (Exception)
		//	{
		//		throw;
		//	}
		//}

		//public async Task<bool> Delete(TEntity entity)
		//{
		//	try
		//	{
		//		_context.Remove(entity);
		//		//_context.Set<TEntity>().Update(entity);
		//		await _context.SaveChangesAsync();
		//		return true;
		//	}
		//	catch (Exception)
		//	{
		//		throw;
		//	}
		//}

		//public async Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filtro = null)
		//{
		//	IQueryable<TEntity> queryEntity = filtro == null ? _context.Set<TEntity>() : _context.Set<TEntity>().Where(filtro);

		//	return queryEntity;
		//}
	}
}
