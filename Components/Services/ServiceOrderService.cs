using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;

public partial class ServiceOrderService : IRepository<ServiceOrder>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<ServiceOrder> repository;

    public ServiceOrderService(AutoRepairDataContext ctx)
    {
        context = ctx;
        repository = new Repository<ServiceOrder>(context);
    }
    public async Task Add(ServiceOrder serviceOrder)
    {
        await repository.Add(serviceOrder);
    }

    public async Task DeleteAsync(ServiceOrder serviceOrder)
    {
        await repository.DeleteAsync(serviceOrder);
    }

    public IEnumerable<ServiceOrder> Find(Expression<Func<ServiceOrder, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ServiceOrder> GetAll()
    {
       var serviceOrders =  repository.GetAll();
       return serviceOrders;
    }

    public ServiceOrder GetById(int id)
    {
        var serviceOrder = repository.GetById(id);
        return serviceOrder;
    }

    public void Update(ServiceOrder serviceOrder)
    {
        repository.Update(serviceOrder);
    }

    public long GetMaxOrderNumber()
    {
        return context.ServiceOrders.Max(p => p.OrderNumber);
    }
}