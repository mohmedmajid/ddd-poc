namespace Domain;

public class Order
{
    private Order()
    {
        
    }
    private readonly HashSet<LineItem> _lineItems= new();
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; } 


    public static Order Create( Customer customer)
    => new Order
    {
        Id= new Guid(),
        CustomerId= customer.Id
    };
    public void AddItem( Product product)   
    {
        var lineItem = new LineItem(new Guid(), Id, product.Id,product.Price);
        _lineItems.Add(lineItem);
    }

}