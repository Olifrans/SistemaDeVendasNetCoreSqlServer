
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDeVendas.DAL.DBContext;
using SistemaDeVendas.DAL.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;



namespace SistemaDeVendas.DAL.Implementation
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private readonly VendasnetcoreContext _context;

		public GenericRepository(VendasnetcoreContext context)
		{
			_context = context;
		}


		public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filtro)
		{
			try
			{
				TEntity entity = await _context.Set<TEntity>().FirstOrDefaultAsync(filtro);
				return entity;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<TEntity> Create(TEntity entity)
		{
			try
			{
				_context.Set<TEntity>().Add(entity);
				await _context.SaveChangesAsync();
				return entity;
			}
			catch (Exception)
			{
				throw;
			}
		}


		public async Task<bool> Update(TEntity entity)
		{
			try
			{
				_context.Update(entity);
				//_context.Set<TEntity>().Update(entity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<bool> Delete(TEntity entity)
		{
			try
			{
				_context.Remove(entity);
				//_context.Set<TEntity>().Update(entity);
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filtro = null)
		{
			IQueryable<TEntity> queryEntity = filtro == null ? _context.Set<TEntity>() : _context.Set<TEntity>().Where(filtro);

			return queryEntity;
		}
	}
}
