using System.ComponentModel.DataAnnotations;

namespace ProductService.Models;

public class Product
{
    [Key]
    public long Id { get; set; }
    
    [Required]
    public string Name { get; set; }
}