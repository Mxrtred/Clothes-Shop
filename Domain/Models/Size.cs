using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Size
{
    [Key]
    public long ID { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
}