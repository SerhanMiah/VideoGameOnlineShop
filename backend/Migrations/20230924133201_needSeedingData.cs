using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class needSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4ac7828c-ef30-4c65-940e-bb18acf76501", "64c54c4e-9602-41cb-ba53-952f4b9830dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01fa5f64-6144-4f1d-ba71-114618795cb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac7828c-ef30-4c65-940e-bb18acf76501");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64c54c4e-9602-41cb-ba53-952f4b9830dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e90aff9-c136-4230-b972-647fe23c8848", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "94cc09c2-7cb7-42fc-a3d4-0b9034febdc0", 0, "", "", null, null, "4215e83d-3823-46e0-a47b-6f0f5b89c97d", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEE1AUf5lVhx5qSkkQdTRxVcUguZnQsVCOQ5n8T5x/7D5/r9SdyntlMhoFLZdCBRihw==", null, false, null, "e853ea0f-dee2-49cb-bf80-b2c3d8d18574", null, 0, false, "user" },
                    { "f6a354a0-387e-4709-9389-9e62f70e3dcf", 0, "", "", null, null, "5aaf346c-33be-42f0-8932-cda549e82a98", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEMrJXlpffeU2LthfdOHs3keR5+S8L9of5uAbjPXcKQogPgIGM25JYvIH3mpCIgLWMw==", null, false, null, "3da75f75-ab71-4df3-a095-a48ab65bac21", null, 0, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MainDLCImageId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[] { 2, 4.7000000000000002, "Red Dead Redemption 2: Outlaws to the End", "Join a gang of outlaws and experience new missions and adventures in the Outlaws to the End DLC.", "Rockstar Games", null, 2, null, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD FX-6300, Memory: 8 GB RAM, Graphics: Nvidia GTX 770 2GB / AMD Radeon R9 280 3GB, Storage: 150 GB available space", 19.99m, "Rockstar Games", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 12 GB RAM, Graphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB, Storage: 150 GB available space", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6561), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6583), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRatingId", "ApplicationUserId", "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "DiscountedPrice", "ESRBContentDescriptions", "HasMultiplayerSupport", "MinimumSystemRequirements", "NumberOfLocalPlayers", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 4, null, 3.7000000000000002, "https://example.com/cyberpunk2077coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6588), "Cyberpunk 2077 is an open-world action-adventure game set in a dystopian future.", "CD Projekt Red", null, null, false, "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=game3trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6588) },
                    { 4, 3, null, 4.9000000000000004, "https://example.com/skyrimcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6592), "The Elder Scrolls V: Skyrim is an open-world RPG known for its vast fantasy world.", "Bethesda Game Studios", null, null, false, "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space", 1, 39.99m, null, "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", "https://www.youtube.com/watch?v=game4trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6592) },
                    { 5, 1, null, 4.7000000000000002, "https://example.com/minecraftcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6595), "Minecraft is a sandbox game where players can build and explore blocky worlds.", "Mojang Studios", null, null, true, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space", 4, 29.99m, null, "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=game5trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6596) },
                    { 6, 4, null, 4.5999999999999996, "https://example.com/assassinscreedvalhallacoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6600), "Assassin's Creed Valhalla is an action RPG that lets you play as a Viking warrior in medieval England.", "Ubisoft Montreal", null, null, false, "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", "https://www.youtube.com/watch?v=game6trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6600) },
                    { 7, 2, null, 4.9000000000000004, "https://example.com/zeldabreathofthewildcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6604), "The Legend of Zelda: Breath of the Wild is an action-adventure game set in the expansive world of Hyrule.", "Nintendo", null, null, false, "OS: Nintendo Switch", 1, 49.99m, null, "OS: Nintendo Switch", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", "https://www.youtube.com/watch?v=game7trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6604) },
                    { 8, 1, null, 4.7000000000000002, "https://example.com/fifa22coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6608), "FIFA 22 is a sports simulation game that brings the excitement of football (soccer) to your gaming console.", "EA Vancouver", null, null, true, "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space", 4, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 22", "https://www.youtube.com/watch?v=game8trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6609) },
                    { 9, 3, null, 4.7000000000000002, "https://example.com/horizonzerodawncoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6612), "Horizon Zero Dawn is an action RPG set in a post-apocalyptic world overrun by robotic creatures.", "Guerrilla Games", null, null, false, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 1, 39.99m, null, "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", "https://www.youtube.com/watch?v=game9trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6612) },
                    { 10, 4, null, 4.7999999999999998, "https://example.com/doometernalcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6618), "DOOM Eternal is a fast-paced first-person shooter where you battle hordes of demons from Hell.", "id Software", null, null, true, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM Eternal", "https://www.youtube.com/watch?v=gFQpxbd9DBg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6618) },
                    { 11, 1, null, 4.9000000000000004, "https://example.com/amonguscoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6621), "Among Us is a multiplayer party game where players work together on a spaceship while trying to identify impostors.", "InnerSloth", null, null, true, "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", 4, 4.99m, null, "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Among Us", "https://www.youtube.com/watch?v=gFQpxbd9DBg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6622) },
                    { 12, 4, null, 4.5, "https://example.com/cyberpunk2078coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6625), "Cyberpunk 2078 is a futuristic open-world RPG with advanced technology and immersive storytelling.", "FutureTech Games", null, null, true, "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", 1, 69.99m, null, "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2078", "https://www.youtube.com/watch?v=game12trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6625) },
                    { 13, 2, null, 4.7999999999999998, "https://example.com/megaracingchampionshipcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6629), "Mega Racing Championship is an adrenaline-pumping racing game with high-speed action and stunning graphics.", "Speedster Studios", null, null, true, "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space", 2, 29.99m, null, "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mega Racing Championship", "https://www.youtube.com/watch?v=game13trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6629) },
                    { 14, 3, null, 4.9000000000000004, "https://example.com/bioshockinfinitecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6632), "BioShock Infinite is a first-person shooter with a captivating narrative and breathtaking floating cityscapes.", "Irrational Games", null, null, false, "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space", 1, 39.99m, null, "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space", new DateTime(2013, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "BioShock Infinite", "https://www.youtube.com/watch?v=game14trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6632) },
                    { 15, 1, null, 4.9000000000000004, "https://example.com/stardewvalleycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6674), "Stardew Valley is a charming farming simulation game where you can build the farm of your dreams.", "ConcernedApe", null, null, true, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", 4, 14.99m, null, "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stardew Valley", "https://www.youtube.com/watch?v=game15trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7841) },
                    { 16, 4, null, 0.0, "https://example.com/elderscrollsvicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7860), "The Elder Scrolls VI is an upcoming open-world RPG that takes players to a fantasy realm filled with magic and adventure.", "Bethesda Game Studios", null, null, false, "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space", 1, 69.99m, null, "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls VI", "https://www.youtube.com/watch?v=game16trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7860) },
                    { 17, 1, null, 4.7999999999999998, "https://example.com/minecraftcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7864), "Minecraft is a sandbox game that allows players to build and explore blocky worlds, limited only by their creativity.", "Mojang Studios", null, null, true, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*", 4, 26.99m, null, "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=game17trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7865) },
                    { 18, 3, null, 4.7000000000000002, "https://example.com/residentevilvillagecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7879), "Resident Evil Village is a survival horror game that plunges players into a mysterious village filled with supernatural threats.", "Capcom", null, null, false, "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village", "https://www.youtube.com/watch?v=game18trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7879) },
                    { 19, 3, null, 4.5999999999999996, "https://example.com/assassinscreedodysseycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7882), "Assassin's Creed: Odyssey is an action RPG set in ancient Greece, where you embark on an epic journey as a mercenary.", "Ubisoft", null, null, false, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space", 1, 49.99m, null, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed: Odyssey", "https://www.youtube.com/watch?v=game19trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7883) },
                    { 20, 4, null, 4.9000000000000004, "https://example.com/thelastofuspartiicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7886), "The Last of Us Part II is a gripping action-adventure game that continues the story of Ellie in a post-apocalyptic world.", "Naughty Dog", null, null, true, "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", "https://www.youtube.com/watch?v=game20trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7886) },
                    { 21, 2, null, 4.7000000000000002, "https://example.com/civilizationvicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7890), "Civilization VI is a turn-based strategy game that allows you to build and lead your own civilization through the ages.", "Firaxis Games", null, null, true, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space", 4, 39.99m, null, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space", new DateTime(2016, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Civilization VI", "https://www.youtube.com/watch?v=game21trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7890) },
                    { 22, 4, null, 4.7000000000000002, "https://example.com/haloinfinitecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7894), "Halo Infinite is a first-person shooter that continues the legendary Halo series with a new chapter in Master Chief's story.", "343 Industries", null, null, true, "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space", new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo Infinite", "https://www.youtube.com/watch?v=game22trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7894) },
                    { 23, 1, null, 4.9000000000000004, "https://example.com/fifa24coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7897), "FIFA 24 is the latest installment of the popular soccer simulation game, featuring updated teams, stadiums, and gameplay.", "EA Sports", null, null, true, "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space", 4, 49.99m, null, "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 24", "https://www.youtube.com/watch?v=game23trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7898) },
                    { 24, 4, null, 4.7999999999999998, "https://example.com/horizonzerodawncoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7901), "Horizon: Zero Dawn is an action RPG set in a post-apocalyptic world inhabited by robotic creatures, offering an engaging storyline.", "Guerrilla Games", null, null, false, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 1, 39.99m, null, "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon: Zero Dawn", "https://www.youtube.com/watch?v=game24trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7901) },
                    { 25, 4, null, 4.5, "https://example.com/cyberpunk2078coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7905), "Cyberpunk 2078 is a futuristic open-world RPG set in a cyber-enhanced world where you play as a mercenary navigating the city of Night City.", "CD Projekt Red", null, null, true, "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2078", "https://www.youtube.com/watch?v=game25trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7905) },
                    { 26, 1, null, 0.0, "https://example.com/zeldabreathofthewild2coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7909), "The Legend of Zelda: Breath of the Wild 2 is the highly anticipated sequel to the acclaimed action-adventure game, offering new adventures in the kingdom of Hyrule.", "Nintendo", null, null, false, "OS: Nintendo Switch", 1, 49.99m, null, "OS: Nintendo Switch", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild 2", "https://www.youtube.com/watch?v=game26trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7909) },
                    { 27, 1, null, 4.9000000000000004, "https://example.com/stardewvalleycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7912), "Stardew Valley is a farming simulation game that allows players to build and customize their own farm, interact with villagers, and enjoy rural life.", "ConcernedApe", null, null, true, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space", 4, 14.99m, null, "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space", new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stardew Valley", "https://www.youtube.com/watch?v=game27trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7912) },
                    { 28, 1, null, 4.7000000000000002, "https://example.com/minecraftdungeonscoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7916), "Minecraft: Dungeons is an action-adventure game set in the blocky world of Minecraft, featuring dungeon crawling and exploration.", "Mojang Studios", null, null, true, "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space", 4, 29.99m, null, "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space", new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft: Dungeons", "https://www.youtube.com/watch?v=game28trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7916) },
                    { 29, 3, null, 0.0, "https://example.com/overwatch2coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7919), "Overwatch 2 is a team-based first-person shooter with an engaging story, new heroes, and updated gameplay mechanics.", "Blizzard Entertainment", null, null, true, "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space", 6, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch 2", "https://www.youtube.com/watch?v=game29trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7919) },
                    { 30, 2, null, 4.7999999999999998, "https://example.com/subnauticacoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7923), "Subnautica is an underwater adventure game where you explore an alien ocean, craft equipment, and survive in a hostile environment.", "Unknown Worlds Entertainment", null, null, false, "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space", 1, 24.99m, null, "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space", new DateTime(2018, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subnautica", "https://www.youtube.com/watch?v=game30trailerurl", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7923) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0e90aff9-c136-4230-b972-647fe23c8848", "f6a354a0-387e-4709-9389-9e62f70e3dcf" });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MainDLCImageId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 4, 0.0, "The Elder Scrolls V: Skyrim - Dawnguard", "Embark on a new questline with the Dawnguard DLC for The Elder Scrolls V: Skyrim, featuring vampires, vampire hunters, and powerful artifacts.", "Bethesda Game Studios", null, 4, null, "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space", 19.99m, "Bethesda Softworks", "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space", new DateTime(2012, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 5, 0.0, "Minecraft - Explorers Pack", "Expand your blocky adventures with the Explorers Pack DLC for Minecraft, including new biomes, creatures, and building materials.", "Mojang Studios", null, 5, null, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 6, 0.0, "Assassin's Creed Valhalla - Wrath of the Norsemen", "Expand your Viking saga with the Wrath of the Norsemen DLC for Assassin's Creed Valhalla, featuring new quests, weapons, and armor.", "Ubisoft Montreal", null, 6, null, "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space", 19.99m, "Ubisoft", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space", new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 7, 0.0, "The Legend of Zelda: Breath of the Wild - Master Trials", "Embark on the Master Trials in this DLC for The Legend of Zelda: Breath of the Wild, featuring new challenges, items, and a new Master Mode.", "Nintendo", null, 7, null, "OS: Nintendo Switch", 19.99m, "Nintendo", "OS: Nintendo Switch", new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 8, 0.0, "FIFA 22 - Ultimate Team Expansion", "Enhance your FIFA 22 experience with the Ultimate Team Expansion DLC, featuring new player cards, stadiums, and challenges.", "EA Vancouver", null, 8, null, "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space", 14.99m, "Electronic Arts", "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 9, 0.0, "Horizon Zero Dawn - Frozen Wilds Expansion", "Venture into the icy wilderness with the Frozen Wilds Expansion DLC for Horizon Zero Dawn, featuring new quests, creatures, and gear.", "Guerrilla Games", null, 9, null, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 14.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 10, 0.0, "DOOM Eternal - Inferno's Fury Expansion", "Unleash the fury of Hell with new weapons and challenges in the Inferno's Fury Expansion for DOOM Eternal.", "id Software", null, 10, null, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space", 19.99m, "Bethesda Softworks", "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 11, 0.0, "Among Us - Galactic Adventures Pack", "Embark on new adventures in space with the Galactic Adventures Pack for Among Us, featuring new maps and roles.", "InnerSloth", null, 11, null, "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", 9.99m, "InnerSloth", "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 12, 0.0, "Cyberpunk 2078 - Night City Chronicles", "Dive deeper into the mysteries of Night City with new stories, characters, and cyber-enhancements in the Night City Chronicles DLC for Cyberpunk 2078.", "FutureTech Games", null, 12, null, "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", 24.99m, "FutureTech Games", "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 13, 0.0, "Mega Racing Championship - Turbo Boost Pack", "Rev up your engines with the Turbo Boost Pack for Mega Racing Championship, featuring new vehicles and high-speed tracks.", "Speedster Studios", null, 13, null, "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space", 9.99m, "Speedster Studios", "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 14, 0.0, "BioShock Infinite - Clash in the Clouds", "Take on challenging arena battles in the Clash in the Clouds DLC for BioShock Infinite, featuring new maps, enemies, and rewards.", "Irrational Games", null, 14, null, "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space", 9.99m, "2K Games", "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space", new DateTime(2013, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 15, 0.0, "Stardew Valley - Greenhouse Expansion", "Expand your farming capabilities with the Greenhouse Expansion DLC for Stardew Valley, allowing year-round crop growth.", "ConcernedApe", null, 15, null, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", 4.99m, "ConcernedApe", "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 16, 0.0, "The Elder Scrolls VI - Knights of Tamriel Expansion", "Embark on a quest to join the legendary Knights of Tamriel in this expansion for The Elder Scrolls VI, introducing new lands, quests, and foes.", "Bethesda Game Studios", null, 16, null, "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space", 29.99m, "Bethesda Softworks", "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 17, 0.0, "Minecraft - Nether Update", "Explore the treacherous Nether dimension with the Nether Update DLC for Minecraft, featuring new biomes, mobs, and resources.", "Mojang Studios", null, 17, null, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5", new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 18, 0.0, "Resident Evil Village - Nightmares Unleashed", "Survive new horrors in the Nightmares Unleashed DLC for Resident Evil Village, featuring additional story content, enemies, and challenges.", "Capcom", null, 18, null, "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space", 14.99m, "Capcom", "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 19, 0.0, "Assassin's Creed: Odyssey - Legacy of the First Blade", "Uncover the secrets of the first Assassins in the Legacy of the First Blade DLC for Assassin's Creed: Odyssey, featuring new storylines and abilities.", "Ubisoft", null, 19, null, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space", 19.99m, "Ubisoft", "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space", new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 20, 0.0, "The Last of Us Part II - Left Behind Epilogue", "Explore the untold story of Ellie and Riley in the Left Behind Epilogue DLC for The Last of Us Part II, featuring new characters and challenges.", "Naughty Dog", null, 20, null, "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space", 9.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space", new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 21, 0.0, "Civilization VI - Rise and Fall Expansion", "Expand your empire with the Rise and Fall expansion for Civilization VI, introducing new civilizations, leaders, and gameplay features.", "Firaxis Games", null, 21, null, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space", 29.99m, "2K Games", "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space", new DateTime(2018, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 22, 0.0, "Halo Infinite - Spartan Ops Expansion", "Continue the adventure in the Halo universe with the Spartan Ops Expansion for Halo Infinite, featuring new missions, weapons, and multiplayer maps.", "343 Industries", null, 22, null, "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space", 19.99m, "Xbox Game Studios", "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 23, 0.0, "FIFA 24 - World Cup Expansion", "Experience the excitement of the World Cup with the World Cup Expansion for FIFA 24, featuring updated teams, stadiums, and tournament modes.", "EA Sports", null, 23, null, "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space", 14.99m, "Electronic Arts", "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 24, 0.0, "Horizon: Zero Dawn - Frozen Wilds Expansion", "Embark on a new journey in the Frozen Wilds Expansion for Horizon: Zero Dawn, featuring a new icy region, machines, and quests.", "Guerrilla Games", null, 24, null, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 19.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 25, 0.0, "Cyberpunk 2078 - Night City Stories", "Delve deeper into Night City with the Night City Stories DLC for Cyberpunk 2078, featuring new missions, characters, and cyber-enhancements.", "CD Projekt Red", null, 25, null, "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space", 19.99m, "CD Projekt", "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 26, 0.0, "The Legend of Zelda: Breath of the Wild 2 - Secrets of Hyrule", "Uncover the hidden secrets of Hyrule with new quests, dungeons, and mysteries in the Secrets of Hyrule DLC for Breath of the Wild 2.", "Nintendo", null, 26, null, "OS: Nintendo Switch", 14.99m, "Nintendo", "OS: Nintendo Switch", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 27, 0.0, "Stardew Valley - Farming Expansion Pack", "Expand your farm and experiences in Stardew Valley with the Farming Expansion Pack, introducing new crops, animals, and events.", "ConcernedApe", null, 27, null, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space", 9.99m, "ConcernedApe", "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 28, 4.5, "Minecraft: Dungeons - Jungle Awakens", "Embark on a journey through the dense jungles of Minecraft with new adventures and challenges in the Jungle Awakens DLC.", "Mojang Studios", null, 28, null, "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 29, 0.0, "Overwatch 2 - Heroes Unleashed", "Experience new heroes, maps, and intense battles in the Heroes Unleashed DLC for Overwatch 2.", "Blizzard Entertainment", null, 29, null, "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space", 14.99m, "Blizzard Entertainment", "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 30, 0.0, "Subnautica: Below Zero", "Continue your underwater adventures with Subnautica: Below Zero, featuring a new frozen environment and mysteries to uncover.", "Unknown Worlds Entertainment", null, 30, null, "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space", 19.99m, "Unknown Worlds Entertainment", "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space", new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 31, 0.0, "Cyberpunk 2077 - Night City Chronicles", "Experience new adventures in Night City with the Night City Chronicles DLC for Cyberpunk 2077, including new storylines, characters, and weapons.", "CD Projekt Red", null, 3, null, "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space", 19.99m, "CD Projekt", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" }
                });

            migrationBuilder.InsertData(
                table: "GameGameTags",
                columns: new[] { "GameId", "GameTagId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 13 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 2 },
                    { 9, 11 },
                    { 10, 2 },
                    { 10, 5 },
                    { 11, 9 },
                    { 11, 11 },
                    { 12, 1 },
                    { 12, 3 },
                    { 13, 6 },
                    { 13, 12 },
                    { 14, 2 },
                    { 14, 4 },
                    { 15, 8 },
                    { 15, 10 },
                    { 16, 1 },
                    { 16, 3 },
                    { 17, 4 },
                    { 18, 5 },
                    { 18, 12 },
                    { 19, 1 },
                    { 19, 3 },
                    { 20, 6 },
                    { 20, 7 },
                    { 21, 11 },
                    { 22, 1 },
                    { 22, 15 },
                    { 23, 9 },
                    { 24, 1 },
                    { 24, 3 },
                    { 25, 1 },
                    { 25, 5 },
                    { 25, 7 },
                    { 26, 1 },
                    { 26, 4 },
                    { 26, 7 },
                    { 27, 10 },
                    { 27, 13 },
                    { 28, 1 },
                    { 28, 3 },
                    { 29, 2 },
                    { 29, 15 },
                    { 30, 16 }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 11 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 2 },
                    { 9, 12 },
                    { 10, 6 },
                    { 10, 12 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 1 },
                    { 12, 3 },
                    { 13, 4 },
                    { 13, 12 },
                    { 14, 4 },
                    { 14, 6 },
                    { 15, 8 },
                    { 15, 10 },
                    { 16, 1 },
                    { 16, 3 },
                    { 17, 7 },
                    { 18, 6 },
                    { 18, 9 },
                    { 19, 1 },
                    { 19, 3 },
                    { 20, 1 },
                    { 20, 2 },
                    { 21, 11 },
                    { 22, 1 },
                    { 22, 2 },
                    { 23, 8 },
                    { 23, 9 },
                    { 24, 1 },
                    { 24, 3 },
                    { 25, 3 },
                    { 25, 7 },
                    { 26, 1 },
                    { 26, 2 },
                    { 27, 10 },
                    { 28, 1 },
                    { 28, 2 },
                    { 29, 15 },
                    { 30, 2 },
                    { 30, 16 }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 13, 5 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 5 },
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 15, 4 },
                    { 15, 5 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 4 },
                    { 16, 5 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 4 },
                    { 17, 5 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 18, 4 },
                    { 18, 5 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 19, 4 },
                    { 19, 5 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 4 },
                    { 20, 5 },
                    { 21, 1 },
                    { 21, 2 },
                    { 21, 3 },
                    { 21, 4 },
                    { 21, 5 },
                    { 22, 1 },
                    { 22, 2 },
                    { 22, 3 },
                    { 22, 4 },
                    { 22, 5 },
                    { 23, 1 },
                    { 23, 2 },
                    { 23, 3 },
                    { 23, 4 },
                    { 23, 5 },
                    { 24, 1 },
                    { 24, 2 },
                    { 24, 3 },
                    { 24, 4 },
                    { 24, 5 },
                    { 25, 1 },
                    { 25, 2 },
                    { 25, 3 },
                    { 25, 4 },
                    { 25, 5 },
                    { 26, 1 },
                    { 26, 2 },
                    { 26, 3 },
                    { 26, 4 },
                    { 26, 5 },
                    { 27, 1 },
                    { 27, 2 },
                    { 27, 3 },
                    { 27, 4 },
                    { 27, 5 },
                    { 28, 1 },
                    { 28, 2 },
                    { 28, 3 },
                    { 28, 4 },
                    { 28, 5 },
                    { 29, 1 },
                    { 29, 2 },
                    { 29, 3 },
                    { 29, 4 },
                    { 29, 5 },
                    { 30, 1 },
                    { 30, 2 },
                    { 30, 3 },
                    { 30, 4 },
                    { 30, 5 }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 15, 4 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 17, 1 },
                    { 17, 4 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 21, 1 },
                    { 22, 1 },
                    { 22, 2 },
                    { 22, 3 },
                    { 23, 1 },
                    { 23, 2 },
                    { 23, 4 },
                    { 24, 1 },
                    { 25, 1 },
                    { 25, 2 },
                    { 25, 3 },
                    { 26, 4 },
                    { 27, 1 },
                    { 27, 2 },
                    { 27, 4 },
                    { 28, 1 },
                    { 28, 4 },
                    { 29, 1 },
                    { 29, 2 },
                    { 29, 3 },
                    { 30, 1 },
                    { 30, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e90aff9-c136-4230-b972-647fe23c8848", "f6a354a0-387e-4709-9389-9e62f70e3dcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94cc09c2-7cb7-42fc-a3d4-0b9034febdc0");

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 21, 11 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 22, 15 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 29, 15 });

            migrationBuilder.DeleteData(
                table: "GameGameTags",
                keyColumns: new[] { "GameId", "GameTagId" },
                keyValues: new object[] { 30, 16 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 21, 11 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 29, 15 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 30, 16 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "GameLanguages",
                keyColumns: new[] { "GameId", "LanguageId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "GamePlatforms",
                keyColumns: new[] { "GameId", "PlatformId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e90aff9-c136-4230-b972-647fe23c8848");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a354a0-387e-4709-9389-9e62f70e3dcf");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ac7828c-ef30-4c65-940e-bb18acf76501", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01fa5f64-6144-4f1d-ba71-114618795cb1", 0, "", "", null, null, "8e1da912-18d3-4f9f-aa4e-19ea58b4af4a", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAECkaix0i0MoNa5dHxIlJPTXcBD1KFHF8Vub5JU7lsbJClR0P+xfSyDmk1f2wd939lA==", null, false, null, "308cb49b-4cb2-4aea-8e9f-ed1eeb02a6b8", null, 0, false, "user" },
                    { "64c54c4e-9602-41cb-ba53-952f4b9830dc", 0, "", "", null, null, "d7747be3-26b7-4e77-848d-dd6ebc480a04", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEKV2bqtLr+lHasOuoh3+sckufzR+e0Vxo1+NqEgWqyhldiS54tiUh6+EmDbOq87hbQ==", null, false, null, "2e05cc2b-f3f0-4304-911d-4d5c27d131e3", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 23, 13, 0, 7, 51, DateTimeKind.Utc).AddTicks(3483), new DateTime(2023, 9, 23, 13, 0, 7, 51, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 23, 13, 0, 7, 51, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 9, 23, 13, 0, 7, 51, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4ac7828c-ef30-4c65-940e-bb18acf76501", "64c54c4e-9602-41cb-ba53-952f4b9830dc" });
        }
    }
}
