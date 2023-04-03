using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Client
{
    [Key]
    public long ID { get; set; }
    public string Name { get; set; } 
}