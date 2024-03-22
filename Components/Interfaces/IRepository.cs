using System.Linq.Expressions;

namespace AutoRepairShop.Components.Interfaces;
public interface IRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    TEntity GetById(int id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
}
