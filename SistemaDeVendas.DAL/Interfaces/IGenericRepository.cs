using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SistemaDeVendas.DAL.Interfaces
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		Task<TEntity> Get(Expression<Func<TEntity, bool>> filtro);
		Task<TEntity> Create(TEntity entity);
		Task<bool> Update(TEntity entity);
		Task<bool> Delete(TEntity entity);
		Task<IQueryable> GetAll(Expression<Func<TEntity, bool>> filtro = null);
	}
}
