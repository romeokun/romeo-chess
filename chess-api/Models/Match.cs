using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chess_api.Models;

[Table("matches")]
public partial class Match
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("fenNotation")]
    [StringLength(64)]
    public string fenNotation { get; set; } = null!;

    public DateTime startDate { get; set; }
    public DateTime updateDate { get; set; }

}
