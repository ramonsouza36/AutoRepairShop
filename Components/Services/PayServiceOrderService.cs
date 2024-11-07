using System.Linq.Expressions;
using AutoRepairShop.Components.Interfaces;
using AutoRepairShop.Components.Services;

public partial class PayServiceOrderService : IRepository<PayServiceOrder>
{
    private readonly AutoRepairDataContext context;

    private readonly Repository<PayServiceOrder> repository;

    public PayServiceOrderService(AutoRepairDataContext ctx)
    {
        context = ctx;
        repository = new Repository<PayServiceOrder>(context);
    }
    public async Task Add(PayServiceOrder serviceOrder)
    {
        await repository.Add(serviceOrder);
    }

    public async Task DeleteAsync(PayServiceOrder serviceOrder)
    {
        await repository.DeleteAsync(serviceOrder);
    }

    public IEnumerable<PayServiceOrder> Find(Expression<Func<PayServiceOrder, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PayServiceOrder> GetAll()
    {
       var serviceOrders =  repository.GetAll();
       return serviceOrders;
    }

    public PayServiceOrder GetById(Guid id)
    {
        var serviceOrder = repository.GetById(id);
        return serviceOrder;
    }

    public void Update(PayServiceOrder serviceOrder)
    {
        repository.Update(serviceOrder);
    }

    public long GetMaxOrderNumber()
    {
        return context.ServiceOrders.Max(p => p.OrderNumber);
    }
}