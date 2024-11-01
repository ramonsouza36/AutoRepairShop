public partial class PayServiceOrder
{
    public PayServiceOrder() {}

    #region  Properties 

    public int? OrderId { get; set;}

    public string? PaymentMethod { get; set;}

    public string? PaymentShape { get; set;}

    public decimal TotalValue { get; set;} = default(decimal);

    public decimal Change { get; set;} = default(decimal);

    #endregion Properties
}