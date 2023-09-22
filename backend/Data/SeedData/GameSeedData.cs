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
                new Game
                {
                    Id = 6,
                    Title = "The Elder Scrolls V: Skyrim",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2011, 11, 11),
                    Description = "The Elder Scrolls V: Skyrim is an open-world action role-playing game set in the fantasy world of Tamriel.",
                    TrailerUrl = "https://www.youtube.com/watch?v=PjqsYzBrP-M",
                    Developer = "Bethesda Game Studios",
                    AverageRating = 4.7,
                    MinimumSystemRequirements = "OS: Windows 7/Vista/XP PC (32 or 64 bit), Processor: Dual-core processor 2.0 GHz, Memory: 2GB RAM, Graphics: DirectX 9.0c compatible NVIDIA or AMD ATI video card with 1GB of RAM, Storage: 6GB of HDD space",
                    RecommendedSystemRequirements = "OS: Windows 7/Vista/XP PC (32 or 64 bit), Processor: Quad-core Intel or AMD CPU, Memory: 4GB System RAM, Graphics: DirectX 9.0c compatible NVIDIA or AMD ATI video card with 1GB of RAM (Nvidia GeForce GTX 260 or higher; ATI Radeon 4890 or higher), Storage: 6GB of HDD space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2,
                    CoverImage = "https://www.elderscrolls.com/skyrim"
                },
                new Game
                {
                    Id = 7,
                    Title = "Grand Theft Auto V",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2013, 9, 17),
                    Description = "Grand Theft Auto V is an action-adventure game set in the fictional state of San Andreas.",
                    TrailerUrl = "https://www.youtube.com/watch?v=QkkoHAzjnUs",
                    Developer = "Rockstar North",
                    AverageRating = 4.8,
                    MinimumSystemRequirements = "OS: Windows 7 64-bit, Processor: Intel Core 2 Quad CPU Q6600 @ 2.40GHz (4 CPUs) / AMD Phenom 9850 Quad-Core Processor (4 CPUs) @ 2.5GHz, Memory: 4 GB RAM, Graphics: NVIDIA 9800 GT 1GB / AMD HD 4870 1GB (DX 10, 10.1, 11), Storage: 72 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 8.1 64 Bit, Windows 8 64 Bit, Windows 7 64 Bit Service Pack 1, Processor: Intel Core i5 3470 @ 3.2GHz (4 CPUs) / AMD X8 FX-8350 @ 4GHz (8 CPUs), Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 2GB / AMD HD 7870 2GB, Storage: 72 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 4,
                    CoverImage = "https://www.rockstargames.com/V"
                },
                new Game
                {
                    Id = 8,
                    Title = "Minecraft",
                    Price = 19.99m,
                    ReleaseDate = new DateTime(2011, 11, 18),
                    Description = "Minecraft is a sandbox construction game that allows players to build and explore their own virtual worlds.",
                    TrailerUrl = "https://www.youtube.com/watch?v=OgH_qvqjBf0",
                    Developer = "Mojang Studios",
                    AverageRating = 4.6,
                    MinimumSystemRequirements = "OS: Windows 7 and up, Processor: Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz or equivalent, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4, Storage: 4GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4690 3.5GHz / AMD A10-7800 APU 3.5 GHz or equivalent, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5, Storage: 4GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1,
                    CoverImage = "https://www.minecraft.net/en-us/"
                },
                new Game
                {
                    Id = 9,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2017, 3, 3),
                    Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game set in the fantasy world of Hyrule.",
                    TrailerUrl = "https://www.youtube.com/watch?v=zw47_q9wbBE",
                    Developer = "Nintendo",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: N/A (Nintendo Switch), Processor: N/A (Nintendo Switch), Memory: N/A (Nintendo Switch), Graphics: N/A (Nintendo Switch), Storage: N/A (Nintendo Switch)",
                    RecommendedSystemRequirements = "OS: N/A (Nintendo Switch), Processor: N/A (Nintendo Switch), Memory: N/A (Nintendo Switch), Graphics: N/A (Nintendo Switch), Storage: N/A (Nintendo Switch)",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1,
                    CoverImage = "https://www.zelda.com/breath-of-the-wild/"
                },
                new Game
                {
                    Id = 10,
                    Title = "Overwatch",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2016, 5, 24),
                    Description = "Overwatch is a team-based multiplayer first-person shooter game.",
                    TrailerUrl = "https://www.youtube.com/watch?v=FqnKB22pOC0",
                    Developer = "Blizzard Entertainment",
                    AverageRating = 4.7,
                    MinimumSystemRequirements = "OS: Windows 7/8/10 64-bit, Processor: Intel Core i3, Memory: 4 GB RAM, Graphics: NVIDIA GeForce GTX 460 / ATI Radeon HD 4850 / Intel HD Graphics 4400, Storage: 30 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7/8/10 64-bit, Processor: Intel Core i5, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7950, Storage: 30 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 3,
                    CoverImage = "https://playoverwatch.com/en-us/"
                },
                new Game
                {
                    Id = 11,
                    Title = "Halo: Infinite",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2021, 12, 8),
                    Description = "Halo: Infinite is a first-person shooter game and the latest installment in the Halo series.",
                    TrailerUrl = "https://www.youtube.com/watch?v=HZtc5-syeAk",
                    Developer = "343 Industries",
                    AverageRating = 4.4,
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4440, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-9700K, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080, Storage: 50 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 3,
                    CoverImage = "https://www.halowaypoint.com/en-us/games/halo-infinite"
                },
                new Game
                {
                    Id = 12,
                    Title = "Stardew Valley",
                    Price = 14.99m,
                    ReleaseDate = new DateTime(2016, 2, 26),
                    Description = "Stardew Valley is a farming simulation game that allows players to build and manage their own farm.",
                    TrailerUrl = "https://www.youtube.com/watch?v=ot7uXNQskhs",
                    Developer = "ConcernedApe",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows Vista or greater, Processor: 2 Ghz, Memory: 2 GB RAM, Graphics: 256 mb video memory, DirectX 10, Storage: 500 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or greater, Processor: 2.8 Ghz, Memory: 4 GB RAM, Graphics: 512 mb video memory, DirectX 10, Storage: 500 MB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1,
                    CoverImage = "https://www.stardewvalley.net/"
                },
                new Game
                {
                    Id = 13,
                    Title = "FIFA 22",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2021, 10, 1),
                    Description = "FIFA 22 is a sports simulation game featuring soccer/football.",
                    TrailerUrl = "https://www.youtube.com/watch?v=I66Dw9t7kgA",
                    Developer = "EA Sports",
                    AverageRating = 4.7,
                    MinimumSystemRequirements = "OS: Windows 10 - 64-Bit, Processor: Athlon X4 880K @4GHz or better/Core i3-6100 @3.7GHz or better, Memory: 8 GB RAM, Graphics: Radeon HD 7850 or better/GeForce GTX 660 or better, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 - 64-Bit, Processor: FX 8150 @3.6GHz or better/Core i5-3550 @3.40GHz or better, Memory: 8 GB RAM, Graphics: Radeon R9 270x or better/GeForce GTX 670 or better, Storage: 50 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 2,
                    DiscountedPrice = null,
                    AgeRatingId = 8,
                    CoverImage = "https://www.ea.com/games/fifa/fifa-22"
                },
                new Game
                {
                    Id = 14,
                    Title = "The Sims 4",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2014, 9, 2),
                    Description = "The Sims 4 is a life simulation game that allows players to create and control virtual people and their lives.",
                    TrailerUrl = "https://www.youtube.com/watch?v=R4l0u0Bw6Iw",
                    Developer = "Maxis",
                    AverageRating = 4.5,
                    MinimumSystemRequirements = "OS: Windows XP, Processor: 1.8 GHz Intel Core 2 Duo / AMD Athlon 64 Dual-Core 4000+ or equivalent, Memory: 4 GB RAM, Graphics: Intel HD Graphics 3000 or better, Storage: 15 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7/8/8.1/10, Processor: Intel Core i5-750 / AMD Athlon X4, Memory: 4 GB RAM, Graphics: NVIDIA GeForce GTX 650 or better, Storage: 18 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1,
                    CoverImage = "https://www.ea.com/games/the-sims/the-sims-4"
                }

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
                    Developer = "CD Projekt", 
                    Publisher = "CD Projekt",
                    DiscountedPrice = null, 
                    GameId = 1, 
                    MinimumSystemRequirements = "OS: 64-bit Windows 7, CPU: Intel CPU Core i5-2500K 3.3GHz, RAM: 6GB, Graphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870",
                    RecommendedSystemRequirements = "OS: 64-bit Windows 7, CPU: Intel CPU Core i7 3770 3.4 GHz, RAM: 8GB, Graphics: Nvidia GPU GeForce GTX 770 / AMD GPU Radeon R9 290",
                    DLCGallery = new List<DLCImage>(), 
                    MainDLCImageId = null,
                    AverageRating = 4.8, 
                    TrailerUrl = "https://www.youtube.com/watch?v=ffdxS9R6NTE", 
                }

                // new DLC
                // {
                //     Id = 2,
                //     DLCName = "The Witcher 3: Blood and Wine",
                //     ReleaseDate = new DateTime(2016, 5, 31),
                //     Price = 19.99m,
                //     Description = "Visit the picturesque land of Toussaint in the Blood and Wine expansion.",
                //     GameId = 1
                // },

                // // DLCs for "Red Dead Redemption 2"
                // new DLC
                // {
                //     Id = 3,
                //     DLCName = "RDR2: Frontier Tales",
                //     ReleaseDate = new DateTime(2019, 7, 21),
                //     Price = 14.99m,
                //     Description = "Experience new stories from the Wild West in the Frontier Tales expansion.",
                //     GameId = 2
                // },
                // new DLC
                // {
                //     Id = 4,
                //     DLCName = "RDR2: Legend of the East",
                //     ReleaseDate = new DateTime(2020, 3, 15),
                //     Price = 19.99m,
                //     Description = "Unlock the mysteries of the East in this exciting new DLC.",
                //     GameId = 2
                // },

                // // DLCs for "Cyberpunk 2077"
                // new DLC
                // {
                //     Id = 5,
                //     DLCName = "Cyberpunk: Night City Stories",
                //     ReleaseDate = new DateTime(2021, 6, 15),
                //     Price = 12.99m,
                //     Description = "Dive deeper into Night City with additional quests and characters.",
                //     GameId = 3
                // },
                // new DLC
                // {
                //     Id = 6,
                //     DLCName = "Cyberpunk: Beyond the Wall",
                //     ReleaseDate = new DateTime(2022, 1, 20),
                //     Price = 24.99m,
                //     Description = "Venture beyond the city limits and explore the wastelands.",
                //     GameId = 3
                // },

                // // DLCs for "Doom Eternal"
                // new DLC
                // {
                //     Id = 7,
                //     DLCName = "Doom Eternal: Hell's Ascent",
                //     ReleaseDate = new DateTime(2021, 5, 10),
                //     Price = 19.99m,
                //     Description = "Climb through the new challenges and face tougher demons.",
                //     GameId = 4
                // },
                // new DLC
                // {
                //     Id = 8,
                //     DLCName = "Doom Eternal: The Slayer's Return",
                //     ReleaseDate = new DateTime(2021, 12, 20),
                //     Price = 19.99m,
                //     Description = "Return to the origin of the Slayer and discover his roots.",
                //     GameId = 4
                // },

                // // DLCs for "Assassin's Creed Valhalla"
                // new DLC
                // {
                //     Id = 9,
                //     DLCName = "AC Valhalla: Rise of the Druids",
                //     ReleaseDate = new DateTime(2021, 5, 13),
                //     Price = 24.99m,
                //     Description = "Travel to Ireland and confront the Druid cult.",
                //     GameId = 5
                // },
                // new DLC
                // {
                //     Id = 10,
                //     DLCName = "AC Valhalla: The Siege of Paris",
                //     ReleaseDate = new DateTime(2021, 8, 12),
                //     Price = 24.99m,
                //     Description = "Invade the fortified city of Paris and shape its future.",
                //     GameId = 5
                // },

                // // DLCs for "Grand Theft Auto V"
                // new DLC
                // {
                //     Id = 13,
                //     DLCName = "GTA V: The Diamond Casino Heist",
                //     ReleaseDate = new DateTime(2019, 12, 12),
                //     Price = 19.99m,
                //     Description = "Plan and execute the ultimate heist at the Diamond Casino in Los Santos.",
                //     GameId = 7
                // },
                // new DLC
                // {
                //     Id = 14,
                //     DLCName = "GTA V: The Cayo Perico Heist",
                //     ReleaseDate = new DateTime(2020, 12, 15),
                //     Price = 24.99m,
                //     Description = "Embark on a remote island heist adventure in Cayo Perico.",
                //     GameId = 7
                // },
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
                    ImageUrl = "https://example.com/path_to_second_image.jpg", // Replace with actual URL
                    Caption = "The Witcher 3: Hearts of Stone DLC Image 2",
                    DLCId = 1
                },
                new DLCImage
                {
                    Id = 3,
                    ImageUrl = "https://example.com/path_to_third_image.jpg", // Replace with actual URL
                    Caption = "The Witcher 3: Hearts of Stone DLC Image 3",
                    DLCId = 1
                }
                // new DLCImage
                // {
                //     Id = 2,
                //     ImageUrl = "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032",
                //     Caption = "The Witcher 3: Blood and Wine DLC Image",
                //     DLCId = 2
                // },
                // // DLC Images for "RDR2: Frontier Tales" and "RDR2: Legend of the East"
                // new DLCImage
                // {
                //     Id = 3,
                //     ImageUrl = "https://example.com/rdr2_frontier_tales_image.jpg",
                //     Caption = "RDR2: Frontier Tales DLC Image",
                //     DLCId = 3
                // },
                // new DLCImage
                // {
                //     Id = 4,
                //     ImageUrl = "https://example.com/rdr2_legend_of_the_east_image.jpg",
                //     Caption = "RDR2: Legend of the East DLC Image",
                //     DLCId = 4
                // },
                // // DLC Images for "Cyberpunk: Night City Stories" and "Cyberpunk: Beyond the Wall"
                // new DLCImage
                // {
                //     Id = 5,
                //     ImageUrl = "https://example.com/cyberpunk_night_city_stories_image.jpg",
                //     Caption = "Cyberpunk: Night City Stories DLC Image",
                //     DLCId = 5
                // },
                // new DLCImage
                // {
                //     Id = 6,
                //     ImageUrl = "https://example.com/cyberpunk_beyond_the_wall_image.jpg",
                //     Caption = "Cyberpunk: Beyond the Wall DLC Image",
                //     DLCId = 6
                // },
                // // DLC Images for "Doom Eternal: Hell's Ascent" and "Doom Eternal: The Slayer's Return"
                // new DLCImage
                // {
                //     Id = 7,
                //     ImageUrl = "https://example.com/doom_eternal_hells_ascent_image.jpg",
                //     Caption = "Doom Eternal: Hell's Ascent DLC Image",
                //     DLCId = 7
                // },
                // new DLCImage
                // {
                //     Id = 8,
                //     ImageUrl = "https://example.com/doom_eternal_slayers_return_image.jpg",
                //     Caption = "Doom Eternal: The Slayer's Return DLC Image",
                //     DLCId = 8
                // },
                // // DLC Images for "AC Valhalla: Rise of the Druids" and "AC Valhalla: The Siege of Paris"
                // new DLCImage
                // {
                //     Id = 9,
                //     ImageUrl = "https://example.com/ac_valhalla_rise_of_the_druids_image.jpg",
                //     Caption = "AC Valhalla: Rise of the Druids DLC Image",
                //     DLCId = 9
                // },
                // new DLCImage
                // {
                //     Id = 10,
                //     ImageUrl = "https://example.com/ac_valhalla_siege_of_paris_image.jpg",
                //     Caption = "AC Valhalla: The Siege of Paris DLC Image",
                //     DLCId = 10
                // },
                // // DLC Images for "GTA V: The Diamond Casino Heist" and "GTA V: The Cayo Perico Heist"
                // new DLCImage
                // {
                //     Id = 11,
                //     ImageUrl = "https://example.com/gta_diamond_casino_heist_image.jpg",
                //     Caption = "GTA V: The Diamond Casino Heist DLC Image",
                //     DLCId = 13
                // },
                // new DLCImage
                // {
                //     Id = 12,
                //     ImageUrl = "https://example.com/gta_cayo_perico_heist_image.jpg",
                //     Caption = "GTA V: The Cayo Perico Heist DLC Image",
                //     DLCId = 14
                // }
    // ... additional DLCImage entries as needed ...
};



            builder.Entity<DLCImage>().HasData(dlcImages);
        }
    }
}
