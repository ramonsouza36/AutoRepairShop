using System.Linq.Expressions;

public partial class ClientService : IRepository<Client>
{
    public void Add(Client client)
    {
        Add(client);
    }

    public void Delete(Client client)
    {
        Delete(client);
    }

    public IEnumerable<Client> Find(Expression<Func<Client, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Client> GetAll()
    {
       var clients =  GetAll();
       return clients;
    }

    public Client GetById(int id)
    {
        var client = GetById(id);
        return client;
    }

    public void Update(Client client)
    {
        Update(client);
    }

}