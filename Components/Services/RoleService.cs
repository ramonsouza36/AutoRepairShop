using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;
using AutoRepairShop.DAL.Models;
using Microsoft.AspNetCore.Identity;

namespace AutoRepairShop.Components.Services;
public partial class RoleService : IRepository<IdentityRole>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<IdentityRole> repository;

    private readonly RoleManager<IdentityRole>? roleManager;

    public RoleService(AutoRepairDataContext ctx,RoleManager<IdentityRole> _roleManager)
    {
        context = ctx;
        repository = new Repository<IdentityRole>(context);
        roleManager = _roleManager;
    }
   
    public async Task Add(IdentityRole role)
    {
        role.NormalizedName = role!.Name!.ToUpper();
        await repository.Add(role);
    }

    public async Task DeleteAsync(IdentityRole role)
    {
        await roleManager!.DeleteAsync(role);
    }

    public IEnumerable<IdentityRole> Find(Expression<Func<IdentityRole, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IdentityRole> GetAll()
    {
       var roles = repository.GetAll();
       return roles;
    }

    public IdentityRole GetById(Guid id)
    {
        var roles = repository.GetAll();
        return roles.FirstOrDefault(x => x.Id == id.ToString())!;
    }

    public void Update(IdentityRole role)
    {
        repository.Update(role);
    }

}