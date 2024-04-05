namespace AutoRepairShop.DAL.Models;
public partial class Client
{
    #region  Properties
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? DocumentNumber { get; set; }

    public string? Phone { get; set; }

    #endregion Properties
    public Client()
    {
        Id = Guid.NewGuid();
    }
}
