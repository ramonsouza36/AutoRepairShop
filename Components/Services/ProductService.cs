using System.Linq.Expressions;

public partial class ProductService : IRepository<Product>
{
    public void Add(Product product)
    {
        Add(product);
    }

    public void Delete(Product product)
    {
        Delete(product);
    }

    public IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
       var products =  GetAll();
       return products; 
    }

    public Product GetById(int id)
    {
        var product = GetById(id);
        return product;
    }

    public void Update(Product product)
    {
        Update(product);
    }
}