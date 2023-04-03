using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Clothes
{
    [Key]
    public long ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
}