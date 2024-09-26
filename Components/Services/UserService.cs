using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;
using AutoRepairShop.DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace AutoRepairShop.Components.Services;
public partial class UserService : IRepository<IdentityUser>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<IdentityUser> repository;

    private readonly UserManager<IdentityUser> userManager;
    

    public UserService(AutoRepairDataContext ctx , UserManager<IdentityUser> manager)
    {
        context = ctx;
        repository = new Repository<IdentityUser>(context);
        userManager = manager;
    }
   
    public async Task Add(IdentityUser client)
    {
        await repository.Add(client);
    }

    public async Task Add(IdentityUser client, string password)
    {
        await repository.Add(client);
        await userManager.AddPasswordAsync(client, password);
    }

    public async Task DeleteAsync(IdentityUser client)
    {
        await repository.DeleteAsync(client);
    }

    public IEnumerable<IdentityUser> Find(Expression<Func<IdentityUser, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IdentityUser> GetAll()
    {
       var clients = repository.GetAll();
       return clients;
    }

    public IdentityUser GetById(Guid id)
    {
        var client = repository.GetById(id);
        return client;
    }

    public void Update(IdentityUser client)
    {
        repository.Update(client);
    }

}