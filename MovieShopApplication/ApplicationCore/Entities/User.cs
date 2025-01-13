using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace ApplicationCore.Entities;

public class User
{
    public int Id { get; set; }
    
    [Column(TypeName = "datetime2")]
    public DateTime DateOfBirth { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(256)")]
    public string Email { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(128)")]
    public string FirstName { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(1024)")]
    public string HashedPassword { get; set; }
    
    [Column(TypeName = "bit")]
    public bool isLocked { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(128)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "varchar(16)")]
    public string PhoneNumber { get; set; }
    
    [Column(TypeName = "varchar(MAX)")]
    public string ProfilePictureUrl { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(1024)")]
    public string Salt { get; set; }
    
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
}