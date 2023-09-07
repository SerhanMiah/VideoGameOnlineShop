using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Data;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Payments;

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
        public ActionResult<IEnumerable<Game>> GetGamesWithImagesAndDLCs()
        {
            var gamesWithImagesAndDLCs = _dbContext.Games
                .Include(g => g.GameImages)
                .Include(g => g.DLCs)
                .ThenInclude(d => d.DLCImages!)
                .ToList();

            return gamesWithImagesAndDLCs;
        }

        // GET: api/game/{id}
        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            var game = _dbContext.Games
                .Include(g => g.GameImages)
                .Include(g => g.DLCs)
                .ThenInclude(d => d.DLCImages!)
                .FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }


        // Search for games
        [HttpGet("search")]

        public ActionResult<IEnumerable<Game>> GetGameSearch(string title)
        {
            var games = _dbContext.Games
                .Where(g => g.Title.Contains(title))
                .ToList();

            if (!games.Any())
            {
                return NotFound();
            }

            return Ok(games);
        }

    }
}
