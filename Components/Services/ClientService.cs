using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;

namespace AutoRepairShop.Components.Services;
public partial class ClientService : IRepository<Client>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<Client> repository;

    public ClientService(AutoRepairDataContext ctx)
    {
        context = ctx;
        repository = new Repository<Client>(context);
    }
   
    public void Add(Client client)
    {
        repository.Add(client);
    }

    public void Delete(Client client)
    {
        repository.Delete(client);
    }

    public IEnumerable<Client> Find(Expression<Func<Client, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Client> GetAll()
    {
       var clients = repository.GetAll();
       return clients;
    }

    public Client GetById(int id)
    {
        var client = repository.GetById(id);
        return client;
    }

    public void Update(Client client)
    {
        repository.Update(client);
    }

}