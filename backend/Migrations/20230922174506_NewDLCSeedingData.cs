using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewDLCSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DLCImages_DLCs_DLCId1",
                table: "DLCImages");

            migrationBuilder.DropIndex(
                name: "IX_DLCImages_DLCId",
                table: "DLCImages");

            migrationBuilder.DropIndex(
                name: "IX_DLCImages_DLCId1",
                table: "DLCImages");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "edb21f44-f27d-4b59-8e0e-a5c01f7db2ba", "1e2386a0-9788-4209-bfbe-a0ffe81a7d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4752316-5937-4d92-a539-cb1d5db9e723");

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
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edb21f44-f27d-4b59-8e0e-a5c01f7db2ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e2386a0-9788-4209-bfbe-a0ffe81a7d1d");

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "DLCId1",
                table: "DLCImages");

            migrationBuilder.RenameColumn(
                name: "DLCImageId",
                table: "DLCs",
                newName: "MainDLCImageId");

            migrationBuilder.AlterColumn<string>(
                name: "TrailerUrl",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RecommendedSystemRequirements",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MinimumSystemRequirements",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Developer",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DLCs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "DLCImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eecb3f97-e33d-46d2-a495-eb2d9443caca", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3054e0e2-31a7-4e00-8fb8-2f5a8a7798b3", 0, "", "", null, null, "fd6a8bb8-c18e-4dec-aba3-3ef53993eddd", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEFvRaZNYHq/BuQ81ZWWjaV3zg7JEIKyYVDx0CZibeZeTLB1j89ZQleMRFN/a4D+nSQ==", null, false, null, "b68a3272-b63d-4e1e-8d02-22e1633c0c29", null, 0, false, "user" },
                    { "b7f5d93a-680c-44dc-b717-beabb49f8052", 0, "", "", null, null, "acea6ccf-bf88-4bb9-bf01-c0f7fa78245e", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEDRvF1xxkfObHYgYWQzZOlYO6l7+BwEZHdSjeMNhOOFSf/WRqIeSV0qBfkyMdnZZ0A==", null, false, null, "f76ab8c3-0f6e-4af0-8a63-4069e0249963", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Caption",
                value: "The Witcher 3: Hearts of Stone DLC Image 1");

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Caption", "DLCId", "ImageUrl" },
                values: new object[] { "The Witcher 3: Hearts of Stone DLC Image 2", 1, "https://example.com/path_to_second_image.jpg" });

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Caption", "DLCId", "ImageUrl" },
                values: new object[] { "The Witcher 3: Hearts of Stone DLC Image 3", 1, "https://example.com/path_to_third_image.jpg" });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "Developer", "MinimumSystemRequirements", "Publisher", "RecommendedSystemRequirements", "TrailerUrl" },
                values: new object[] { 4.7999999999999998, "CD Projekt", "OS: 64-bit Windows 7, CPU: Intel CPU Core i5-2500K 3.3GHz, RAM: 6GB, Graphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870", "CD Projekt", "OS: 64-bit Windows 7, CPU: Intel CPU Core i7 3770 3.4 GHz, RAM: 8GB, Graphics: Nvidia GPU GeForce GTX 770 / AMD GPU Radeon R9 290", "https://www.youtube.com/watch?v=ffdxS9R6NTE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7223), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7252), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7256), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7261), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7265), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7277), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7281), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7286), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7293), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7297), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7350), new DateTime(2023, 9, 22, 17, 45, 6, 244, DateTimeKind.Utc).AddTicks(7351) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eecb3f97-e33d-46d2-a495-eb2d9443caca", "b7f5d93a-680c-44dc-b717-beabb49f8052" });

            migrationBuilder.CreateIndex(
                name: "IX_DLCs_MainDLCImageId",
                table: "DLCs",
                column: "MainDLCImageId");

            migrationBuilder.CreateIndex(
                name: "IX_DLCImages_DLCId",
                table: "DLCImages",
                column: "DLCId");

            migrationBuilder.AddForeignKey(
                name: "FK_DLCs_DLCImages_MainDLCImageId",
                table: "DLCs",
                column: "MainDLCImageId",
                principalTable: "DLCImages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DLCs_DLCImages_MainDLCImageId",
                table: "DLCs");

            migrationBuilder.DropIndex(
                name: "IX_DLCs_MainDLCImageId",
                table: "DLCs");

            migrationBuilder.DropIndex(
                name: "IX_DLCImages_DLCId",
                table: "DLCImages");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eecb3f97-e33d-46d2-a495-eb2d9443caca", "b7f5d93a-680c-44dc-b717-beabb49f8052" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3054e0e2-31a7-4e00-8fb8-2f5a8a7798b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eecb3f97-e33d-46d2-a495-eb2d9443caca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7f5d93a-680c-44dc-b717-beabb49f8052");

            migrationBuilder.RenameColumn(
                name: "MainDLCImageId",
                table: "DLCs",
                newName: "DLCImageId");

            migrationBuilder.AlterColumn<string>(
                name: "TrailerUrl",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RecommendedSystemRequirements",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MinimumSystemRequirements",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Developer",
                table: "DLCs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DLCs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Caption",
                table: "DLCImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DLCId1",
                table: "DLCImages",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edb21f44-f27d-4b59-8e0e-a5c01f7db2ba", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e2386a0-9788-4209-bfbe-a0ffe81a7d1d", 0, "", "", null, null, "15b780d4-aed4-4822-b523-be5414549eb3", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEBAYtA61lRByTN1l6mcUmFZH1aEqZYqO6C2dIMLG9qPFJGdLDerD6QzRr0AEMeNTWQ==", null, false, null, "cd3336fa-57d3-4464-9a0b-6899ba8cacf0", null, 0, false, "admin" },
                    { "f4752316-5937-4d92-a539-cb1d5db9e723", 0, "", "", null, null, "10ac6bab-0137-47b0-b692-d58341313ecc", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEAFxjvm0VsFK2IJLwkH68yQGaeaciWZ+AzYvCj3lUvsRs0R/unR9QwABThj+tBjOQg==", null, false, null, "e8ed2f6e-9940-4973-a0d1-371f115f369a", null, 0, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Caption", "DLCId1" },
                values: new object[] { "The Witcher 3: Hearts of Stone DLC Image", null });

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[] { "The Witcher 3: Blood and Wine DLC Image", 2, null, "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032" });

            migrationBuilder.UpdateData(
                table: "DLCImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[] { "RDR2: Frontier Tales DLC Image", 3, null, "https://example.com/rdr2_frontier_tales_image.jpg" });

            migrationBuilder.UpdateData(
                table: "DLCs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "Developer", "MinimumSystemRequirements", "Publisher", "RecommendedSystemRequirements", "TrailerUrl" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCImageId", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 2, null, null, "The Witcher 3: Blood and Wine", "Visit the picturesque land of Toussaint in the Blood and Wine expansion.", null, null, 1, null, 19.99m, null, null, new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, null, "RDR2: Frontier Tales", "Experience new stories from the Wild West in the Frontier Tales expansion.", null, null, 2, null, 14.99m, null, null, new DateTime(2019, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, null, "RDR2: Legend of the East", "Unlock the mysteries of the East in this exciting new DLC.", null, null, 2, null, 19.99m, null, null, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, null, "Cyberpunk: Night City Stories", "Dive deeper into Night City with additional quests and characters.", null, null, 3, null, 12.99m, null, null, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, null, "Cyberpunk: Beyond the Wall", "Venture beyond the city limits and explore the wastelands.", null, null, 3, null, 24.99m, null, null, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, null, "Doom Eternal: Hell's Ascent", "Climb through the new challenges and face tougher demons.", null, null, 4, null, 19.99m, null, null, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, null, "Doom Eternal: The Slayer's Return", "Return to the origin of the Slayer and discover his roots.", null, null, 4, null, 19.99m, null, null, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, null, "AC Valhalla: Rise of the Druids", "Travel to Ireland and confront the Druid cult.", null, null, 5, null, 24.99m, null, null, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, null, "AC Valhalla: The Siege of Paris", "Invade the fortified city of Paris and shape its future.", null, null, 5, null, 24.99m, null, null, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, null, null, "GTA V: The Diamond Casino Heist", "Plan and execute the ultimate heist at the Diamond Casino in Los Santos.", null, null, 7, null, 19.99m, null, null, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, null, null, "GTA V: The Cayo Perico Heist", "Embark on a remote island heist adventure in Cayo Perico.", null, null, 7, null, 24.99m, null, null, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1276), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1286), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1294), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1303), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1392), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1397), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1402), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1406), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1410), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1414), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1417), new DateTime(2023, 9, 22, 16, 50, 9, 417, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "edb21f44-f27d-4b59-8e0e-a5c01f7db2ba", "1e2386a0-9788-4209-bfbe-a0ffe81a7d1d" });

            migrationBuilder.InsertData(
                table: "DLCImages",
                columns: new[] { "Id", "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[,]
                {
                    { 4, "RDR2: Legend of the East DLC Image", 4, null, "https://example.com/rdr2_legend_of_the_east_image.jpg" },
                    { 5, "Cyberpunk: Night City Stories DLC Image", 5, null, "https://example.com/cyberpunk_night_city_stories_image.jpg" },
                    { 6, "Cyberpunk: Beyond the Wall DLC Image", 6, null, "https://example.com/cyberpunk_beyond_the_wall_image.jpg" },
                    { 7, "Doom Eternal: Hell's Ascent DLC Image", 7, null, "https://example.com/doom_eternal_hells_ascent_image.jpg" },
                    { 8, "Doom Eternal: The Slayer's Return DLC Image", 8, null, "https://example.com/doom_eternal_slayers_return_image.jpg" },
                    { 9, "AC Valhalla: Rise of the Druids DLC Image", 9, null, "https://example.com/ac_valhalla_rise_of_the_druids_image.jpg" },
                    { 10, "AC Valhalla: The Siege of Paris DLC Image", 10, null, "https://example.com/ac_valhalla_siege_of_paris_image.jpg" },
                    { 11, "GTA V: The Diamond Casino Heist DLC Image", 13, null, "https://example.com/gta_diamond_casino_heist_image.jpg" },
                    { 12, "GTA V: The Cayo Perico Heist DLC Image", 14, null, "https://example.com/gta_cayo_perico_heist_image.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DLCImages_DLCId",
                table: "DLCImages",
                column: "DLCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DLCImages_DLCId1",
                table: "DLCImages",
                column: "DLCId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DLCImages_DLCs_DLCId1",
                table: "DLCImages",
                column: "DLCId1",
                principalTable: "DLCs",
                principalColumn: "Id");
        }
    }
}
