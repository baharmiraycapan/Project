using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract;

public interface IEntityRepository<T> where T : class, IEntity, new() //referans tip
{
    //LINQ
    List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre vermeyip bütün entitiyler de istenebilir
    T Get(Expression<Func<T,bool>> filter = null);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);

}
