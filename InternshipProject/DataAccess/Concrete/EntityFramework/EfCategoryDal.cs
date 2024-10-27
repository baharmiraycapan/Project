using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : ICategoryDal
{
    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }

    public Category Get(Expression<Func<Category, bool>> filter = null)
    {
        using (NorthwindContext context = new NorthwindContext()){
            return context.Set<Category>().SingleOrDefault(filter);
        }
    }

    public List<Category> GetAll(Expression<Func<Category, bool>> filter=null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null
            ? context.Set<Category>().ToList() 
            : context.Set<Category>().Where(filter).ToList();
        }
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }
}
