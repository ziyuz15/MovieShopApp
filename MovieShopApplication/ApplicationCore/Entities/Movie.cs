using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApplicationCore.Entities;

public class Movie
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string BackdropUrl { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Budget { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string CreatedBy { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string ImdbUrl { get; set; }
    
    [Column(TypeName = "varchar(64)")]
    public string OriginalLanguage { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string Overview { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string PosterUrl { get; set; }
    
    [Column(TypeName = "decimal(5,2")]
    public decimal Price { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime ReleaseDate { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal Revenue { get; set; }
    
    public int? RunTime { get; set; }
    
    [Column(TypeName = "varchar(512)")]
    public string Tagline { get; set; }
    
    [Column(TypeName = "varchar(2084)")]
    public string TmdbUrl { get; set; }

    
    [Column(TypeName = "varchar(MAX)")]
    public string UpdatedBy { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime UpdatedDate { get; set; }
    
    public ICollection<MovieGenre> MovieGenres { get; set; }
    public ICollection<MovieCast> MovieCasts { get; set; }
    // public List<Trailer> Trailers { get; set; } //weak relationship?
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
    
    // public double Rating { get; set; }
    // public double Duration { get; set; }
    // public string ImageUrl { get; set; }
    // public List<Genre> Genres { get; set; }
}