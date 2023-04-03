using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class ItemOrder
{
    [Key]
    public long ID { get; set; }
    
    public long IDClothes { get; set; }
  
    public Clothes Clothes { get; set; }
    
    public long IDOrder{ get; set; }

    public Order Order { get; set; }
    
  
    
    
    
}