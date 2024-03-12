using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public partial class VehicleService : IRepository<Vehicle>
{
    private readonly Repository<Vehicle>? _repository;
    private readonly IdentityDbContext _identityDbContext;
    
    public VehicleService(Repository<Vehicle> repository, IdentityDbContext identityDbContext)
    {
        _repository = repository;
        _identityDbContext = identityDbContext;
    }

    public void Add(Vehicle vehicle)
    {
        _repository!.Add(vehicle);
    }

    public void Delete(Vehicle vehicle)
    {
        _repository!.Delete(vehicle);
    }

    public IEnumerable<Vehicle> Find(Expression<Func<Vehicle, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Vehicle> GetAll()
    {
       var vehicles =  _repository!.GetAll();
       return vehicles;
    }

    public Vehicle GetById(int id)
    {
        var vehicle = _repository!.GetById(id);
        return vehicle;
    }

    public void Update(Vehicle vehicle)
    {
        _repository!.Update(vehicle);
    }
}