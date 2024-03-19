using System.Linq.Expressions;

public partial class VehicleService : IRepository<Vehicle>
{
    public void Add(Vehicle vehicle)
    {
        Add(vehicle);
    }

    public void Delete(Vehicle vehicle)
    {
        Delete(vehicle);
    }

    public IEnumerable<Vehicle> Find(Expression<Func<Vehicle, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Vehicle> GetAll()
    {
       var vehicles =  GetAll();
       return vehicles;
    }

    public Vehicle GetById(int id)
    {
        var vehicle = GetById(id);
        return vehicle;
    }

    public void Update(Vehicle vehicle)
    {
        Update(vehicle);
    }
}