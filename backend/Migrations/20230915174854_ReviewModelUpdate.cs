using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class ReviewModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4d7872e-a012-402f-8b8c-37fbf7d97949", "7a6b9ab4-ce38-45fd-b97d-b8b9102e69e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ebf946d-97bb-4d32-af61-9d1c414ccfd7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4d7872e-a012-402f-8b8c-37fbf7d97949");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a6b9ab4-ce38-45fd-b97d-b8b9102e69e3");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e67555a5-161e-47ed-b855-e0d15f93d1ac", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9afee069-ac66-44d1-b6c1-2ebe64e459a1", 0, "", "", null, null, "8e176446-c178-4375-8b8b-5b300cda618b", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEADT4LHPAIZWZJqMT26l2/d5jKki4Lf6RNlOGfglF2agypiU1HAj88Rnn3yYG1jSWg==", null, false, null, "b19a9c55-e1df-4f35-8f96-5b7bf9ee14d3", null, 0, false, "admin" },
                    { "c102557b-3257-4232-9dd3-0e446cd4e68e", 0, "", "", null, null, "f746a6e7-7503-44f5-ba20-61fe5de2016a", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEGzxi2lr8pu2VCdXzAIo/0sV37Rm/UMak8DoJCgZx9ljLDbWAPBvzLiezAM0jefhbw==", null, false, null, "7b675f86-3d1b-42ac-bcc7-0a75fcfcfa3c", null, 0, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5546), new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5568), new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5572), new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5575), new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5579), new DateTime(2023, 9, 15, 17, 48, 53, 824, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e67555a5-161e-47ed-b855-e0d15f93d1ac", "9afee069-ac66-44d1-b6c1-2ebe64e459a1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e67555a5-161e-47ed-b855-e0d15f93d1ac", "9afee069-ac66-44d1-b6c1-2ebe64e459a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c102557b-3257-4232-9dd3-0e446cd4e68e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67555a5-161e-47ed-b855-e0d15f93d1ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9afee069-ac66-44d1-b6c1-2ebe64e459a1");

            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4d7872e-a012-402f-8b8c-37fbf7d97949", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ebf946d-97bb-4d32-af61-9d1c414ccfd7", 0, "", "", null, null, "a766e52e-215f-4434-b266-2759a3c323da", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEOKTJDiorLzqXP2oompKV1ikWqXqfAZ6fknEvsJwsC0BfEkd76nVuE8Wosr2OuMgOA==", null, false, null, "3d83ca68-a8c5-435c-8884-0323309083f3", null, 0, false, "user" },
                    { "7a6b9ab4-ce38-45fd-b97d-b8b9102e69e3", 0, "", "", null, null, "28ac9aa7-5595-44f1-aad4-c3e56d6deca4", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEFkOFSDlu/gUvC+ERQHdU/1C0w7CLLSX0ciqGwVJsQ8C10Z/4FAdlNO/LFYxbVPISA==", null, false, null, "36fbcd33-40c7-4821-af95-5bd6ba592599", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2621), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2627), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2631), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2637), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4d7872e-a012-402f-8b8c-37fbf7d97949", "7a6b9ab4-ce38-45fd-b97d-b8b9102e69e3" });
        }
    }
}
