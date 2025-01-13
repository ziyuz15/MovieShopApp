using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApplicationCore.Entities;

public class MovieCast
{
    public int CastId { get; set; }
    public Cast Cast { get; set; }

    [Required]
    [Column(TypeName = "varchar(450)")]
    public string Character { get; set; }
    
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
}