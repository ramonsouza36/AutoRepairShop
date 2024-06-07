using System.ComponentModel.DataAnnotations.Schema;

public partial class Product
{
    #region  Properties
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int Count { get; set; }

    public decimal Value { get; set; }

    public string? Supplier { get; set; }

    [NotMapped]
    public bool IsSelected { get; set; } = false;

    [NotMapped]
    public int QuantityUsed { get; set; }

    #endregion Properties
}