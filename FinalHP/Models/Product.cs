
using FinalHP.Utils;
namespace FinalHP;

public class Product 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }
    public bool shippingAvailable { get; set; } = false;
    public int QuantitySold {get; set;}
    public virtual List<Community> Communities { get; set; }
}