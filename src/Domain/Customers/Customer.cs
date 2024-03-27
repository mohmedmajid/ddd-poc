namespace Domain;

public class Customer
{
    private Customer()
    {
    }
    public static Customer Create(CustomerId id, string name)
    => new()
    {
        Id = id,
        Name = name
    };

    public CustomerId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;

}
public record CustomerId(Guid value);
