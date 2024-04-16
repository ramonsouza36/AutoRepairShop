public partial class Vehicle
{
    public Vehicle()
    {
        Id = Guid.NewGuid();
    }
    #region  Properties
    public Guid Id { get; set; }

    public string? Plate { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public int Year { get; set; }

    public string? Color { get; set; }

    #endregion Properties

    #region  Foreign Key

    public Guid ClientId { get; set; }

    #endregion Foreign Key
}