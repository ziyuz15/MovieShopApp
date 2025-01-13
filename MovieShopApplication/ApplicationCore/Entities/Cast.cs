namespace ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cast
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Gender is required")]
    [Column(TypeName = "varchar(MAX)")]
    public string Gender { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [Column(TypeName = "varchar(128)")]
    public string Name { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(2084)")]
    public string ProfilePath { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(MAX)")]
    public string TmdUrl { get; set; }
    
    public ICollection<MovieCast> MovieCasts { get; set; }
}