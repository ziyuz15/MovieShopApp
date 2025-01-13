using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApplicationCore.Entities;

public class Review
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    [Required]
    [Column(TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(3,2)")]
    public decimal Rating { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(MAX)")]
    public string ReviewText { get; set; }

}