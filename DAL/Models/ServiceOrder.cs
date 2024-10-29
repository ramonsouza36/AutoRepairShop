public partial class ServiceOrder
{
    public ServiceOrder()
    {
        Id = Guid.NewGuid();
    }

    #region  Properties
    public Guid Id { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }
    
    public long OrderNumber { get; set; }

    public string? ProductsUsed { get; set; }

    public bool Authorized { get; set; } 
    
    public DateTime AuthorizedDate { get; set; }

    public decimal Value { get; set; }

    public bool Paid { get; set; } 

    public DateTime PaymentDate { get; set; }
    
    #endregion Properties

    #region  Foreign Key

    public Guid VehicleId { get; set; }

    #endregion Foreign Key
}