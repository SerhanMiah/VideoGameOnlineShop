using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Data;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Payments;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Controllers
{
 [ApiController]
[Route("api/[controller]")]
public class GameController : ControllerBase
{
    private readonly GameDbContext _dbContext;

    public GameController(GameDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET: api/game
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Game>>> GetAllGames()
    {
        var games = await _dbContext.Games.ToListAsync();
        return Ok(games);
    }


    // GET: api/game/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGame(int id)
    {
        var game = await GetGameWithDetails().FirstOrDefaultAsync(g => g.Id == id);

        if (game == null)
        {
            return NotFound();
        }

        return Ok(game);
    }

    // Search for games
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Game>>> GetGameSearch(string title)
    {
        var games = await GetGameWithDetails()
            .Where(g => g.Title.Contains(title))
            .ToListAsync();

        if (!games.Any())
        {
            return NotFound();
        }

        return Ok(games);
    }

    private IQueryable<Game> GetGameWithDetails()
    {
        return _dbContext.Games
            .Include(g => g.AgeRating)
            .Include(g => g.GameImages)
            .Include(g => g.DLCs)
                .ThenInclude(d => d.DLCGallery)
            .Include(g => g.GameGenres)
                .ThenInclude(gg => gg.Genre)
            .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
            .Include(g => g.GameLanguages)
                .ThenInclude(gl => gl.Language)
            .Include(g => g.GameGameTags)
                .ThenInclude(ggt => ggt.GameTag);
        }
    }
}