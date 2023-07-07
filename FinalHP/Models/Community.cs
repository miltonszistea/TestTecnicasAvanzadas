
using FinalHP.Utils;
namespace FinalHP;

public class Community 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public CommunityType CommunityType { get; set; }
    public string Address { get; set; }

    public virtual List<Product> Products { get; set; } = new List<Product>();
}