namespace ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Genre
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Genre name is required")]
    [Column(TypeName = "varchar(24)")]
    public string Name { get; set; }

    public ICollection<MovieGenre> MovieGenre { get; set; }
}