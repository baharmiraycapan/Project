using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductService : IProductService
{
    IProductDal _productDal;

    public ProductService(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        //iş kodları
        InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
    }

    public List<Product> GetAllByCategoryId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetByUnitPrice(decimal min, decimal max)
    {
        throw new NotImplementedException();
    }
}
