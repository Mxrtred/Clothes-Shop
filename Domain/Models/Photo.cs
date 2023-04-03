using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Photo
{
    [Key]
    public long ID { get; set; }
    public string File { get; set; }
    public long IdCollection { get; set; }
}