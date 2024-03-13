using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public partial class ClientService : IRepository<Client>
{
    private readonly Repository<Client>? _repository;
    
    public ClientService(Repository<Client> repository, IdentityDbContext identityDbContext)
    {
        _repository = repository;
    }

    public void Add(Client client)
    {
        _repository!.Add(client);
    }

    public void Delete(Client client)
    {
        _repository!.Delete(client);
    }

    public IEnumerable<Client> Find(Expression<Func<Client, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Client> GetAll()
    {
       var clients =  _repository!.GetAll();
       return clients;
    }

    public Client GetById(int id)
    {
        var client = _repository!.GetById(id);
        return client;
    }

    public void Update(Client client)
    {
        _repository!.Update(client);
    }

}