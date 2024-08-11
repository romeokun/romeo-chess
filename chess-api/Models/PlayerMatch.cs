using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace chess_api.Models;

[PrimaryKey(nameof(Id), nameof(playerId))]
public partial class PlayerMatch
{
 [Required]
 public int Id {get; set;}
 [Required]
 public string playerId {get; set;} = null!;
}