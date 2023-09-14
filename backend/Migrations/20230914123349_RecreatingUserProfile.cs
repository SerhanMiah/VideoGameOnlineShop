using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class RecreatingUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0542e93b-e314-4043-bce1-bd78280b27fb", "40ad68ef-de22-4e6c-8fef-d17a94e731f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c5cda2b-e241-42ba-904a-bdb5c09ade9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0542e93b-e314-4043-bce1-bd78280b27fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40ad68ef-de22-4e6c-8fef-d17a94e731f9");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Games",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AchievementsDb",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteGame",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalGamesPlayed",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserFriends",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FriendId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriends", x => new { x.UserId, x.FriendId });
                    table.ForeignKey(
                        name: "FK_UserFriends_AspNetUsers_FriendId",
                        column: x => x.FriendId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFriends_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ApplicationUserId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2621), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2627), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicationUserId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2631), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CreatedAt", "UpdatedAt" },
                values: new object[] { null, new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2637), new DateTime(2023, 9, 14, 12, 33, 49, 310, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4d7872e-a012-402f-8b8c-37fbf7d97949", "7a6b9ab4-ce38-45fd-b97d-b8b9102e69e3" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_ApplicationUserId",
                table: "Games",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFriends_FriendId",
                table: "UserFriends",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_ApplicationUserId",
                table: "Games",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_ApplicationUserId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DropIndex(
                name: "IX_Games_ApplicationUserId",
                table: "Games");

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

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "AchievementsDb",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteGame",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalGamesPlayed",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0542e93b-e314-4043-bce1-bd78280b27fb", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c5cda2b-e241-42ba-904a-bdb5c09ade9a", 0, "", null, "54ea82f6-db00-471a-9c5b-bb54831344a5", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEMSezYAKr86LUBjjtABw51uc4W7i8OJvzo80yRVMxdINrwuCJ3NFiHDbeGsUqLBT/w==", null, false, null, "4426f9a8-702e-456c-8273-515524b0f213", null, false, "user" },
                    { "40ad68ef-de22-4e6c-8fef-d17a94e731f9", 0, "", null, "a8bfa8e3-3ff2-4811-8f98-9b83950d1550", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEPkBltatrSuJ7IGW9brgTSKt1/i+3NzkFVx4M4FK1vsjet+Lut28Oz0WrfOSmOQt3w==", null, false, null, "1fb686b2-9974-43be-9ed0-fad629915588", null, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7360), new DateTime(2023, 9, 10, 16, 31, 32, 5, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0542e93b-e314-4043-bce1-bd78280b27fb", "40ad68ef-de22-4e6c-8fef-d17a94e731f9" });
        }
    }
}
