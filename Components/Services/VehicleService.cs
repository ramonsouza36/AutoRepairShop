using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;

public partial class VehicleService : IRepository<Vehicle>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<Vehicle> repository;

    public VehicleService(AutoRepairDataContext ctx)
    {
        context = ctx;
        repository = new Repository<Vehicle>(context);
    }
    public async Task Add(Vehicle vehicle)
    {
        await repository.Add(vehicle);
    }

    public async Task DeleteAsync(Vehicle vehicle)
    {
        await repository.DeleteAsync(vehicle);
    }

    public IEnumerable<Vehicle> Find(Expression<Func<Vehicle, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Vehicle> GetAll()
    {
       var vehicles =  repository.GetAll();
       return vehicles;
    }

    public Vehicle GetById(Guid id)
    {
        var vehicle = repository.GetById(id);
        return vehicle;
    }

    public void Update(Vehicle vehicle)
    {
        repository.Update(vehicle);
    }
}