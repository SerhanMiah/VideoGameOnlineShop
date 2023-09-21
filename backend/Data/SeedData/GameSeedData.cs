using System;
using System.Collections.Generic;
using backend.Models.Product;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Data.SeedData
{
    public static class GameSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            // Age Ratings
            var ageRatings = new List<AgeRating>
            {
                new AgeRating { Id = 1, Rating = "Everyone" },
                new AgeRating { Id = 2, Rating = "Mature" },
                new AgeRating { Id = 3, Rating = "Teen" },
                new AgeRating { Id = 4, Rating = "Adults Only" },
                new AgeRating { Id = 5, Rating = "Everyone 10+" },
                new AgeRating { Id = 6, Rating = "Adults Only 18+" },
                new AgeRating { Id = 7, Rating = "Everyone 10+ with Cartoon Violence" },
                new AgeRating { Id = 8, Rating = "Mature 17+ with Blood and Gore, Intense Violence" },
                new AgeRating { Id = 9, Rating = "Teen 13+ with Mild Language, Violence" }
            };

            builder.Entity<AgeRating>().HasData(ageRatings);

            // Game Genres
            var gameGenres = new List<Genre>
            {
                new Genre { Id = 1, Name = "Open World" },
                new Genre { Id = 2, Name = "Role Playing" },
                new Genre { Id = 3, Name = "Action" },
                new Genre { Id = 4, Name = "Adventure" },
                new Genre { Id = 5, Name = "Strategy" },
                new Genre { Id = 6, Name = "Sports" },
                new Genre { Id = 7, Name = "Simulation" },
                new Genre { Id = 8, Name = "Fighting" },
                new Genre { Id = 9, Name = "Horror" }
            };

            builder.Entity<Genre>().HasData(gameGenres);

            // Game Platforms
            var gamePlatforms = new List<Platform>
            {
                new Platform { Id = 1, Name = "PC" },
                new Platform { Id = 2, Name = "PlayStation 5" },
                new Platform { Id = 3, Name = "Xbox Series X" },
                new Platform { Id = 4, Name = "Nintendo Switch" },
                new Platform { Id = 5, Name = "Mobile" },
                new Platform { Id = 6, Name = "PlayStation 4" },
                new Platform { Id = 7, Name = "Xbox One" },
                new Platform { Id = 8, Name = "Nintendo Switch Lite" },
                new Platform { Id = 9, Name = "Google Stadia" }
            };

            builder.Entity<Platform>().HasData(gamePlatforms);


            var gameTags = new List<GameTag>
            {
                new GameTag { TagId = 1, TagName = "Fantasy" },
                new GameTag { TagId = 2, TagName = "Medieval" },
                new GameTag { TagId = 3, TagName = "Story Rich" },
                new GameTag { TagId = 4, TagName = "Sci-Fi" },
                new GameTag { TagId = 5, TagName = "Post-Apocalyptic" },
                new GameTag { TagId = 6, TagName = "Horror" },
                new GameTag { TagId = 7, TagName = "Survival" },
                new GameTag { TagId = 8, TagName = "Retro" },
                new GameTag { TagId = 9, TagName = "Puzzle" },
                new GameTag { TagId = 10, TagName = "Platformer" },
                new GameTag { TagId = 11, TagName = "Shooter" },
                new GameTag { TagId = 12, TagName = "Strategy" },
                new GameTag { TagId = 13, TagName = "RPG" },
                new GameTag { TagId = 14, TagName = "VR" },
                new GameTag { TagId = 15, TagName = "Multiplayer" },
                new GameTag { TagId = 16, TagName = "Singleplayer" },
                new GameTag { TagId = 17, TagName = "Racing" },
                new GameTag { TagId = 18, TagName = "Sports" },
                new GameTag { TagId = 19, TagName = "Open World" },
                new GameTag { TagId = 20, TagName = "Sandbox" },
                new GameTag { TagId = 21, TagName = "City Builder" },
                new GameTag { TagId = 22, TagName = "Management" },
                new GameTag { TagId = 23, TagName = "Simulation" },
                new GameTag { TagId = 24, TagName = "Turn-Based" },
                new GameTag { TagId = 25, TagName = "Roguelike" },
                new GameTag { TagId = 26, TagName = "Narrative" },
                new GameTag { TagId = 27, TagName = "Visual Novel" },
                new GameTag { TagId = 28, TagName = "Anime" },
                new GameTag { TagId = 29, TagName = "Pixel Art" },
                new GameTag { TagId = 30, TagName = "Crafting" }
            };

            builder.Entity<GameTag>().HasData(gameTags);


            // Games
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
                    AgeRatingId = 2,
                    CoverImage = "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp"
                },
                    new Game
                {
                    Id = 2,
                    Title = "Red Dead Redemption 2",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2018, 10, 26),
                    Description = "Red Dead Redemption 2 is an action-adventure game set in the Wild West.",
                    TrailerUrl = "https://www.youtube.com/watch?v=eaW0tYpxyp0",
                    Developer = "Rockstar Games",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows 7 (64-bit), Processor: Intel Core i5-2500K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770, Storage: 150 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 150 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2,
                    CoverImage = "https://www.rockstargames.com/reddeadredemption2/rockstar_games/r_d_r_logo.jpg"
                },
                new Game
                {
                    Id = 3,
                    Title = "Cyberpunk 2077",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2020, 12, 10),
                    Description = "Cyberpunk 2077 is a role-playing video game developed and published by CD Projekt.",
                    TrailerUrl = "https://www.youtube.com/watch?v=vjF9GgrY9c0",
                    Developer = "CD Projekt Red",
                    AverageRating = 4.0,
                    MinimumSystemRequirements = "OS: Windows 7 (64-bit), Processor: Intel Core i5-3570K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780, Storage: 70 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 70 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2,
                    CoverImage = "https://www.cyberpunk.net/build/images/home/title-c-logo-8d1c4e3341.svg"
                },
                new Game
                {
                    Id = 4,
                    Title = "Doom Eternal",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2020, 3, 20),
                    Description = "Doom Eternal is a first-person shooter video game developed by id Software and published by Bethesda Softworks.",
                    TrailerUrl = "https://www.youtube.com/watch?v=FkklG9MA0vM",
                    Developer = "id Software",
                    AverageRating = 4.5,
                    MinimumSystemRequirements = "OS: Windows 7 (64-bit), Processor: Intel Core i5-2400, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060, Storage: 50 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2,
                    CoverImage = "https://bethesda.net/game/doom2016"
                },
                new Game
                {
                    Id = 5,
                    Title = "Assassin's Creed Valhalla",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2020, 11, 10),
                    Description = "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal.",
                    TrailerUrl = "https://www.youtube.com/watch?v=SSYlfRq4ysA",
                    Developer = "Ubisoft",
                    AverageRating = 4.6,
                    MinimumSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i5-4460, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1080, Storage: 50 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2,
                    CoverImage = "https://www.ubisoft.com/en-gb/game/assassins-creed/valhalla"
                },
            };

            builder.Entity<Game>().HasData(games);

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
                    GameId = 1
                },
                new DLC
                {
                    Id = 2,
                    DLCName = "The Witcher 3: Blood and Wine",
                    ReleaseDate = new DateTime(2016, 5, 31),
                    Price = 19.99m,
                    Description = "Visit the picturesque land of Toussaint in the Blood and Wine expansion.",
                    GameId = 1
                },
                   new DLC
                {
                    Id = 3,
                    DLCName = "RDR2: Frontier Tales",
                    ReleaseDate = new DateTime(2019, 7, 21),
                    Price = 14.99m,
                    Description = "Experience new stories from the Wild West in the Frontier Tales expansion.",
                    GameId = 2
                },
                new DLC
                {
                    Id = 4,
                    DLCName = "RDR2: Legend of the East",
                    ReleaseDate = new DateTime(2020, 3, 15),
                    Price = 19.99m,
                    Description = "Unlock the mysteries of the East in this exciting new DLC.",
                    GameId = 2
                },

                // DLCs for "Cyberpunk 2077"
                new DLC
                {
                    Id = 5,
                    DLCName = "Cyberpunk: Night City Stories",
                    ReleaseDate = new DateTime(2021, 6, 15),
                    Price = 12.99m,
                    Description = "Dive deeper into Night City with additional quests and characters.",
                    GameId = 3
                },
                new DLC
                {
                    Id = 6,
                    DLCName = "Cyberpunk: Beyond the Wall",
                    ReleaseDate = new DateTime(2022, 1, 20),
                    Price = 24.99m,
                    Description = "Venture beyond the city limits and explore the wastelands.",
                    GameId = 3
                },

                // DLCs for "Doom Eternal"
                new DLC
                {
                    Id = 7,
                    DLCName = "Doom Eternal: Hell's Ascent",
                    ReleaseDate = new DateTime(2021, 5, 10),
                    Price = 19.99m,
                    Description = "Climb through the new challenges and face tougher demons.",
                    GameId = 4
                },
                new DLC
                {
                    Id = 8,
                    DLCName = "Doom Eternal: The Slayer's Return",
                    ReleaseDate = new DateTime(2021, 12, 20),
                    Price = 19.99m,
                    Description = "Return to the origin of the Slayer and discover his roots.",
                    GameId = 4
                },

                // DLCs for "Assassin's Creed Valhalla"
                new DLC
                {
                    Id = 9,
                    DLCName = "AC Valhalla: Rise of the Druids",
                    ReleaseDate = new DateTime(2021, 5, 13),
                    Price = 24.99m,
                    Description = "Travel to Ireland and confront the Druid cult.",
                    GameId = 5
                },
                new DLC
                {
                    Id = 10,
                    DLCName = "AC Valhalla: The Siege of Paris",
                    ReleaseDate = new DateTime(2021, 8, 12),
                    Price = 24.99m,
                    Description = "Invade the fortified city of Paris and shape its future.",
                    GameId = 5
                }
 
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
                    Caption = "The Witcher 3: Hearts of Stone DLC Image",
                    DLCId = 1
                },
                new DLCImage
                {
                    Id = 2,
                    ImageUrl = "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032",
                    Caption = "The Witcher 3: Blood and Wine DLC Image",
                    DLCId = 2
                }
            };

            builder.Entity<DLCImage>().HasData(dlcImages);
        }
    }
}
