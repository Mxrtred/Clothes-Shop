using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Collection
{
    [Key]
    public long ID { get; set; }
    public string Name { get; set; }
    [MaxLength(20)]
    public string Description { get; set; }
    
}