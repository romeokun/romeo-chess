using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chess_api.Models;

[Table("users")]
public partial class User
{
 [Key]
 [Column("uuid")]
 public string Uuid { get; set; } = null!;

 public string Name { get; set; } = null!;
}