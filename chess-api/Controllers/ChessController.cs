using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace chess_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChessController : ControllerBase
{
    private readonly ILogger<ChessController> _logger;
    private readonly MySqlConnection _connection;
    public ChessController(ILogger<ChessController> logger, MySqlConnection connection)
    {
        _logger = logger;
        _connection = connection;
    }

    [HttpGet("users/{id}")]
    [Authorize]
    public string GetUserProfile(int id)
    {
        return "Hello World";
    }
    
    [HttpGet("matches")]
    [Authorize]
    public string GetAllMatches(){
        return $"matches";
    }

    [HttpGet("matches/{matchId}")]
    [Authorize]
    // Query match info with players
    public string GetMatch(int matchId)
    {
        return $"Match id: {matchId}";
    }

}

