namespace Domain;

// stock keeping unit
public record Sku 
{
    private const int defaultValue= 15;

    private Sku(string value)=> Value=value;
    public string Value { get; init; }
    
    public static Sku Create(string value)
    { 
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }
        if (value.Length!=defaultValue)        
        {
            return null;            
        }
        return new Sku(value);
    }
}
