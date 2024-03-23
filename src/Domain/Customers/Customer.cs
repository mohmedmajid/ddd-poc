namespace Domain;

public class Customer
{
    private Customer()
    {
    }
    public static Customer Create(Guid id, string name)
    => new()
    {
        Id = id,
        Name = name
    };

    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

}
