using System.Linq.Expressions;

namespace Para.Data.GenericRepository;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task Save();
    Task<TEntity?> GetById(long Id);
    Task Insert(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
    Task Delete(long Id);
    Task<List<TEntity>> GetAll();
    Task<List<TEntity>> GetWithFilter(Expression<Func<TEntity, bool>> filter);
    Task<List<TEntity>> GetWithIncludesAndFilter(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);
}