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
            },
            // Seed more Games

            new Game
            {
                Id = 3,
                Title = "Cyberpunk 2077",
                Price = 49.99m,
                ReleaseDate = new DateTime(2020, 12, 10),
                Description = "Cyberpunk 2077 is an open-world action-adventure game set in a dystopian future.",
                TrailerUrl = "https://www.youtube.com/watch?v=game3trailerurl",
                Developer = "CD Projekt Red",
                AverageRating = 3.7,
                MinimumSystemRequirements = "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/cyberpunk2077coverimage.jpg"
            },
            new Game
            {
                Id = 4,
                Title = "The Elder Scrolls V: Skyrim",
                Price = 39.99m,
                ReleaseDate = new DateTime(2011, 11, 11),
                Description = "The Elder Scrolls V: Skyrim is an open-world RPG known for its vast fantasy world.",
                TrailerUrl = "https://www.youtube.com/watch?v=game4trailerurl",
                Developer = "Bethesda Game Studios",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space",
                RecommendedSystemRequirements = "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 3, // Age Rating: T - Teen
                CoverImage = "https://example.com/skyrimcoverimage.jpg"
            },
            new Game
            {
                Id = 5,
                Title = "Minecraft",
                Price = 29.99m,
                ReleaseDate = new DateTime(2011, 11, 18),
                Description = "Minecraft is a sandbox game where players can build and explore blocky worlds.",
                TrailerUrl = "https://www.youtube.com/watch?v=game5trailerurl",
                Developer = "Mojang Studios",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 1, // Age Rating: E - Everyone
                CoverImage = "https://example.com/minecraftcoverimage.jpg"
            },
            new Game
            {
            Id = 6,
            Title = "Assassin's Creed Valhalla",
            Price = 59.99m,
            ReleaseDate = new DateTime(2020, 11, 10),
            Description = "Assassin's Creed Valhalla is an action RPG that lets you play as a Viking warrior in medieval England.",
            TrailerUrl = "https://www.youtube.com/watch?v=game6trailerurl",
            Developer = "Ubisoft Montreal",
            AverageRating = 4.6,
            MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space",
            RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space",
            HasMultiplayerSupport = false,
            NumberOfLocalPlayers = 1,
            DiscountedPrice = null,
            AgeRatingId = 4, // Age Rating: M - Mature
            CoverImage = "https://example.com/assassinscreedvalhallacoverimage.jpg"
            },
            new Game
            {
                Id = 7,
                Title = "The Legend of Zelda: Breath of the Wild",
                Price = 49.99m,
                ReleaseDate = new DateTime(2017, 3, 3),
                Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game set in the expansive world of Hyrule.",
                TrailerUrl = "https://www.youtube.com/watch?v=game7trailerurl",
                Developer = "Nintendo",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Nintendo Switch",
                RecommendedSystemRequirements = "OS: Nintendo Switch",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 2, // Age Rating: E10+ - Everyone 10 and older
                CoverImage = "https://example.com/zeldabreathofthewildcoverimage.jpg"
            },
            new Game
            {
                Id = 8,
                Title = "FIFA 22",
                Price = 59.99m,
                ReleaseDate = new DateTime(2021, 10, 1),
                Description = "FIFA 22 is a sports simulation game that brings the excitement of football (soccer) to your gaming console.",
                TrailerUrl = "https://www.youtube.com/watch?v=game8trailerurl",
                Developer = "EA Vancouver",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 1, // Age Rating: E - Everyone
                CoverImage = "https://example.com/fifa22coverimage.jpg"
            },
            new Game
            {
                Id = 9,
                Title = "Horizon Zero Dawn",
                Price = 39.99m,
                ReleaseDate = new DateTime(2020, 8, 7),
                Description = "Horizon Zero Dawn is an action RPG set in a post-apocalyptic world overrun by robotic creatures.",
                TrailerUrl = "https://www.youtube.com/watch?v=game9trailerurl",
                Developer = "Guerrilla Games",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 3, // Age Rating: T - Teen
                CoverImage = "https://example.com/horizonzerodawncoverimage.jpg"
            },
            new Game
            {
                Id = 10,
                Title = "DOOM Eternal",
                Price = 49.99m,
                ReleaseDate = new DateTime(2020, 3, 20),
                Description = "DOOM Eternal is a fast-paced first-person shooter where you battle hordes of demons from Hell.",
                TrailerUrl = "https://www.youtube.com/watch?v=gFQpxbd9DBg",
                Developer = "id Software",
                AverageRating = 4.8,
                MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/doometernalcoverimage.jpg"
            },
            new Game
            {
                Id = 11,
                Title = "Among Us",
                Price = 4.99m,
                ReleaseDate = new DateTime(2018, 6, 15),
                Description = "Among Us is a multiplayer party game where players work together on a spaceship while trying to identify impostors.",
                TrailerUrl = "https://www.youtube.com/watch?v=gFQpxbd9DBg",
                Developer = "InnerSloth",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 1, // Age Rating: E - Everyone
                CoverImage = "https://example.com/amonguscoverimage.jpg"
            },
            // Seed more Games
                new Game
                {
                    Id = 12,
                    Title = "Cyberpunk 2078",
                    Price = 69.99m,
                    ReleaseDate = new DateTime(2022, 9, 15),
                    Description = "Cyberpunk 2078 is a futuristic open-world RPG with advanced technology and immersive storytelling.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game12trailerurl",
                    Developer = "FutureTech Games",
                    AverageRating = 4.5,
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 4, // Age Rating: M - Mature
                    CoverImage = "https://example.com/cyberpunk2078coverimage.jpg"
                },
                new Game
                {
                    Id = 13,
                    Title = "Mega Racing Championship",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2022, 5, 20),
                    Description = "Mega Racing Championship is an adrenaline-pumping racing game with high-speed action and stunning graphics.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game13trailerurl",
                    Developer = "Speedster Studios",
                    AverageRating = 4.8,
                    MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 2,
                    DiscountedPrice = null,
                    AgeRatingId = 2, // Age Rating: E10+ - Everyone 10 and older
                    CoverImage = "https://example.com/megaracingchampionshipcoverimage.jpg"
                },
                new Game
                {
                    Id = 14,
                    Title = "BioShock Infinite",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2013, 3, 26),
                    Description = "BioShock Infinite is a first-person shooter with a captivating narrative and breathtaking floating cityscapes.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game14trailerurl",
                    Developer = "Irrational Games",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 3, // Age Rating: T - Teen
                    CoverImage = "https://example.com/bioshockinfinitecoverimage.jpg"
                },
                new Game
                {
                    Id = 15,
                    Title = "Stardew Valley",
                    Price = 14.99m,
                    ReleaseDate = new DateTime(2016, 2, 26),
                    Description = "Stardew Valley is a charming farming simulation game where you can build the farm of your dreams.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game15trailerurl",
                    Developer = "ConcernedApe",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 4,
                    DiscountedPrice = null,
                    AgeRatingId = 1, // Age Rating: E - Everyone
                    CoverImage = "https://example.com/stardewvalleycoverimage.jpg"
                },

            new Game
            {
                Id = 16,
                Title = "The Elder Scrolls VI",
                Price = 69.99m,
                ReleaseDate = new DateTime(2023, 11, 15),
                Description = "The Elder Scrolls VI is an upcoming open-world RPG that takes players to a fantasy realm filled with magic and adventure.",
                TrailerUrl = "https://www.youtube.com/watch?v=game16trailerurl",
                Developer = "Bethesda Game Studios",
                AverageRating = 0, // To be updated once the game is released.
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/elderscrollsvicoverimage.jpg"
            },
            new Game
            {
                Id = 17,
                Title = "Minecraft",
                Price = 26.99m,
                ReleaseDate = new DateTime(2011, 11, 18),
                Description = "Minecraft is a sandbox game that allows players to build and explore blocky worlds, limited only by their creativity.",
                TrailerUrl = "https://www.youtube.com/watch?v=game17trailerurl",
                Developer = "Mojang Studios",
                AverageRating = 4.8,
                MinimumSystemRequirements = "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 1, // Age Rating: E - Everyone
                CoverImage = "https://example.com/minecraftcoverimage.jpg"
            },
            new Game
            {
                Id = 18,
                Title = "Resident Evil Village",
                Price = 49.99m,
                ReleaseDate = new DateTime(2021, 5, 7),
                Description = "Resident Evil Village is a survival horror game that plunges players into a mysterious village filled with supernatural threats.",
                TrailerUrl = "https://www.youtube.com/watch?v=game18trailerurl",
                Developer = "Capcom",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 3, // Age Rating: T - Teen
                CoverImage = "https://example.com/residentevilvillagecoverimage.jpg"
            },
            new Game
            {
                Id = 19,
                Title = "Assassin's Creed: Odyssey",
                Price = 49.99m,
                ReleaseDate = new DateTime(2018, 10, 5),
                Description = "Assassin's Creed: Odyssey is an action RPG set in ancient Greece, where you embark on an epic journey as a mercenary.",
                TrailerUrl = "https://www.youtube.com/watch?v=game19trailerurl",
                Developer = "Ubisoft",
                AverageRating = 4.6,
                MinimumSystemRequirements = "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space",
                RecommendedSystemRequirements = "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 3, // Age Rating: T - Teen
                CoverImage = "https://example.com/assassinscreedodysseycoverimage.jpg"
            },
            new Game
            {
                Id = 20,
                Title = "The Last of Us Part II",
                Price = 59.99m,
                ReleaseDate = new DateTime(2020, 6, 19),
                Description = "The Last of Us Part II is a gripping action-adventure game that continues the story of Ellie in a post-apocalyptic world.",
                TrailerUrl = "https://www.youtube.com/watch?v=game20trailerurl",
                Developer = "Naughty Dog",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/thelastofuspartiicoverimage.jpg"
            },
            new Game
            {
                Id = 21,
                Title = "Civilization VI",
                Price = 39.99m,
                ReleaseDate = new DateTime(2016, 10, 21),
                Description = "Civilization VI is a turn-based strategy game that allows you to build and lead your own civilization through the ages.",
                TrailerUrl = "https://www.youtube.com/watch?v=game21trailerurl",
                Developer = "Firaxis Games",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space",
                RecommendedSystemRequirements = "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 2, // Age Rating: E10+ - Everyone 10 and older
                CoverImage = "https://example.com/civilizationvicoverimage.jpg"
            },
            new Game
            {
                Id = 22,
                Title = "Halo Infinite",
                Price = 59.99m,
                ReleaseDate = new DateTime(2021, 12, 8),
                Description = "Halo Infinite is a first-person shooter that continues the legendary Halo series with a new chapter in Master Chief's story.",
                TrailerUrl = "https://www.youtube.com/watch?v=game22trailerurl",
                Developer = "343 Industries",
                AverageRating = 4.7,
                MinimumSystemRequirements = "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/haloinfinitecoverimage.jpg"
            },
            new Game
            {
                Id = 23,
                Title = "FIFA 24",
                Price = 49.99m,
                ReleaseDate = new DateTime(2023, 9, 15),
                Description = "FIFA 24 is the latest installment of the popular soccer simulation game, featuring updated teams, stadiums, and gameplay.",
                TrailerUrl = "https://www.youtube.com/watch?v=game23trailerurl",
                Developer = "EA Sports",
                AverageRating = 4.9,
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space",
                HasMultiplayerSupport = true,
                NumberOfLocalPlayers = 4,
                DiscountedPrice = null,
                AgeRatingId = 1, // Age Rating: E - Everyone
                CoverImage = "https://example.com/fifa24coverimage.jpg"
            },
            new Game
            {
                Id = 24,
                Title = "Horizon: Zero Dawn",
                Price = 39.99m,
                ReleaseDate = new DateTime(2020, 8, 7),
                Description = "Horizon: Zero Dawn is an action RPG set in a post-apocalyptic world inhabited by robotic creatures, offering an engaging storyline.",
                TrailerUrl = "https://www.youtube.com/watch?v=game24trailerurl",
                Developer = "Guerrilla Games",
                AverageRating = 4.8,
                MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space",
                RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space",
                HasMultiplayerSupport = false,
                NumberOfLocalPlayers = 1,
                DiscountedPrice = null,
                AgeRatingId = 4, // Age Rating: M - Mature
                CoverImage = "https://example.com/horizonzerodawncoverimage.jpg"
            },
            new Game
                {
                    Id = 25,
                    Title = "Cyberpunk 2078",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2022, 7, 15),
                    Description = "Cyberpunk 2078 is a futuristic open-world RPG set in a cyber-enhanced world where you play as a mercenary navigating the city of Night City.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game25trailerurl",
                    Developer = "CD Projekt Red",
                    AverageRating = 4.5,
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 4, // Age Rating: M - Mature
                    CoverImage = "https://example.com/cyberpunk2078coverimage.jpg"
                },
                new Game
                {
                    Id = 26,
                    Title = "The Legend of Zelda: Breath of the Wild 2",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2023, 4, 20),
                    Description = "The Legend of Zelda: Breath of the Wild 2 is the highly anticipated sequel to the acclaimed action-adventure game, offering new adventures in the kingdom of Hyrule.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game26trailerurl",
                    Developer = "Nintendo",
                    AverageRating = 0, // To be updated once the game is released.
                    MinimumSystemRequirements = "OS: Nintendo Switch",
                    RecommendedSystemRequirements = "OS: Nintendo Switch",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1, // Age Rating: E - Everyone
                    CoverImage = "https://example.com/zeldabreathofthewild2coverimage.jpg"
                },
                new Game
                {
                    Id = 27,
                    Title = "Stardew Valley",
                    Price = 14.99m,
                    ReleaseDate = new DateTime(2016, 2, 26),
                    Description = "Stardew Valley is a farming simulation game that allows players to build and customize their own farm, interact with villagers, and enjoy rural life.",
                    TrailerUrl = "https://www.youtube.com/watch?v=game27trailerurl",
                    Developer = "ConcernedApe",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 4,
                    DiscountedPrice = null,
                    AgeRatingId = 1, // Age Rating: E - Everyone
                    CoverImage = "https://example.com/stardewvalleycoverimage.jpg"
                },
                new Game
                    {
                        Id = 28,
                        Title = "Minecraft: Dungeons",
                        Price = 29.99m,
                        ReleaseDate = new DateTime(2020, 5, 26),
                        Description = "Minecraft: Dungeons is an action-adventure game set in the blocky world of Minecraft, featuring dungeon crawling and exploration.",
                        TrailerUrl = "https://www.youtube.com/watch?v=game28trailerurl",
                        Developer = "Mojang Studios",
                        AverageRating = 4.7,
                        MinimumSystemRequirements = "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space",
                        RecommendedSystemRequirements = "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space",
                        HasMultiplayerSupport = true,
                        NumberOfLocalPlayers = 4,
                        DiscountedPrice = null,
                        AgeRatingId = 1, // Age Rating: E - Everyone
                        CoverImage = "https://example.com/minecraftdungeonscoverimage.jpg"
                    },
                    new Game
                    {
                        Id = 29,
                        Title = "Overwatch 2",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2023, 2, 15),
                        Description = "Overwatch 2 is a team-based first-person shooter with an engaging story, new heroes, and updated gameplay mechanics.",
                        TrailerUrl = "https://www.youtube.com/watch?v=game29trailerurl",
                        Developer = "Blizzard Entertainment",
                        AverageRating = 0, // To be updated once the game is released.
                        MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space",
                        RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space",
                        HasMultiplayerSupport = true,
                        NumberOfLocalPlayers = 6,
                        DiscountedPrice = null,
                        AgeRatingId = 3, // Age Rating: T - Teen
                        CoverImage = "https://example.com/overwatch2coverimage.jpg"
                    },
                    new Game
                    {
                        Id = 30,
                        Title = "Subnautica",
                        Price = 24.99m,
                        ReleaseDate = new DateTime(2018, 1, 23),
                        Description = "Subnautica is an underwater adventure game where you explore an alien ocean, craft equipment, and survive in a hostile environment.",
                        TrailerUrl = "https://www.youtube.com/watch?v=game30trailerurl",
                        Developer = "Unknown Worlds Entertainment",
                        AverageRating = 4.8,
                        MinimumSystemRequirements = "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space",
                        RecommendedSystemRequirements = "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space",
                        HasMultiplayerSupport = false,
                        NumberOfLocalPlayers = 1,
                        DiscountedPrice = null,
                        AgeRatingId = 2, // Age Rating: E10+ - Everyone 10 and older
                        CoverImage = "https://example.com/subnauticacoverimage.jpg"
                    }
                    // End of Game Seeding data
};

            // Loop through each game and associate all available languages
            var gameLanguages = new List<GameLanguage>();
            foreach (var game in games)
            {
                foreach (var language in languages)
                {
                    gameLanguages.Add(new GameLanguage { GameId = game.Id, LanguageId = language.Id });
                }
            }

            // Seed GameGameTag entities
            var gameGameTags = new List<GameGameTag>
            {
                // Tags done
                // The Witcher 3
                new GameGameTag { GameId = 1, GameTagId = 1 }, // Tag: Open World
                new GameGameTag { GameId = 1, GameTagId = 2 }, // Tag: Multiplayer
                new GameGameTag { GameId = 1, GameTagId = 3 },  // Tag: Single Player

                // Red Dead Redemption 2
                new GameGameTag { GameId = 2, GameTagId = 1 }, // Tag: Open World
                new GameGameTag { GameId = 2, GameTagId = 2 }, // Tag: Multiplayer
                new GameGameTag { GameId = 2, GameTagId = 3 },  // Tag: Single Player

                // Game Tags for Cyberpunk 2077

                new GameGameTag {GameId = 3, GameTagId = 1},  // Open World
                new GameGameTag {GameId = 3, GameTagId = 5},  // Sci-Fi
                new GameGameTag {GameId = 3, GameTagId = 6 }, // Horror

                new GameGameTag { GameId = 4, GameTagId = 3 }, // Fantasy
                new GameGameTag { GameId = 4, GameTagId = 2 }, // RPG
                new GameGameTag { GameId = 4, GameTagId = 13 }, // Single Player

                // Minecraft
                new GameGameTag { GameId = 5, GameTagId = 10 }, // Sandbox
                new GameGameTag { GameId = 5, GameTagId = 9 }, // Building

                // Assassin's Creed Valhalla
                new GameGameTag { GameId = 6, GameTagId = 2 }, // Action
                new GameGameTag { GameId = 6, GameTagId = 3 }, // RPG

                // The Legend of Zelda: Breath of the Wild
                new GameGameTag { GameId = 7, GameTagId = 2 }, // Action
                new GameGameTag { GameId = 7, GameTagId = 4 }, // Adventure

                // FIFA 22
                new GameGameTag { GameId = 8, GameTagId = 8 }, // Sports
                new GameGameTag { GameId = 8, GameTagId = 7 }, // Simulation

                // Horizon Zero Dawn
                new GameGameTag { GameId = 9, GameTagId = 2 }, // Action
                new GameGameTag { GameId = 9, GameTagId = 11 }, // Sci-Fi

                    // DOOM Eternal
                new GameGameTag { GameId = 10, GameTagId = 2 }, // Action
                new GameGameTag { GameId = 10, GameTagId = 5 }, // First-Person

                // Among Us
                new GameGameTag { GameId = 11, GameTagId = 9 }, // Multiplayer
                new GameGameTag { GameId = 11, GameTagId = 11 }, // Party

                // Cyberpunk 2078
                new GameGameTag { GameId = 12, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 12, GameTagId = 3 }, // RPG

                // Mega Racing Championship
                new GameGameTag { GameId = 13, GameTagId = 6 }, // Racing
                new GameGameTag { GameId = 13, GameTagId = 12 }, // Sports

                // BioShock Infinite
                new GameGameTag { GameId = 14, GameTagId = 2 }, // Action
                new GameGameTag { GameId = 14, GameTagId = 4 }, // Adventure

                // Stardew Valley
                new GameGameTag { GameId = 15, GameTagId = 8 }, // Simulation
                new GameGameTag { GameId = 15, GameTagId = 10 }, // Indie

                // The Elder Scrolls VI
                new GameGameTag { GameId = 16, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 16, GameTagId = 3 }, // RPG

                // Minecraft
                new GameGameTag { GameId = 17, GameTagId = 4 }, // Sandbox

                // Resident Evil Village
                new GameGameTag { GameId = 18, GameTagId = 5 }, // Horror
                new GameGameTag { GameId = 18, GameTagId = 12 }, // Survival

                // Assassin's Creed: Odyssey
                new GameGameTag { GameId = 19, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 19, GameTagId = 3 }, // RPG

                // The Last of Us Part II
                new GameGameTag { GameId = 20, GameTagId = 7 }, // Action-Adventure
                new GameGameTag { GameId = 20, GameTagId = 6 }, // Horror

                // Civilization VI
                new GameGameTag { GameId = 21, GameTagId = 11 }, // Strategy

                // Halo Infinite
                new GameGameTag { GameId = 22, GameTagId = 15 }, // Shooter
                new GameGameTag { GameId = 22, GameTagId = 1 }, // Open World

                // FIFA 24
                new GameGameTag { GameId = 23, GameTagId = 9 }, // Sports

                // Horizon: Zero Dawn
                new GameGameTag { GameId = 24, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 24, GameTagId = 3 }, // RPG

                // Cyberpunk 2078
                new GameGameTag { GameId = 25, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 25, GameTagId = 5 }, // Sci-Fi
                new GameGameTag { GameId = 25, GameTagId = 7 }, // Action-Adventure

                // The Legend of Zelda: Breath of the Wild 2
                new GameGameTag { GameId = 26, GameTagId = 1 }, // Open World
                new GameGameTag { GameId = 26, GameTagId = 4 }, // Fantasy
                new GameGameTag { GameId = 26, GameTagId = 7 }, // Action-Adventure

                // Stardew Valley
                new GameGameTag { GameId = 27, GameTagId = 10 }, // Simulation
                new GameGameTag { GameId = 27, GameTagId = 13 }, // Puzzle

                // Minecraft: Dungeons
                new GameGameTag { GameId = 28, GameTagId = 1 }, // Tag: Open World
                new GameGameTag { GameId = 28, GameTagId = 3 }, // Tag: Single Player

                // Overwatch 2
                new GameGameTag { GameId = 29, GameTagId = 15 }, // Tag: Shooter
                new GameGameTag { GameId = 29, GameTagId = 2 },  // Tag: Multiplayer

                // Subnautica
                new GameGameTag { GameId = 30, GameTagId = 16 } // Tag: Survival


               

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
                new GamePlatform { GameId = 2, PlatformId = 3 },  // PS4

                // CyberPunk Again
                new GamePlatform { GameId = 3, PlatformId = 1 },

                // Skyrim
                new GamePlatform { GameId = 4, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 4, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 4, PlatformId = 3 }, // PS4
                new GamePlatform { GameId = 4, PlatformId = 4 }, // Nintendo Switch

                    // Minecraft
                new GamePlatform { GameId = 5, PlatformId = 5 }, // Nintendo Switch

                // Assassin's Creed Valhalla
                new GamePlatform { GameId = 6, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 6, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 6, PlatformId = 3 }, // PS4

                // The Legend of Zelda: Breath of the Wild
                new GamePlatform { GameId = 7, PlatformId = 6 }, // Nintendo Switch

                // FIFA 22
                new GamePlatform { GameId = 8, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 8, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 8, PlatformId = 3 }, // PS4

                // Horizon Zero Dawn
                new GamePlatform { GameId = 9, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 9, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 9, PlatformId = 3 }, // PS4

                // DOOM Eternal
                new GamePlatform { GameId = 10, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 10, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 10, PlatformId = 3 }, // PS4

                // Among Us
                new GamePlatform { GameId = 11, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 11, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 11, PlatformId = 3 }, // PS4
                new GamePlatform { GameId = 11, PlatformId = 4 }, // Nintendo Switch

                // Cyberpunk 2078
                new GamePlatform { GameId = 12, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 12, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 12, PlatformId = 3 }, // PS4

                // Mega Racing Championship
                new GamePlatform { GameId = 13, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 13, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 13, PlatformId = 3 }, // PS4

                // BioShock Infinite
                new GamePlatform { GameId = 14, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 14, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 14, PlatformId = 3 }, // PS4

                // Stardew Valley
                new GamePlatform { GameId = 15, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 15, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 15, PlatformId = 3 }, // PS4
                new GamePlatform { GameId = 15, PlatformId = 4 }, // Nintendo Switch

                // The Elder Scrolls VI
                new GamePlatform { GameId = 16, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 16, PlatformId = 2 }, // Xbox Series X/S
                new GamePlatform { GameId = 16, PlatformId = 3 }, // PS5

                // Minecraft
                new GamePlatform { GameId = 17, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 17, PlatformId = 4 }, // PlayStation

                // Resident Evil Village
                new GamePlatform { GameId = 18, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 18, PlatformId = 2 }, // Xbox Series X/S
                new GamePlatform { GameId = 18, PlatformId = 3 }, // PS5

                // Assassin's Creed: Odyssey
                new GamePlatform { GameId = 19, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 19, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 19, PlatformId = 3 }, // PS4

                // The Last of Us Part II
                new GamePlatform { GameId = 20, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 20, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 20, PlatformId = 3 }, // PS4

                // Civilization VI
                new GamePlatform { GameId = 21, PlatformId = 1 }, // PC

                // Halo Infinite
                new GamePlatform { GameId = 22, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 22, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 22, PlatformId = 3 }, // PS4

                // FIFA 24
                new GamePlatform { GameId = 23, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 23, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 23, PlatformId = 4 }, // PlayStation

                // Horizon: Zero Dawn
                new GamePlatform { GameId = 24, PlatformId = 1 }, // PC

                // Cyberpunk 2078
                new GamePlatform { GameId = 25, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 25, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 25, PlatformId = 3 }, // PS4

                // The Legend of Zelda: Breath of the Wild 2
                new GamePlatform { GameId = 26, PlatformId = 4 }, // Nintendo Switch

                // Stardew Valley
                new GamePlatform { GameId = 27, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 27, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 27, PlatformId = 4 },  // Nintendo Switch

                // Minecraft: Dungeons
                new GamePlatform { GameId = 28, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 28, PlatformId = 4 }, // Nintendo Switch

                // Overwatch 2
                new GamePlatform { GameId = 29, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 29, PlatformId = 2 }, // Xbox One
                new GamePlatform { GameId = 29, PlatformId = 3 },  // PS4

                // Subnautica
                new GamePlatform { GameId = 30, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 30, PlatformId = 4 }  // Nintendo Switch
            };

            // Seed GameGenre entities
            var gameGenresAssociations = new List<GameGenre>
            {
                // The Witcher 3
                new GameGenre { GameId = 1, GenreId = 1 }, // Action
                new GameGenre { GameId = 1, GenreId = 2 }, // Adventure

                // Red Dead Redemption 2
                new GameGenre { GameId = 2, GenreId = 1 }, // Action
                new GameGenre { GameId = 2, GenreId = 2 },  // Adventure


                new GameGenre { GameId = 4, GenreId = 2 }, // Action
                new GameGenre { GameId = 4, GenreId = 3 }, // RPG
                new GameGenre { GameId = 4, GenreId = 4 }, // Adventure
                new GameGenre { GameId = 4, GenreId = 11 }, // Fantasy

                // Minecraft
                new GameGenre { GameId = 5, GenreId = 10 }, // Sandbox
                new GameGenre { GameId = 5, GenreId = 9 }, // Building

                // Assassin's Creed Valhalla
                new GameGenre { GameId = 6, GenreId = 2 }, // Action
                new GameGenre { GameId = 6, GenreId = 3 }, // RPG

                // The Legend of Zelda: Breath of the Wild
                new GameGenre { GameId = 7, GenreId = 2 }, // Action
                new GameGenre { GameId = 7, GenreId = 4 }, // Adventure

                // FIFA 22
                new GameGenre { GameId = 8, GenreId = 8 }, // Sports
                new GameGenre { GameId = 8, GenreId = 7 }, // Simulation

                // Horizon Zero Dawn
                new GameGenre { GameId = 9, GenreId = 2 }, // Action
                new GameGenre { GameId = 9, GenreId = 12 }, // Sci-Fi

                new GameGenre { GameId = 10, GenreId = 6 }, // Shooter
                new GameGenre { GameId = 10, GenreId = 12 }, // Horror

                // Among Us
                new GameGenre { GameId = 11, GenreId = 9 }, // Casual
                new GameGenre { GameId = 11, GenreId = 10 }, // Indie

                // Cyberpunk 2078
                new GameGenre { GameId = 12, GenreId = 1 }, // Action
                new GameGenre { GameId = 12, GenreId = 3 }, // RPG

                // Mega Racing Championship
                new GameGenre { GameId = 13, GenreId = 4 }, // Racing
                new GameGenre { GameId = 13, GenreId = 12 }, // Sports

                // BioShock Infinite
                new GameGenre { GameId = 14, GenreId = 6 }, // Shooter
                new GameGenre { GameId = 14, GenreId = 4 }, // Adventure

                // Stardew Valley
                new GameGenre { GameId = 15, GenreId = 8 }, // Simulation
                new GameGenre { GameId = 15, GenreId = 10 }, // Indie

                // The Elder Scrolls VI
                new GameGenre { GameId = 16, GenreId = 1 }, // Action
                new GameGenre { GameId = 16, GenreId = 3 }, // RPG

                // Minecraft
                new GameGenre { GameId = 17, GenreId = 7 }, // Sandbox

                // Resident Evil Village
                new GameGenre { GameId = 18, GenreId = 6 }, // Horror
                new GameGenre { GameId = 18, GenreId = 9 }, // Survival

                // Assassin's Creed: Odyssey
                new GameGenre { GameId = 19, GenreId = 1 }, // Action
                new GameGenre { GameId = 19, GenreId = 3 }, // RPG


                // The Last of Us Part II
                new GameGenre { GameId = 20, GenreId = 1 }, // Action
                new GameGenre { GameId = 20, GenreId = 2 }, // Adventure

                // Civilization VI
                new GameGenre { GameId = 21, GenreId = 11 }, // Strategy

                // Halo Infinite
                new GameGenre { GameId = 22, GenreId = 1 }, // Action
                new GameGenre { GameId = 22, GenreId = 2 }, // Adventure

                // FIFA 24
                new GameGenre { GameId = 23, GenreId = 8 }, // Simulation
                new GameGenre { GameId = 23, GenreId = 9 }, // Sports

                // Horizon: Zero Dawn
                new GameGenre { GameId = 24, GenreId = 1 }, // Action
                new GameGenre { GameId = 24, GenreId = 3 }, // RPG

                // Cyberpunk 2078
                new GameGenre { GameId = 25, GenreId = 3 }, // RPG
                new GameGenre { GameId = 25, GenreId = 7 }, // Shooter

                // The Legend of Zelda: Breath of the Wild 2
                new GameGenre { GameId = 26, GenreId = 1 }, // Action
                new GameGenre { GameId = 26, GenreId = 2 }, // Adventure

                // Stardew Valley
                new GameGenre { GameId = 27, GenreId = 10 }, // Simulation

                // Minecraft: Dungeons
                new GameGenre { GameId = 28, GenreId = 1 }, // Action
                new GameGenre { GameId = 28, GenreId = 2 }, // Adventure

                // Overwatch 2
                new GameGenre { GameId = 29, GenreId = 15 }, // Shooter

                // Subnautica
                new GameGenre { GameId = 30, GenreId = 2 }, // Adventure
                new GameGenre { GameId = 30, GenreId = 16 } // Survival
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
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 4.8,
                    TrailerUrl = "https://www.youtube.com/watch?v=ffdxS9R6NTE",
                },
                new DLC
                {
                    Id = 2,
                    DLCName = "Red Dead Redemption 2: Outlaws to the End",
                    ReleaseDate = new DateTime(2019, 4, 5),
                    Price = 19.99m,
                    Description = "Join a gang of outlaws and experience new missions and adventures in the Outlaws to the End DLC.",
                    Developer = "Rockstar Games",
                    Publisher = "Rockstar Games",
                    DiscountedPrice = null,
                    GameId = 2,
                    MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-2500K / AMD FX-6300, Memory: 8 GB RAM, Graphics: Nvidia GTX 770 2GB / AMD Radeon R9 280 3GB, Storage: 150 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 12 GB RAM, Graphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB, Storage: 150 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 4.7,
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "Cyberpunk 2077"
                new DLC
                {
                    Id = 31,
                    DLCName = "Cyberpunk 2077 - Night City Chronicles",
                    ReleaseDate = new DateTime(2021, 6, 15),
                    Price = 19.99m,
                    Description = "Experience new adventures in Night City with the Night City Chronicles DLC for Cyberpunk 2077, including new storylines, characters, and weapons.",
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                    DiscountedPrice = null,
                    GameId = 3, // The ID of the "Cyberpunk 2077" game
                    MinimumSystemRequirements = "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "The Elder Scrolls V: Skyrim"
                new DLC
                {
                    Id = 4,
                    DLCName = "The Elder Scrolls V: Skyrim - Dawnguard",
                    ReleaseDate = new DateTime(2012, 6, 26),
                    Price = 19.99m,
                    Description = "Embark on a new questline with the Dawnguard DLC for The Elder Scrolls V: Skyrim, featuring vampires, vampire hunters, and powerful artifacts.",
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks",
                    DiscountedPrice = null,
                    GameId = 4, // The ID of the "The Elder Scrolls V: Skyrim" game
                    MinimumSystemRequirements = "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },


                // DLC for "Minecraft"
                new DLC
                {
                    Id = 5,
                    DLCName = "Minecraft - Explorers Pack",
                    ReleaseDate = new DateTime(2022, 2, 15),
                    Price = 9.99m,
                    Description = "Expand your blocky adventures with the Explorers Pack DLC for Minecraft, including new biomes, creatures, and building materials.",
                    Developer = "Mojang Studios",
                    Publisher = "Mojang Studios",
                    DiscountedPrice = null,
                    GameId = 5, // The ID of the "Minecraft" game
                    MinimumSystemRequirements = "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Assassin's Creed Valhalla"
                new DLC
                {
                    Id = 6,
                    DLCName = "Assassin's Creed Valhalla - Wrath of the Norsemen",
                    ReleaseDate = new DateTime(2021, 4, 20),
                    Price = 19.99m,
                    Description = "Expand your Viking saga with the Wrath of the Norsemen DLC for Assassin's Creed Valhalla, featuring new quests, weapons, and armor.",
                    Developer = "Ubisoft Montreal",
                    Publisher = "Ubisoft",
                    DiscountedPrice = null,
                    GameId = 6, // The ID of the "Assassin's Creed Valhalla" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },


                // DLC for "The Legend of Zelda: Breath of the Wild"
                new DLC
                {
                    Id = 7,
                    DLCName = "The Legend of Zelda: Breath of the Wild - Master Trials",
                    ReleaseDate = new DateTime(2017, 6, 30),
                    Price = 19.99m,
                    Description = "Embark on the Master Trials in this DLC for The Legend of Zelda: Breath of the Wild, featuring new challenges, items, and a new Master Mode.",
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    DiscountedPrice = null,
                    GameId = 7, // The ID of the "The Legend of Zelda: Breath of the Wild" game
                    MinimumSystemRequirements = "OS: Nintendo Switch",
                    RecommendedSystemRequirements = "OS: Nintendo Switch",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "FIFA 22"
                new DLC
                {
                    Id = 8,
                    DLCName = "FIFA 22 - Ultimate Team Expansion",
                    ReleaseDate = new DateTime(2021, 12, 15),
                    Price = 14.99m,
                    Description = "Enhance your FIFA 22 experience with the Ultimate Team Expansion DLC, featuring new player cards, stadiums, and challenges.",
                    Developer = "EA Vancouver",
                    Publisher = "Electronic Arts",
                    DiscountedPrice = null,
                    GameId = 8, // The ID of the "FIFA 22" game
                    MinimumSystemRequirements = "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },


                // DLC for "Horizon Zero Dawn"
                new DLC
                {
                    Id = 9,
                    DLCName = "Horizon Zero Dawn - Frozen Wilds Expansion",
                    ReleaseDate = new DateTime(2020, 11, 20),
                    Price = 14.99m,
                    Description = "Venture into the icy wilderness with the Frozen Wilds Expansion DLC for Horizon Zero Dawn, featuring new quests, creatures, and gear.",
                    Developer = "Guerrilla Games",
                    Publisher = "Sony Interactive Entertainment",
                    DiscountedPrice = null,
                    GameId = 9, // The ID of the "Horizon Zero Dawn" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "DOOM Eternal"
                new DLC
                {
                    Id = 10,
                    DLCName = "DOOM Eternal - Inferno's Fury Expansion",
                    ReleaseDate = new DateTime(2021, 5, 5),
                    Price = 19.99m,
                    Description = "Unleash the fury of Hell with new weapons and challenges in the Inferno's Fury Expansion for DOOM Eternal.",
                    Developer = "id Software",
                    Publisher = "Bethesda Softworks",
                    DiscountedPrice = null,
                    GameId = 10, // The ID of the "DOOM Eternal" game
                    MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Among Us"
                new DLC
                {
                    Id = 11,
                    DLCName = "Among Us - Galactic Adventures Pack",
                    ReleaseDate = new DateTime(2022, 2, 15),
                    Price = 9.99m,
                    Description = "Embark on new adventures in space with the Galactic Adventures Pack for Among Us, featuring new maps and roles.",
                    Developer = "InnerSloth",
                    Publisher = "InnerSloth",
                    DiscountedPrice = null,
                    GameId = 11, // The ID of the "Among Us" game
                    MinimumSystemRequirements = "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Cyberpunk 2078"
                new DLC
                {
                    Id = 12,
                    DLCName = "Cyberpunk 2078 - Night City Chronicles",
                    ReleaseDate = new DateTime(2023, 3, 10),
                    Price = 24.99m,
                    Description = "Dive deeper into the mysteries of Night City with new stories, characters, and cyber-enhancements in the Night City Chronicles DLC for Cyberpunk 2078.",
                    Developer = "FutureTech Games",
                    Publisher = "FutureTech Games",
                    DiscountedPrice = null,
                    GameId = 12, // The ID of the "Cyberpunk 2078" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "Mega Racing Championship"
                new DLC
                {
                    Id = 13,
                    DLCName = "Mega Racing Championship - Turbo Boost Pack",
                    ReleaseDate = new DateTime(2022, 7, 25),
                    Price = 9.99m,
                    Description = "Rev up your engines with the Turbo Boost Pack for Mega Racing Championship, featuring new vehicles and high-speed tracks.",
                    Developer = "Speedster Studios",
                    Publisher = "Speedster Studios",
                    DiscountedPrice = null,
                    GameId = 13, // The ID of the "Mega Racing Championship" game
                    MinimumSystemRequirements = "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "BioShock Infinite"
                new DLC
                {
                    Id = 14,
                    DLCName = "BioShock Infinite - Clash in the Clouds",
                    ReleaseDate = new DateTime(2013, 7, 30),
                    Price = 9.99m,
                    Description = "Take on challenging arena battles in the Clash in the Clouds DLC for BioShock Infinite, featuring new maps, enemies, and rewards.",
                    Developer = "Irrational Games",
                    Publisher = "2K Games",
                    DiscountedPrice = null,
                    GameId = 14, // The ID of the "BioShock Infinite" game
                    MinimumSystemRequirements = "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Stardew Valley"
                new DLC
                {
                    Id = 15,
                    DLCName = "Stardew Valley - Greenhouse Expansion",
                    ReleaseDate = new DateTime(2017, 11, 15),
                    Price = 4.99m,
                    Description = "Expand your farming capabilities with the Greenhouse Expansion DLC for Stardew Valley, allowing year-round crop growth.",
                    Developer = "ConcernedApe",
                    Publisher = "ConcernedApe",
                    DiscountedPrice = null,
                    GameId = 15, // The ID of the "Stardew Valley" game
                    MinimumSystemRequirements = "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "The Elder Scrolls VI"
                new DLC
                {
                    Id = 16,
                    DLCName = "The Elder Scrolls VI - Knights of Tamriel Expansion",
                    ReleaseDate = new DateTime(2024, 5, 15),
                    Price = 29.99m,
                    Description = "Embark on a quest to join the legendary Knights of Tamriel in this expansion for The Elder Scrolls VI, introducing new lands, quests, and foes.",
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks",
                    DiscountedPrice = null,
                    GameId = 16, // The ID of the "The Elder Scrolls VI" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Minecraft"
                new DLC
                {
                    Id = 17,
                    DLCName = "Minecraft - Nether Update",
                    ReleaseDate = new DateTime(2021, 6, 23),
                    Price = 9.99m,
                    Description = "Explore the treacherous Nether dimension with the Nether Update DLC for Minecraft, featuring new biomes, mobs, and resources.",
                    Developer = "Mojang Studios",
                    Publisher = "Mojang Studios",
                    DiscountedPrice = null,
                    GameId = 17, // The ID of the "Minecraft" game
                    MinimumSystemRequirements = "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "Resident Evil Village"
                new DLC
                {
                    Id = 18,
                    DLCName = "Resident Evil Village - Nightmares Unleashed",
                    ReleaseDate = new DateTime(2022, 3, 12),
                    Price = 14.99m,
                    Description = "Survive new horrors in the Nightmares Unleashed DLC for Resident Evil Village, featuring additional story content, enemies, and challenges.",
                    Developer = "Capcom",
                    Publisher = "Capcom",
                    DiscountedPrice = null,
                    GameId = 18, // The ID of the "Resident Evil Village" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Assassin's Creed: Odyssey"
                new DLC
                {
                    Id = 19,
                    DLCName = "Assassin's Creed: Odyssey - Legacy of the First Blade",
                    ReleaseDate = new DateTime(2019, 1, 10),
                    Price = 19.99m,
                    Description = "Uncover the secrets of the first Assassins in the Legacy of the First Blade DLC for Assassin's Creed: Odyssey, featuring new storylines and abilities.",
                    Developer = "Ubisoft",
                    Publisher = "Ubisoft",
                    DiscountedPrice = null,
                    GameId = 19, // The ID of the "Assassin's Creed: Odyssey" game
                    MinimumSystemRequirements = "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "The Last of Us Part II"
                new DLC
                {
                    Id = 20,
                    DLCName = "The Last of Us Part II - Left Behind Epilogue",
                    ReleaseDate = new DateTime(2021, 8, 28),
                    Price = 9.99m,
                    Description = "Explore the untold story of Ellie and Riley in the Left Behind Epilogue DLC for The Last of Us Part II, featuring new characters and challenges.",
                    Developer = "Naughty Dog",
                    Publisher = "Sony Interactive Entertainment",
                    DiscountedPrice = null,
                    GameId = 20, // The ID of the "The Last of Us Part II" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },

                // DLC for "Civilization VI"
                new DLC
                {
                    Id = 21,
                    DLCName = "Civilization VI - Rise and Fall Expansion",
                    ReleaseDate = new DateTime(2018, 2, 8),
                    Price = 29.99m,
                    Description = "Expand your empire with the Rise and Fall expansion for Civilization VI, introducing new civilizations, leaders, and gameplay features.",
                    Developer = "Firaxis Games",
                    Publisher = "2K Games",
                    DiscountedPrice = null,
                    GameId = 21, // The ID of the "Civilization VI" game
                    MinimumSystemRequirements = "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "Halo Infinite"
                new DLC
                {
                    Id = 22,
                    DLCName = "Halo Infinite - Spartan Ops Expansion",
                    ReleaseDate = new DateTime(2022, 6, 15),
                    Price = 19.99m,
                    Description = "Continue the adventure in the Halo universe with the Spartan Ops Expansion for Halo Infinite, featuring new missions, weapons, and multiplayer maps.",
                    Developer = "343 Industries",
                    Publisher = "Xbox Game Studios",
                    DiscountedPrice = null,
                    GameId = 22, // The ID of the "Halo Infinite" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "FIFA 24"
                new DLC
                {
                    Id = 23,
                    DLCName = "FIFA 24 - World Cup Expansion",
                    ReleaseDate = new DateTime(2023, 11, 15),
                    Price = 14.99m,
                    Description = "Experience the excitement of the World Cup with the World Cup Expansion for FIFA 24, featuring updated teams, stadiums, and tournament modes.",
                    Developer = "EA Sports",
                    Publisher = "Electronic Arts",
                    DiscountedPrice = null,
                    GameId = 23, // The ID of the "FIFA 24" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "Horizon: Zero Dawn"
                new DLC
                {
                    Id = 24,
                    DLCName = "Horizon: Zero Dawn - Frozen Wilds Expansion",
                    ReleaseDate = new DateTime(2021, 3, 10),
                    Price = 19.99m,
                    Description = "Embark on a new journey in the Frozen Wilds Expansion for Horizon: Zero Dawn, featuring a new icy region, machines, and quests.",
                    Developer = "Guerrilla Games",
                    Publisher = "Sony Interactive Entertainment",
                    DiscountedPrice = null,
                    GameId = 24, // The ID of the "Horizon: Zero Dawn" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                new DLC
                {
                    Id = 25,
                    DLCName = "Cyberpunk 2078 - Night City Stories",
                    ReleaseDate = new DateTime(2023, 1, 10),
                    Price = 19.99m,
                    Description = "Delve deeper into Night City with the Night City Stories DLC for Cyberpunk 2078, featuring new missions, characters, and cyber-enhancements.",
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt",
                    DiscountedPrice = null,
                    GameId = 25, // The ID of the "Cyberpunk 2078" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                // DLC for "The Legend of Zelda: Breath of the Wild 2"
                new DLC
                {
                    Id = 26,
                    DLCName = "The Legend of Zelda: Breath of the Wild 2 - Secrets of Hyrule",
                    ReleaseDate = new DateTime(2023, 6, 30),
                    Price = 14.99m,
                    Description = "Uncover the hidden secrets of Hyrule with new quests, dungeons, and mysteries in the Secrets of Hyrule DLC for Breath of the Wild 2.",
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    DiscountedPrice = null,
                    GameId = 26, // The ID of the "The Legend of Zelda: Breath of the Wild 2" game
                    MinimumSystemRequirements = "OS: Nintendo Switch",
                    RecommendedSystemRequirements = "OS: Nintendo Switch",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                new DLC
                {
                    Id = 27,
                    DLCName = "Stardew Valley - Farming Expansion Pack",
                    ReleaseDate = new DateTime(2023, 8, 15),
                    Price = 9.99m,
                    Description = "Expand your farm and experiences in Stardew Valley with the Farming Expansion Pack, introducing new crops, animals, and events.",
                    Developer = "ConcernedApe",
                    Publisher = "ConcernedApe",
                    DiscountedPrice = null,
                    GameId = 27, // The ID of the "Stardew Valley" game
                    MinimumSystemRequirements = "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },


                // DLC for "Minecraft: Dungeons"
                new DLC
                {
                    Id = 28,
                    DLCName = "Minecraft: Dungeons - Jungle Awakens",
                    ReleaseDate = new DateTime(2020, 7, 1),
                    Price = 9.99m,
                    Description = "Embark on a journey through the dense jungles of Minecraft with new adventures and challenges in the Jungle Awakens DLC.",
                    Developer = "Mojang Studios",
                    Publisher = "Mojang Studios",
                    DiscountedPrice = null,
                    GameId = 28, // The ID of the "Minecraft: Dungeons" game
                    MinimumSystemRequirements = "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 4.5, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                new DLC
                {
                    Id = 29,
                    DLCName = "Overwatch 2 - Heroes Unleashed",
                    ReleaseDate = new DateTime(2023, 4, 15),
                    Price = 14.99m,
                    Description = "Experience new heroes, maps, and intense battles in the Heroes Unleashed DLC for Overwatch 2.",
                    Developer = "Blizzard Entertainment",
                    Publisher = "Blizzard Entertainment",
                    DiscountedPrice = null,
                    GameId = 29, // The ID of the "Overwatch 2" game
                    MinimumSystemRequirements = "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0,
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
                },
                new DLC
                {
                    Id = 30,
                    DLCName = "Subnautica: Below Zero",
                    ReleaseDate = new DateTime(2021, 5, 14),
                    Price = 19.99m,
                    Description = "Continue your underwater adventures with Subnautica: Below Zero, featuring a new frozen environment and mysteries to uncover.",
                    Developer = "Unknown Worlds Entertainment",
                    Publisher = "Unknown Worlds Entertainment",
                    DiscountedPrice = null,
                    GameId = 30, // The ID of the "Subnautica" game
                    MinimumSystemRequirements = "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space",
                    DLCGallery = new List<DLCImage>(),
                    MainDLCImageId = null,
                    AverageRating = 0, // You can update this once the DLC is rated.
                    TrailerUrl = "https://www.youtube.com/watch?v=exampledlctrailerurl",
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