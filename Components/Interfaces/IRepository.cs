using System.Linq.Expressions;

namespace AutoRepairShop.Components.Interfaces;
public interface IRepository<TEntity> where TEntity : class
{
    Task Add(TEntity entity);
    void Update(TEntity entity);
    Task DeleteAsync(TEntity entity);
    TEntity GetById(Guid id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
}
