using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameImages_GameImageId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameImageId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76a3abba-ecce-48b9-94b2-2bf4051cde83", "fe682112-d074-4768-ad25-5865af0ec009" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f1b1e7-ad65-491c-985e-502551ac513c");

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a3abba-ecce-48b9-94b2-2bf4051cde83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe682112-d074-4768-ad25-5865af0ec009");

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
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "GameImageId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Games",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Developer",
                table: "Games",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "GameGameTags",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGameTags", x => new { x.GameId, x.GameTagId });
                    table.ForeignKey(
                        name: "FK_GameGameTags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGameTags_Tags_GameTagId",
                        column: x => x.GameTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1317016f-f3a4-4c23-8904-404e7d9ce446", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bbaf9293-aad8-4a14-b2a6-625f789fdbc3", 0, "", null, "88209005-25f2-4760-84a4-de7eea783348", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEHl3ydnczbmkE3hKITxWRphDzqSBA/sQI2DPzvLkItoJwoaCopfiBZc8HBVAV+aS/A==", null, false, null, "c6cbdd83-ebb7-4952-9239-8713fccac2b9", null, false, "user" },
                    { "d0b4c27f-ec89-40be-acda-588d50882174", 0, "", null, "aa04f91d-50a9-41a4-9691-4be88c634ff3", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAECz06zU50N3oKl34cY2kIZuzIJbQEcz+6NQKDKmXrYVML6LllRwWE/HYOX4DJxGmwQ==", null, false, null, "514cba9c-ea43-4d01-864e-4955bae159a4", null, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DLCName", "Description", "GameId", "ReleaseDate" },
                values: new object[] { "RDR2: Frontier Tales", "Experience new stories from the Wild West in the Frontier Tales expansion.", 2, new DateTime(2019, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "RDR2: Legend of the East", "Unlock the mysteries of the East in this exciting new DLC.", 2, 19.99m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Cyberpunk: Night City Stories", "Dive deeper into Night City with additional quests and characters.", 3, 12.99m, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Cyberpunk: Beyond the Wall", "Venture beyond the city limits and explore the wastelands.", 3, 24.99m, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Doom Eternal: Hell's Ascent", "Climb through the new challenges and face tougher demons.", 4, 19.99m, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Doom Eternal: The Slayer's Return", "Return to the origin of the Slayer and discover his roots.", 4, 19.99m, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "AC Valhalla: Rise of the Druids", "Travel to Ireland and confront the Druid cult.", 5, 24.99m, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "AC Valhalla: The Siege of Paris", "Invade the fortified city of Paris and shape its future.", 5, 24.99m, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "GameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "GameId", "Url" },
                values: new object[] { 2, "https://link-to-first-image-for-RDR2.com" });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GameId", "Url" },
                values: new object[] { 2, "https://link-to-second-image-for-RDR2.com" });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "Url",
                value: "https://link-to-first-image-for-doom-eternal.com");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "https://link-to-second-image-for-doom-eternal.com");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "Url",
                value: "https://link-to-first-image-for-AC-valhalla.com");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "Url",
                value: "https://link-to-second-image-for-AC-valhalla.com");

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 16, 3, "https://link-to-first-image-for-cyberpunk2077.com" },
                    { 17, 3, "https://link-to-second-image-for-cyberpunk2077.com" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CoverImage", "CreatedAt", "Description", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[] { 4.7999999999999998, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp", new DateTime(2023, 9, 8, 12, 37, 50, 753, DateTimeKind.Utc).AddTicks(9634), "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.", "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space", 29.99m, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=c0i88t0Kacs", new DateTime(2023, 9, 8, 12, 37, 50, 753, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[] { 4.9000000000000004, "https://www.rockstargames.com/reddeadredemption2/rockstar_games/r_d_r_logo.jpg", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(921), "Red Dead Redemption 2 is an action-adventure game set in the Wild West.", "Rockstar Games", true, "OS: Windows 7 (64-bit), Processor: Intel Core i5-2500K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770, Storage: 150 GB available space", 49.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 150 GB available space", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://www.youtube.com/watch?v=eaW0tYpxyp0", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[] { 4.0, "https://www.cyberpunk.net/build/images/home/title-c-logo-8d1c4e3341.svg", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(931), "Cyberpunk 2077 is a role-playing video game developed and published by CD Projekt.", "CD Projekt Red", false, "OS: Windows 7 (64-bit), Processor: Intel Core i5-3570K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780, Storage: 70 GB available space", 59.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=vjF9GgrY9c0", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AgeRatingId", "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[] { 2, 4.5, "https://bethesda.net/game/doom2016", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(935), "Doom Eternal is a first-person shooter video game developed by id Software and published by Bethesda Softworks.", "id Software", "OS: Windows 7 (64-bit), Processor: Intel Core i5-2400, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670, Storage: 50 GB available space", 39.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060, Storage: 50 GB available space", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", "https://www.youtube.com/watch?v=FkklG9MA0vM", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AgeRatingId", "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[] { 2, 4.5999999999999996, "https://www.ubisoft.com/en-gb/game/assassins-creed/valhalla", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(938), "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal.", "Ubisoft", false, "OS: Windows 10 (64-bit), Processor: Intel Core i5-4460, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960, Storage: 50 GB available space", 49.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1080, Storage: 50 GB available space", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", "https://www.youtube.com/watch?v=SSYlfRq4ysA", new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Medieval" },
                    { 3, "Story Rich" },
                    { 4, "Sci-Fi" },
                    { 5, "Post-Apocalyptic" },
                    { 6, "Horror" },
                    { 7, "Survival" },
                    { 8, "Retro" },
                    { 9, "Puzzle" },
                    { 10, "Platformer" },
                    { 11, "Shooter" },
                    { 12, "Strategy" },
                    { 13, "RPG" },
                    { 14, "VR" },
                    { 15, "Multiplayer" },
                    { 16, "Singleplayer" },
                    { 17, "Racing" },
                    { 18, "Sports" },
                    { 19, "Open World" },
                    { 20, "Sandbox" },
                    { 21, "City Builder" },
                    { 22, "Management" },
                    { 23, "Simulation" },
                    { 24, "Turn-Based" },
                    { 25, "Roguelike" },
                    { 26, "Narrative" },
                    { 27, "Visual Novel" },
                    { 28, "Anime" },
                    { 29, "Pixel Art" },
                    { 30, "Crafting" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1317016f-f3a4-4c23-8904-404e7d9ce446", "d0b4c27f-ec89-40be-acda-588d50882174" });

            migrationBuilder.CreateIndex(
                name: "IX_GameGameTags_GameTagId",
                table: "GameGameTags",
                column: "GameTagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGameTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1317016f-f3a4-4c23-8904-404e7d9ce446", "d0b4c27f-ec89-40be-acda-588d50882174" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbaf9293-aad8-4a14-b2a6-625f789fdbc3");

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1317016f-f3a4-4c23-8904-404e7d9ce446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b4c27f-ec89-40be-acda-588d50882174");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Developer",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameImageId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76a3abba-ecce-48b9-94b2-2bf4051cde83", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84f1b1e7-ad65-491c-985e-502551ac513c", 0, "", null, "71b2e319-8140-4920-98fc-9cc73a773bfa", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEBaBfnaQCr44pGBrLZwN3zDPYOoIGnU5O1t0KIMy6UbeV/UASz9VdrRGFqUNrLxd9w==", null, false, null, "7517bc29-0abf-4a9e-8e23-d2aba2b25dd8", null, false, "user" },
                    { "fe682112-d074-4768-ad25-5865af0ec009", 0, "", null, "f7088b49-6f03-497d-a8d1-d192847f25f1", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEIypW6Ri6R8IyrtIlMTTsx3Qq3NTMSUvMfmwCG6EGX1HiVRFpQgSKSfJ8OB9yHBorA==", null, false, null, "09e4ec42-1be0-438f-b0d4-f23caa69dbf5", null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "DLCImages",
                columns: new[] { "Id", "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[,]
                {
                    { 3, "Red Dead Redemption 2: Undead Nightmare DLC Image", 3, null, "https://example.com/dlc_image_3.jpg" },
                    { 4, "Red Dead Redemption 2: The Ballad of Gay Tony DLC Image", 4, null, "https://example.com/dlc_image_4.jpg" },
                    { 5, "The Legend of Zelda: Breath of the Wild - Expansion Pass DLC Image", 5, null, "https://example.com/dlc_image_5.jpg" },
                    { 6, "The Legend of Zelda: Breath of the Wild - The Champions' Ballad DLC Image", 6, null, "https://example.com/dlc_image_6.jpg" },
                    { 7, "Grand Theft Auto V: The Diamond Casino Heist DLC Image", 7, null, "https://example.com/dlc_image_7.jpg" },
                    { 8, "Grand Theft Auto V: The Cayo Perico Heist DLC Image", 8, null, "https://example.com/dlc_image_8.jpg" },
                    { 9, "Minecraft: Nether Update DLC Image", 9, null, "https://example.com/dlc_image_9.jpg" },
                    { 10, "Minecraft: Caves & Cliffs Update DLC Image", 10, null, "https://example.com/dlc_image_10.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 1,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 2,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DLCName", "Description", "GameId", "ReleaseDate" },
                values: new object[] { "Red Dead Redemption 2: Undead Nightmare", "Experience an undead nightmare in the world of Red Dead Redemption 2.", 3, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Red Dead Redemption 2: The Ballad of Gay Tony", "Join the high-stakes world of nightclub entertainment in The Ballad of Gay Tony DLC.", 3, 9.99m, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "The Legend of Zelda: Breath of the Wild - Expansion Pass", "Expand your adventure with two DLC packs for The Legend of Zelda: Breath of the Wild.", 4, 19.99m, new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "The Legend of Zelda: Breath of the Wild - The Champions' Ballad", "Embark on a new quest and discover the story of the champions in The Champions' Ballad DLC.", 4, 9.99m, new DateTime(2017, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Grand Theft Auto V: The Diamond Casino Heist", "Plan and execute the most daring heist in the history of Los Santos in The Diamond Casino Heist DLC.", 5, 9.99m, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Grand Theft Auto V: The Cayo Perico Heist", "Infiltrate the remote island of Cayo Perico and pull off a monumental heist in The Cayo Perico Heist DLC.", 5, 14.99m, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Minecraft: Nether Update", "Explore the dangerous Nether dimension with new mobs, biomes, and materials in the Nether Update DLC.", 6, 4.99m, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DLCName", "Description", "GameId", "Price", "ReleaseDate" },
                values: new object[] { "Minecraft: Caves & Cliffs Update", "Discover new cave systems, mountain biomes, and blocks in the Caves & Cliffs Update DLC.", 6, 9.99m, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "GameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "GameId", "Url" },
                values: new object[] { 3, "https://assetsio.reedpopcdn.com/red-dead-redemption-2-review-1540465569009.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp" });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GameId", "Url" },
                values: new object[] { 3, "https://gaming-cdn.com/images/products/5679/616x353/red-dead-redemption-2-pc-game-rockstar-cover.jpg?v=1647026658" });

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "Url",
                value: "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wiiu_14/SI_WiiU_TheLegendOfZeldaBreathOfTheWild_image1600w.jpg");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "https://www.gamespot.com/a/uploads/scale_medium/1197/11970954/3181241-ig-lozbreathofthewildrelease-20170112.jpg");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "Url",
                value: "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png");

            migrationBuilder.UpdateData(
                table: "GameImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "Url",
                value: "https://assets.xboxservices.com/assets/0b/17/0b179504-412d-4af7-9e00-3e3d92633577.jpg?n=GTA-V_GLP-Page-Hero-1084_1920x1080.jpg");

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Cyberpunk%202077/cyberpunk_2077_unreal_engine_5_wjauye.png" },
                    { 2, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-phantom-liberty_fuqyge.webp" },
                    { 3, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp" },
                    { 4, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    { 5, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp" },
                    { 13, 3, "https://assets1.ignimgs.com/thumbs/userUploaded/2018/10/25/rdr21280-1540446855527.jpg" },
                    { 14, 3, "https://images.pushsquare.com/5cd7243587ddd/red-dead-redemption-2-how-to-start-a-new-game-guide-1.large.jpg" },
                    { 15, 3, "https://i.ytimg.com/vi/HVRzx17WHVk/maxresdefault.jpg" },
                    { 23, 4, "https://i.guim.co.uk/img/media/22d6b308c89e62e229feb220208a639836e31fd9/60_0_1800_1080/master/1800.png?width=700&quality=85&auto=format&fit=max&s=25c588a5203feea6061c32112a66ebdc" },
                    { 24, 4, "https://i2-prod.mirror.co.uk/incoming/article8309144.ece/ALTERNATES/s1200b/zelda-main.jpg" },
                    { 25, 4, "https://i.ytimg.com/vi/1RVts63WgbE/maxresdefault.jpg" },
                    { 28, 5, "https://image.api.playstation.com/vulcan/ap/rnd/202101/2019/A7bNiu2YBVKYLeEviv8DpcVg.jpg" },
                    { 29, 5, "https://d1e00ek4ebabms.cloudfront.net/production/28993ca1-a36c-4382-a18e-4e9f8bcfa1bb.jpg" },
                    { 30, 5, "https://www.theedgesusu.co.uk/wp-content/uploads/2020/08/GTA_V_Artwork_Trunk-534-1600-1.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "Description", "GameImageId", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 4.2000000000000002, "Cyberpunk 2077 is an open-world, action-adventure story set in Night City.", null, "OS: Windows 10 (64-bit), Processor: Intel Core i5-3570K or AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 3GB or AMD Radeon RX 470, Storage: 70 GB available space", 59.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790 or AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon R9 Fury, Storage: SSD + 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=ixl31324UxE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "Description", "Developer", "GameImageId", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 4.7999999999999998, "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.", "CD Projekt Red", null, false, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space", 29.99m, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=c0i88t0Kacs" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "Description", "Developer", "GameImageId", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 4.9000000000000004, "Red Dead Redemption 2 is an epic tale of life in America's unforgiving heartland.", "Rockstar Games", null, true, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 280, Storage: 150 GB available space", 49.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K 3.5 GHz or AMD Ryzen 5 1500X 3.5 GHz, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon RX 480 4GB, Storage: 150 GB available space", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://www.youtube.com/watch?v=Dw_oH5oiUSE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AgeRatingId", "AverageRating", "Description", "Developer", "GameImageId", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 1, 4.7000000000000002, "The Legend of Zelda: Breath of the Wild is an action-adventure game set in an open world.", "Nintendo", null, "N/A", 59.99m, "N/A", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", "https://www.youtube.com/watch?v=zw47_q9wbBE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AgeRatingId", "AverageRating", "Description", "Developer", "GameImageId", "HasMultiplayerSupport", "MinimumSystemRequirements", "Price", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 4, 4.7000000000000002, "Grand Theft Auto V is an action-adventure game set in an open world.", "Rockstar North", null, true, "OS: Windows 7 (64-bit), Processor: Intel Core 2 Quad CPU Q6600 2.4 GHz or AMD Phenom 9850 Quad-Core Processor 2.5 GHz, Memory: 4 GB RAM, Graphics: NVIDIA 9800 GT 1GB or AMD HD 4870 1GB, Storage: 72 GB available space", 29.99m, "OS: Windows 10 (64-bit), Processor: Intel Core i5 3470 3.2 GHz or AMD X8 FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 2GB or AMD HD7870 2GB, Storage: 72 GB available space", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V", "https://www.youtube.com/watch?v=3DBrG2YjqQA" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRatingId", "AverageRating", "Description", "Developer", "DiscountedPrice", "ESRBContentDescriptions", "GameImageId", "HasMultiplayerSupport", "MinimumSystemRequirements", "NumberOfLocalPlayers", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 6, 1, 4.5, "Minecraft is a sandbox game that allows players to build and explore virtual worlds.", "Mojang Studios", null, null, null, true, "OS: Windows 10 (64-bit), Processor: Intel Core i5-4690 or AMD A10-7800 or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series or AMD Radeon Rx 200 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space", 4, 26.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6500U or AMD A8-6600K or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 900 Series or AMD Radeon Rx 300 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=92AoX5OyiU4" },
                    { 7, 7, 4.5, "Experience the next installment of the popular FIFA football simulation game.", "EA Sports", null, null, null, true, "N/A", 4, 59.99m, null, "N/A", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 22", "https://www.youtube.com/watch?v=Apm59G6LgYo" },
                    { 8, 1, 4.5999999999999996, "Create unique Sims, build their perfect homes, and explore vibrant worlds in The Sims 4.", "Maxis", null, null, null, false, "OS: Windows XP (SP3), Processor: 1.8 GHz Intel Core 2 Duo, AMD Athlon 64 Dual-Core 4000+ or equivalent, Memory: 2 GB RAM, Graphics: NVIDIA GeForce 6600 or ATI Radeon X1300 or Intel GMA X4500, Storage: 10 GB available space", 1, 39.99m, null, "OS: Windows 7, 8, 8.1, 10 (64-bit), Processor: Intel Core i5 or faster, AMD Athlon X4, Memory: 4 GB RAM, Graphics: NVIDIA GTX 650 or better, AMD Radeon HD 7770 or better, Storage: 18 GB available space", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 4", "https://www.youtube.com/watch?v=mf19woWj1lQ" },
                    { 9, 8, 4.2999999999999998, "Join the legendary Street Fighter tournament and prove your skills in intense battles.", "Capcom", null, null, null, true, "OS: Windows 7 (64-bit), Processor: Intel Core i3-4160 @ 3.60GHz, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 480, GTX 570, GTX 670, or better, Storage: 60 GB available space", 2, 19.99m, null, "OS: Windows 7 (64-bit), Processor: Intel Core i5-4690K @3.50GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960, GTX 1060, or better, Storage: 60 GB available space", new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Street Fighter V", "https://www.youtube.com/watch?v=wYsujrF_Oj0" },
                    { 10, 9, 4.7999999999999998, "Enter a world of survival horror and face terrifying creatures in Resident Evil Village.", "Capcom", null, null, null, false, "OS: Windows 10 (64-bit), Processor: Intel Core i5-7500 or AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti with 4GB VRAM or AMD Radeon RX 560 with 4GB VRAM, DirectX: Version 12, Storage: 40 GB available space", 1, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-8700 or AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 or AMD Radeon RX 5700, DirectX: Version 12, Storage: 40 GB available space", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village", "https://www.youtube.com/watch?v=3S1QCcVee_Y" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76a3abba-ecce-48b9-94b2-2bf4051cde83", "fe682112-d074-4768-ad25-5865af0ec009" });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCImageId", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 11, null, null, "FIFA 22: Ultimate Team Expansion", "Enhance your FIFA 22 Ultimate Team with new players, packs, and challenges.", null, null, 7, null, 9.99m, null, null, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, null, null, "FIFA 22: Career Mode Expansion", "Expand your FIFA 22 Career Mode experience with new features and gameplay enhancements.", null, null, 7, null, 14.99m, null, null, new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, null, null, "The Sims 4: Seasons", "Add weather, holidays, and seasonal activities to your Sims' lives in The Sims 4: Seasons.", null, null, 8, null, 19.99m, null, null, new DateTime(2018, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, null, "The Sims 4: Get Together", "Explore a new world, meet new Sims, and join clubs in The Sims 4: Get Together.", null, null, 8, null, 14.99m, null, null, new DateTime(2015, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, null, null, "Resident Evil Village: The Mercenaries", "Take on challenging missions and survive against hordes of enemies in The Mercenaries DLC.", null, null, 10, null, 9.99m, null, null, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, null, null, "Resident Evil Village: The Tragedy of Ethan Winters", "Uncover the dark secrets of Ethan Winters' journey in The Tragedy of Ethan Winters DLC.", null, null, 10, null, 14.99m, null, null, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 31, 6, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 32, 6, "https://upload.wikimedia.org/wikipedia/en/e/e7/Steve_%28Minecraft%29.png" },
                    { 33, 6, "https://media.wired.com/photos/62e0301fb014c7f5985e3405/16:9/w_1615,h_908,c_limit/Minecraft-NFTs-Games.jpg" },
                    { 34, 6, "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2020/4/28/bjoyslzjb3uxqyg82uz2/minecraft" },
                    { 35, 6, "https://m.media-amazon.com/images/M/MV5BYWIzYjUzMGUtZjJlNy00MWVlLWJjNGEtODU1OWFiOWIwOTFjXkEyXkFqcGdeQXVyNTgyNTA4MjM@._V1_FMjpg_UX1000_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "DLCImages",
                columns: new[] { "Id", "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[,]
                {
                    { 11, "FIFA 22: Ultimate Team Expansion DLC Image", 11, null, "https://example.com/dlc_image_11.jpg" },
                    { 12, "FIFA 22: Career Mode Expansion DLC Image", 12, null, "https://example.com/dlc_image_12.jpg" },
                    { 13, "The Sims 4: Seasons DLC Image", 13, null, "https://example.com/dlc_image_13.jpg" },
                    { 14, "The Sims 4: Get Together DLC Image", 14, null, "https://example.com/dlc_image_14.jpg" },
                    { 15, "Resident Evil Village: The Mercenaries DLC Image", 15, null, "https://example.com/dlc_image_15.jpg" },
                    { 16, "Resident Evil Village: The Tragedy of Ethan Winters DLC Image", 16, null, "https://example.com/dlc_image_16.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameImageId",
                table: "Games",
                column: "GameImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameImages_GameImageId",
                table: "Games",
                column: "GameImageId",
                principalTable: "GameImages",
                principalColumn: "Id");
        }
    }
}
