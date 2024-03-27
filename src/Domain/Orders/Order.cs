namespace Domain;

public class Order
{
    private Order()
    {

    }
    private readonly HashSet<LineItem> _lineItems = new();
    public OrderId Id { get; private set; }
    public CustomerId CustomerId { get; private set; }


    public static Order Create(CustomerId id)
    => new Order
    {
        Id = new OrderId(new Guid()),
        CustomerId = id
    };
    public void AddItem(ProductId productId, Money price)
    {
        var lineItem = new LineItem(
            new LineItemId(new Guid()),
            Id, 
            productId,
            price);
        _lineItems.Add(lineItem);
    }
}
public record OrderId(Guid value);