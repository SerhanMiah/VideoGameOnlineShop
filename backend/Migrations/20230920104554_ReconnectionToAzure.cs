using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class ReconnectionToAzure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8f48ed7-ded6-47c4-8134-93995d0f9000", "9bb55382-5a52-48b7-8a9a-26cbda043876" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a0f0592-2671-4cfb-bbbd-496001f118b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8f48ed7-ded6-47c4-8134-93995d0f9000");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb55382-5a52-48b7-8a9a-26cbda043876");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a04cce3-5bd9-48cd-86ad-6dc62350be0f", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "179ad9af-a862-47db-88fe-ac372ad11759", 0, "", "", null, null, "5d72c59e-72bb-45c8-8f59-da9b02088dcc", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAENUB0N4Bh3cRVuoT8VOMh9Q4pWCLwdpOv/UEvs+i0ECfXvT56v4n/LHn0sFs2SEcug==", null, false, null, "e52b3335-4fc0-421b-801b-aa5f3ab1f7e0", null, 0, false, "admin" },
                    { "715a0c0d-5b0c-493a-a8d0-ab8ff6c53494", 0, "", "", null, null, "1e7e8655-6782-457d-b940-f23e92281b39", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEPBA3zmpIjyOWDArer4LldXy6EWhwvT6/y2c2OI0hWREcai6mxSFWxrNspziexhAJg==", null, false, null, "b89dad2d-34aa-4378-b7d9-5bfc193c212a", null, 0, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9473), new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9503), new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9558), new DateTime(2023, 9, 20, 10, 45, 54, 330, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a04cce3-5bd9-48cd-86ad-6dc62350be0f", "179ad9af-a862-47db-88fe-ac372ad11759" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a04cce3-5bd9-48cd-86ad-6dc62350be0f", "179ad9af-a862-47db-88fe-ac372ad11759" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715a0c0d-5b0c-493a-a8d0-ab8ff6c53494");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a04cce3-5bd9-48cd-86ad-6dc62350be0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "179ad9af-a862-47db-88fe-ac372ad11759");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8f48ed7-ded6-47c4-8134-93995d0f9000", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7a0f0592-2671-4cfb-bbbd-496001f118b9", 0, "", "", null, null, "a17283bc-2f1b-4753-a575-7b3371236a6a", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEJxhE1QmdoC+SqLSJKXGCSD8M8NboPBRrk8MuXc5D388DsDlkezywImOSCm392aldQ==", null, false, null, "e46fe43b-68fd-4c00-91d7-43c2c92d9771", null, 0, false, "user" },
                    { "9bb55382-5a52-48b7-8a9a-26cbda043876", 0, "", "", null, null, "e521b526-d0ea-4895-a7d6-85f158b67a69", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAED/HoXsYbH8W1zz9MT8LzxbQWfO375ird2dt8SHm+RxSecu3+hapaHweMIBjME7lNw==", null, false, null, "f050224c-a964-4b8d-98f4-c3ee5cbe25af", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(47), new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(138), new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(144), new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(147), new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(151), new DateTime(2023, 9, 19, 14, 53, 32, 368, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8f48ed7-ded6-47c4-8134-93995d0f9000", "9bb55382-5a52-48b7-8a9a-26cbda043876" });
        }
    }
}
