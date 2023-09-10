using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewsToGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1317016f-f3a4-4c23-8904-404e7d9ce446", "d0b4c27f-ec89-40be-acda-588d50882174" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbaf9293-aad8-4a14-b2a6-625f789fdbc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1317016f-f3a4-4c23-8904-404e7d9ce446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b4c27f-ec89-40be-acda-588d50882174");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 37, 50, 753, DateTimeKind.Utc).AddTicks(9634), new DateTime(2023, 9, 8, 12, 37, 50, 753, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(921), new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(931), new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(935), new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(938), new DateTime(2023, 9, 8, 12, 37, 50, 754, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1317016f-f3a4-4c23-8904-404e7d9ce446", "d0b4c27f-ec89-40be-acda-588d50882174" });
        }
    }
}
