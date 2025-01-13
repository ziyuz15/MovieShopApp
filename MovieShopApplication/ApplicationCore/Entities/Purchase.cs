using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApplicationCore.Entities;

public class Purchase
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    [Required]
    [Column(TypeName = "datetime2")]
    public DateTime PurchaseDateTime { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(50)")]
    public string PurchaseNumber { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(5,2)")]
    public decimal TotalPrice { get; set; }
    
    
}