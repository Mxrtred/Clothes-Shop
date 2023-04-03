using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Domain.Models;

public class Order
{
    [Key] public long ID { get; set; }
    public DateTime Date { get; set; }
    public double Sum { get; set; }
    public long IDClient { get; set; }
    [ForeignKey("IDClient")]
    public Client Client { get; set; }
    
}