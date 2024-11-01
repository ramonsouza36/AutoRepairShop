public partial class PaymentFilter
{
    #region Properties
    public long? OrderNumber { get; set; }

    public DateTime? PaymentDate { get; set; }

    public int IsPaid { get; set; } = 1;

    #endregion Properties
}