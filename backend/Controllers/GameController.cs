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
        public ActionResult<IEnumerable<Game>> GetGamesWithImagesAndDLCs()
        {
            var gamesWithImagesAndDLCs = _dbContext.Games
                .Include(g => g.GameImages)
                .Include(g => g.DLCs)
                    .ThenInclude(d => d.DLCGallery)
                .Include(g => g.GameGenres)
                    .ThenInclude(gg => gg.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Include(g => g.GameLanguages)
                    .ThenInclude(gl => gl.Language) 
                .ToList();

            // Project the Language object
            gamesWithImagesAndDLCs.ForEach(game =>
            {
                game.GameLanguages = game.GameLanguages.Select(gl => new GameLanguage
                {
                    GameId = gl.GameId,
                    LanguageId = gl.LanguageId,
                    Language = gl.Language // Assign the LanguageName property
                }).ToList();
            });

            return gamesWithImagesAndDLCs;
        }


        // GET: api/game/{id}
        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            var game = _dbContext.Games
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
                    .ThenInclude(ggt => ggt.GameTag)
                .FirstOrDefault(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            // foreach (var gameGenre in game.GameGenres)
            // {
            //     Console.WriteLine($"Game Genre ID: {gameGenre.Genre.Id}");
            //     Console.WriteLine($"Game Genre Name: {gameGenre.Genre.Name}");
            // }

            var ageRatingName = game.AgeRating?.Rating;


            // Project the Genre IDs, Platform IDs, and Language IDs
            game.GameGenres = game.GameGenres.Select(gg => new GameGenre
            {
                GameId = gg.GameId,
                GenreId = gg.GenreId,
                Genre = gg.Genre
            }).ToList();

            game.GamePlatforms = game.GamePlatforms.Select(gp => new GamePlatform
            {
                GameId = gp.GameId,
                PlatformId = gp.PlatformId,
                Platform = gp.Platform
            }).ToList();

            game.GameLanguages = game.GameLanguages.Select(gl => new GameLanguage
            {
                GameId = gl.GameId,
                LanguageId = gl.LanguageId,
                Language = gl.Language 
            }).ToList();

            return game;
        }


        // Search for games
        [HttpGet("search")]
        public ActionResult<IEnumerable<Game>> GetGameSearch(string title)
        {
            var games = _dbContext.Games
                .Include(g => g.GameImages)
                .Include(g => g.DLCs)
                    .ThenInclude(d => d.DLCGallery)
                .Include(g => g.GameGenres)
                    .ThenInclude(gg => gg.Genre)
                .Include(g => g.GamePlatforms)
                    .ThenInclude(gp => gp.Platform)
                .Include(g => g.GameLanguages)
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
