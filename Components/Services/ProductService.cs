using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;

public partial class ProductService : IRepository<Product>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<Product> repository;

    public ProductService(AutoRepairDataContext ctx)
    {
        context = ctx;
        repository = new Repository<Product>(context);
    }
    public void Add(Product product)
    {
        repository.Add(product);
    }

    public void Delete(Product product)
    {
        repository.Delete(product);
    }

    public IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
       var products =  repository.GetAll();
       return products; 
    }

    public Product GetById(int id)
    {
        var product = repository.GetById(id);
        return product;
    }

    public void Update(Product product)
    {
        repository.Update(product);
    }
}