using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApplicationCore.Entities;

public class Role
{
    public int Id { get; set; }
    
    [Required]
    [Column(TypeName = "varchar(20)")]
    public string Name { get; set; }
    
    public ICollection<UserRole> UserRoles { get; set; }
}