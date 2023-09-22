using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationWithSeedWithLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "701b28f5-2d69-4a74-ad17-1657616608a8", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7da49153-1fc9-4455-a9cf-5719e2137d17", 0, "", "", null, null, "75d29a61-c89f-4e3a-a9f8-b923ad5f8716", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEIj6Ggr/X0LEWm1TcqcuggC9AfDIAW9uvM1SPCFEDtIniYt/b3VwHgk/NRJeDXWc1A==", null, false, null, "09199ad7-9392-44bc-a1b6-cd293dd602da", null, 0, false, "user" },
                    { "a90e14f1-8a7a-42da-9b79-87565f04c1fa", 0, "", "", null, null, "7187891a-cc3a-4583-8753-47b4ba1ec610", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEN/f0H99XQ5VG2QswGdFJwTHtuwB+o0cvpeGnrliHNFJUb6oW1lu/DUKSQypzRYwPQ==", null, false, null, "cacadab7-412b-4b8e-8de7-2947b307e616", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9436), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9541), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9546), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9553), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 9, 22, 18, 9, 13, 739, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "701b28f5-2d69-4a74-ad17-1657616608a8", "a90e14f1-8a7a-42da-9b79-87565f04c1fa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "701b28f5-2d69-4a74-ad17-1657616608a8", "a90e14f1-8a7a-42da-9b79-87565f04c1fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7da49153-1fc9-4455-a9cf-5719e2137d17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "701b28f5-2d69-4a74-ad17-1657616608a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90e14f1-8a7a-42da-9b79-87565f04c1fa");

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
        }
    }
}
