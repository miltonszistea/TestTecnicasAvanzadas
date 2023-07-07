using System.ComponentModel.DataAnnotations;
using FinalHP.Utils;
namespace FinalHP;

public class Community 
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Nombre de la Comunidad")]
    public string Name { get; set; }
    [Required]
    [Display(Name = "País")]
    public string Country { get; set; }
    [Required]
    [Display(Name = "Tipo de Comunidad")]
    public CommunityType CommunityType { get; set; }
    [Required]
    [Display(Name = "Dirección")]
    public string Address { get; set; }

    public virtual List<Product> Products { get; set; } = new List<Product>();
}