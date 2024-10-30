public partial class ServiceOrderFilter
{
    #region Properties
    public long? OrderNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int IsAuthorized { get; set; } = 1;

    #endregion Properties
}