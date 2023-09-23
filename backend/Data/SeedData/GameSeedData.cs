using backend.Models.Product;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Product;

public static class GameSeedData
{
    public static void Seed(ModelBuilder builder)
    {
        // Seed Age Ratings
        var ageRatings = new List<AgeRating>
        {
            new AgeRating { Id = 1, Rating = "E - Everyone" },
            new AgeRating { Id = 2, Rating = "E10+ - Everyone 10 and older" },
            new AgeRating { Id = 3, Rating = "T - Teen" },
            new AgeRating { Id = 4, Rating = "M - Mature" },
            new AgeRating { Id = 5, Rating = "AO - Adults Only" },
            new AgeRating { Id = 6, Rating = "RP - Rating Pending" }
            // Add more age ratings as needed...
        };
        builder.Entity<AgeRating>().HasData(ageRatings);


        // Seed Game Genres
        var gameGenres = new List<Genre>
        {
            new Genre { Id = 1, Name = "Action" },
            new Genre { Id = 2, Name = "Adventure" },
            new Genre { Id = 3, Name = "RPG" },
            new Genre { Id = 4, Name = "Simulation" },
            new Genre { Id = 5, Name = "Strategy" },
            new Genre { Id = 6, Name = "Sports" },
            new Genre { Id = 7, Name = "Puzzle" },
            new Genre { Id = 8, Name = "Horror" },
            new Genre { Id = 9, Name = "Shooter" },
            new Genre { Id = 10, Name = "Platformer" },
            new Genre { Id = 11, Name = "Fighting" },
            new Genre { Id = 12, Name = "Racing" },
            new Genre { Id = 13, Name = "Music" },
            new Genre { Id = 14, Name = "Educational" },
            new Genre { Id = 15, Name = "Card & Board" },
            new Genre { Id = 16, Name = "Survival" },
            new Genre { Id = 17, Name = "Stealth" },
            new Genre { Id = 18, Name = "MMORPG" },
            new Genre { Id = 19, Name = "Battle Royale" },
            new Genre { Id = 20, Name = "Sandbox" }
            // Add more genres as needed...
        };
        builder.Entity<Genre>().HasData(gameGenres);


        // Seed Game Platforms
        var gamePlatforms = new List<Platform>
        {
            new Platform { Id = 1, Name = "PC" },
            new Platform { Id = 2, Name = "Xbox One" },
            new Platform { Id = 3, Name = "PS4" },
            new Platform { Id = 4, Name = "Nintendo Switch" },
            new Platform { Id = 5, Name = "PS5" },
            new Platform { Id = 6, Name = "Xbox X" }

        };
        builder.Entity<Platform>().HasData(gamePlatforms);

        // Seed Game Tags
        var gameTags = new List<GameTag>
        {
            new GameTag { TagId = 1, TagName = "Open World" },
            new GameTag { TagId = 2, TagName = "Multiplayer" },
            new GameTag { TagId = 3, TagName = "Single Player" },
            new GameTag { TagId = 4, TagName = "Fantasy" },
            new GameTag { TagId = 5, TagName = "Sci-Fi" },
            new GameTag { TagId = 6, TagName = "Horror" },
            new GameTag { TagId = 7, TagName = "Action-Adventure" },
            new GameTag { TagId = 8, TagName = "Racing" },
            new GameTag { TagId = 9, TagName = "Sports" },
            new GameTag { TagId = 10, TagName = "Simulation" },
            new GameTag { TagId = 11, TagName = "Strategy" },
            new GameTag { TagId = 12, TagName = "Role-Playing" },
            new GameTag { TagId = 13, TagName = "Puzzle" },
            new GameTag { TagId = 14, TagName = "Platformer" },
            new GameTag { TagId = 15, TagName = "Shooter" },
            new GameTag { TagId = 16, TagName = "Survival" }
            // Add more game tags as needed...
        };
        builder.Entity<GameTag>().HasData(gameTags);


        // Seed Languages
        var languages = new List<Language>
        {
            new Language { Id = 1, LanguageName = "English" },
            new Language { Id = 2, LanguageName = "Spanish" },
            new Language { Id = 3, LanguageName = "French" },
            new Language { Id = 4, LanguageName = "German" },
            new Language { Id = 5, LanguageName = "Japanese" }
        };
        builder.Entity<Language>().HasData(languages);

        // Seed Games
        var games = new List<Game>
        {
            new Game
            {
                Id = 1,
                Title = "The Witcher 3: Wild Hunt",
                Price = 29.99m,
                ReleaseDate = new DateTime(2015, 5, 19),
                Description = "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.",
                TrailerUrl = "https://www.youtube.com/watch?v=c0i88t0Kacs",
                Developer = "CD Projekt Red",
                AverageRating = 4.8,
                MinimumSystemRequirements = "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space",
                RecommendedSystemRequirements = "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: T - Teen
                CoverImage = "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp"
            },
            new Game
            {
                Id = 2,
                Title = "Red Dead Redemption 2",
                Price = 59.99m,
                ReleaseDate = new DateTime(2018, 10, 26),
                Description = "Red Dead Redemption 2 is an epic tale of life in America's unforgiving heartland.",
                TrailerUrl = "https://www.youtube.com/watch?v=eaW0tYpxyp0",
                Developer = "Rockstar Games",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-2500K / AMD FX-6300, Memory: 8 GB RAM, Graphics: Nvidia GTX 770 2GB / AMD Radeon R9 280 3GB, Storage: 150 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 12 GB RAM, Graphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB, Storage: 150 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 3, // Age Rating: M - Mature
                CoverImage = "https://cdn.cloudflare.steamstatic.com/steam/apps/1174180/capsule_sm_120.jpg?t=1677747900"
            }
        };

        // Associate supported languages with the games
        var gameLanguages = new List<GameLanguage>
        {
            // The Witcher 3
            new GameLanguage { GameId = 1, LanguageId = 1 }, // English
            new GameLanguage { GameId = 1, LanguageId = 2 }, // Spanish
            new GameLanguage { GameId = 1, LanguageId = 3 }, // French
            new GameLanguage { GameId = 1, LanguageId = 4 }, // German
            new GameLanguage { GameId = 1, LanguageId = 5 },  // Japanese

            // Red Dead Redemption 2
            new GameLanguage { GameId = 2, LanguageId = 1 }, // English
            new GameLanguage { GameId = 2, LanguageId = 2 }, // Spanish
            new GameLanguage { GameId = 2, LanguageId = 3 }, // French
            new GameLanguage { GameId = 2, LanguageId = 4 }, // German
            new GameLanguage { GameId = 2, LanguageId = 5 }  // Japanese
        };

        // Seed GameGameTag entities
        var gameGameTags = new List<GameGameTag>
        {
            // The Witcher 3
            new GameGameTag { GameId = 1, GameTagId = 1 }, // Tag: Open World
            new GameGameTag { GameId = 1, GameTagId = 2 }, // Tag: Multiplayer
            new GameGameTag { GameId = 1, GameTagId = 3 },  // Tag: Single Player

            // Red Dead Redemption 2
            new GameGameTag { GameId = 2, GameTagId = 1 }, // Tag: Open World
            new GameGameTag { GameId = 2, GameTagId = 2 }, // Tag: Multiplayer
            new GameGameTag { GameId = 2, GameTagId = 3 }  // Tag: Single Player
        };

        // Seed GamePlatform entities
        var gamePlatformAssociations = new List<GamePlatform>
        {
            // The Witcher 3
            new GamePlatform { GameId = 1, PlatformId = 1 }, // PC
            new GamePlatform { GameId = 1, PlatformId = 2 }, // Xbox One
            new GamePlatform { GameId = 1, PlatformId = 3 },  // PS4

            // Red Dead Redemption 2
            new GamePlatform { GameId = 2, PlatformId = 1 }, // PC
            new GamePlatform { GameId = 2, PlatformId = 2 }, // Xbox One
            new GamePlatform { GameId = 2, PlatformId = 3 }  // PS4
        };

        // Seed GameGenre entities
        var gameGenresAssociations = new List<GameGenre>
        {
            // The Witcher 3
            new GameGenre { GameId = 1, GenreId = 1 }, // Action
            new GameGenre { GameId = 1, GenreId = 2 }, // Adventure

            // Red Dead Redemption 2
            new GameGenre { GameId = 2, GenreId = 1 }, // Action
            new GameGenre { GameId = 2, GenreId = 2 }  // Adventure
        };
            
            builder.Entity<Game>().HasData(games);
            builder.Entity<GameLanguage>().HasData(gameLanguages);
            builder.Entity<GameGameTag>().HasData(gameGameTags);
            builder.Entity<GamePlatform>().HasData(gamePlatformAssociations);
            builder.Entity<GameGenre>().HasData(gameGenresAssociations);


            // DLCs
            var dlcs = new List<DLC>
            {
                // DLCs for "The Witcher 3: Wild Hunt"
                new DLC
                {
                    Id = 1,
                    DLCName = "The Witcher 3: Hearts of Stone",
                    ReleaseDate = new DateTime(2015, 10, 13),
                    Price = 9.99m,
                    Description = "Embark on a new adventure as Geralt of Rivia in the Hearts of Stone expansion.",
                    Developer = "CD Projekt",
                    Publisher = "CD Projekt",
                    DiscountedPrice = null,
                    GameId = 1,
                    MinimumSystemRequirements = "OS: 64-bit Windows 7, CPU: Intel CPU Core i5-2500K 3.3GHz, RAM: 6GB, Graphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870",
                    RecommendedSystemRequirements = "OS: 64-bit Windows 7, CPU: Intel CPU Core i7 3770 3.4 GHz, RAM: 8GB, Graphics: Nvidia GPU GeForce GTX 770 / AMD GPU Radeon R9 290",
                    DLCGallery = new List<DLCImage>(), // Initialize with an empty list for now
                    MainDLCImageId = null,
                    AverageRating = 4.8,
                    TrailerUrl = "https://www.youtube.com/watch?v=ffdxS9R6NTE",
                },

                // Add more DLCs as needed...
            };

            builder.Entity<DLC>().HasData(dlcs);

            // DLC Images
            var dlcImages = new List<DLCImage>
            {
                // DLC Images for "The Witcher 3: Hearts of Stone"
                new DLCImage
                {
                    Id = 1,
                    ImageUrl = "https://static.wikia.nocookie.net/witcher/images/0/09/Tw3_expansion_pack_hos.jpg/revision/latest?cb=20150908190146",
                    Caption = "The Witcher 3: Hearts of Stone DLC Image 1",
                    DLCId = 1
                },
                new DLCImage
                {
                    Id = 2,
                    ImageUrl = "https://example.com/path_to_second_image.jpg",
                    Caption = "The Witcher 3: Hearts of Stone DLC Image 2",
                    DLCId = 1
                },
                new DLCImage
                {
                    Id = 3,
                    ImageUrl = "https://example.com/path_to_third_image.jpg",
                    Caption = "The Witcher 3: Hearts of Stone DLC Image 3",
                    DLCId = 1
                }

                // Add more DLCImage entries as needed...
            };

            builder.Entity<DLCImage>().HasData(dlcImages);

        }
    }
