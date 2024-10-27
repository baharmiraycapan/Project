using DataAccess.Abstract;
using Entities.Concrete;
//using System.Linq;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{
    List<Product> _products; //Global bir değişken
    public InMemoryProductDal()
    {
        _products = new List<Product>{  //On heap
            new Product{CategoryId = 1, ProductId = 1, ProductName = "Bardak", UnitPrice = 150, UnitsInStock = 15},
            new Product{CategoryId = 1, ProductId = 2, ProductName = "Tabak", UnitPrice = 300, UnitsInStock = 4},
            new Product{CategoryId = 2, ProductId = 3, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
            new Product{CategoryId = 2, ProductId = 4, ProductName = "Klavye", UnitPrice = 700, UnitsInStock = 7},
            new Product{CategoryId = 2, ProductId = 5, ProductName = "Mouse", UnitPrice = 500, UnitsInStock = 15}
        };

    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DeleteProduct(Product product)
    {
        //LINQ yani language integrated query kullanarak product listesinden productı bulduk
        _products.Remove(_products.SingleOrDefault(p => p.ProductId == product.ProductId));
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

    public void UpdateProduct(Product product)
    {
        Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        productToUpdate.ProductId = product.ProductId;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.UnitsInStock = product.UnitsInStock;
        productToUpdate.UnitPrice = product.UnitPrice;
    }
}
