using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;
using AutoRepairShop.DAL.Models;

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
   
    public async Task Add(Client client)
    {
        await repository.Add(client);
    }

    public async Task DeleteAsync(Client client)
    {
        await repository.DeleteAsync(client);
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

    public Client GetById(Guid id)
    {
        var client = repository.GetById(id);
        return client;
    }

    public void Update(Client client)
    {
        repository.Update(client);
    }

}