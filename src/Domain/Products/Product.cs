namespace Domain;

public class Product
{
    public ProductId Id { get; private set; }
    public string  Name { get; private set; } = string.Empty;
    public Money Price { get; private set; }
    public  Sku Sku { get; private set; }
    public static Product Create(string name, Money price,Sku sku)
    =>new Product{
        Id= new ProductId(new Guid()),
        Name= name,
        Price= price,
        Sku= sku
    };

}
public record ProductId (Guid value);