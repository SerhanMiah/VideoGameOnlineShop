using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class addedSecretsforpostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc5e02d0-2dbf-4315-a8bc-b1c245b72bf7", "b5382978-5731-41d2-aceb-069d674323f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbfe4045-e0db-4749-a914-7b683375fd79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc5e02d0-2dbf-4315-a8bc-b1c245b72bf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5382978-5731-41d2-aceb-069d674323f1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Payments",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CardExpirationDate",
                table: "PaymentMethods",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "DLCs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "725d37ea-bb97-4837-b56a-28673ae87275", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6b9cb3c2-8785-4d24-b298-2fa799ed4fee", 0, "", "", null, null, "32ba1a33-1d37-44bc-a3c3-4bc39b8312ca", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEH77krfWs4VhKdZxPOkUKUP6C2W6R6MZ8C2JaH7D2kJyNCAiedJj1hCs4vmSbCOjCw==", null, false, null, "57370690-196d-4c7b-a435-d560df05859f", null, 0, false, "admin" },
                    { "d8e7e1ff-ce1e-4c5f-8f37-e06f90bedb9c", 0, "", "", null, null, "134f9053-af5a-4fe7-bb8c-e682c7008e04", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEOEZBUA10cuxMxMDJ0qA4FI4vr0skhG9pVarcRfQnSZ0ZmfX8TVqRkiQtDOljNylJQ==", null, false, null, "8eecfb89-eae5-44ed-9398-598cf4dced27", null, 0, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6832), new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6851), new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6859), new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 9, 17, 21, 39, 7, 125, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "725d37ea-bb97-4837-b56a-28673ae87275", "6b9cb3c2-8785-4d24-b298-2fa799ed4fee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "725d37ea-bb97-4837-b56a-28673ae87275", "6b9cb3c2-8785-4d24-b298-2fa799ed4fee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8e7e1ff-ce1e-4c5f-8f37-e06f90bedb9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "725d37ea-bb97-4837-b56a-28673ae87275");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b9cb3c2-8785-4d24-b298-2fa799ed4fee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "Payments",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CardExpirationDate",
                table: "PaymentMethods",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "DLCs",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc5e02d0-2dbf-4315-a8bc-b1c245b72bf7", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b5382978-5731-41d2-aceb-069d674323f1", 0, "", "", null, null, "4d1e35d8-e137-4d52-bda6-ce7971ac3c5a", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEJjdq1rZM9sphAJm08s4nTPrTL16s+xMKHDwYovPrWICfwhm6QMSKsmucO0GfmBXag==", null, false, null, "94137d90-7d26-4157-80d6-d83c7b2cf2d3", null, 0, false, "admin" },
                    { "cbfe4045-e0db-4749-a914-7b683375fd79", 0, "", "", null, null, "e8c549ad-d301-4a34-9e65-e3bcb6f49af6", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEL2WduZxjp6zFHD94BGeufZapXaP2T3zG+tcMG/94JnpOCGmhcz9pJ96pBeK1rS7EA==", null, false, null, "347dd64e-a3e0-4a1e-a26a-cde33d5b8071", null, 0, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(953), new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(1072), new DateTime(2023, 9, 17, 21, 27, 41, 661, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc5e02d0-2dbf-4315-a8bc-b1c245b72bf7", "b5382978-5731-41d2-aceb-069d674323f1" });
        }
    }
}
