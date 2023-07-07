using System.ComponentModel.DataAnnotations;
using FinalHP.Utils;
namespace FinalHP;

public class Product 
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Nombre")]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }
    [Required]
    [Display(Name = "Tipo de producto")]
    public ProductType Type { get; set; }
    [Required]
    [Display(Name = "Disponible para envío")]
    public bool shippingAvailable { get; set; } = false;
    [Required]
    [Display(Name = "Cantidad vendida")]
    public int QuantitySold {get; set;}
    public virtual List<Community> Communities { get; set; }
}