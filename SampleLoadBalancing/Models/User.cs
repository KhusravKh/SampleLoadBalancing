using System.ComponentModel.DataAnnotations;

namespace SampleLoadBalancing.Models;

public class User
{
    [Key]
    public long Id { get; set; }
    
    [Required]
    public string Name { get; set; }
}