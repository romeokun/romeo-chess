using Microsoft.EntityFrameworkCore;
using chess_api.Models;
namespace chess_api.Data;

public partial class RomeochessContext : DbContext
{
    public RomeochessContext()
    {
    }

    public RomeochessContext(DbContextOptions<RomeochessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Match> Matches { get; set; }

    
}
