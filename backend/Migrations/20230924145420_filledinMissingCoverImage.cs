using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class filledinMissingCoverImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e90aff9-c136-4230-b972-647fe23c8848");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6a354a0-387e-4709-9389-9e62f70e3dcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68aec487-8485-463b-9d90-2e1906860a54", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31db17e7-9331-41a2-9335-09cf1f095e42", 0, "", "", null, null, "1313772d-25d8-4e63-9e59-95ec03b407a2", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEFwUqWoxGtKIeJmxdqNFxdJHV+MkydBU62Jmj1G3ys+ysGeDuoWypkT1j9YA0FrIjQ==", null, false, null, "d03ec611-8958-4603-881a-8057f0847a21", null, 0, false, "user" },
                    { "a493a37a-c3a2-4ce7-aa82-faa5494d9e5c", 0, "", "", null, null, "b12cd279-d541-4432-90c0-f1f4fbd7f778", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEOmS6M+g7mXbrnGUhE+jreCcb7eP+815dLQ6qlbAbv8sd9HoPp415p8uAQghzhns3A==", null, false, null, "555d3811-09f4-4da9-b7c6-0303132315cd", null, 0, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3729), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3756), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3760), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566287/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w_rqc7us.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3764), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566343/minecraft-hero-banner-desktop-01-ps4-en-07jul21_j0ssuf.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3768), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566384/91lmTAVXgHL._SL1500__wayp4d.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3772), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/an-image-of-link-in-the-new-zelda-breath-of-the-wild-video-game_r3d9ub.avif", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3827), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566452/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg_xkadqv.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3831), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566527/iPKatp6VvEFwBwMeYXSwhR-1024-80.jpg_kctslj.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566572/img08_2x-570x155_mrypo0.png", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3846), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566642/0000000899.600x338_dk8xkx.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3849), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566675/H2x1_NSwitch_BioshockInfiniteTheCompleteEdition_image1600w_ozd1tp.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3856), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566287/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w_rqc7us.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3871), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566810/resident-evil-village-ps5-screenshot-05-24jul20_dfa6li.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3876), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3879), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/194522_1357656.bmp.1500x843_q95_crop-smart_upscale_yqaufa.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547913/VideoGameShop/Animal%20Crossing-%20New%20Horizons/uQgKvtbaN94TWQyn9HyHv_rw3wmx.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3886), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/Halo%20Infinite/halo_infinite_hope_nogun_keyart_horiz_1120-d408b3ea15194141bf68183246babe2e_x5vjdo.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566452/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg_xkadqv.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/HO8vkO9pfXhwbHi5WHECQJdN_orvh7x.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3935), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/an-image-of-link-in-the-new-zelda-breath-of-the-wild-video-game_r3d9ub.avif", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3939), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3943), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1695566343/minecraft-hero-banner-desktop-01-ps4-en-07jul21_j0ssuf.webp", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3947), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547913/VideoGameShop/Animal%20Crossing-%20New%20Horizons/uQgKvtbaN94TWQyn9HyHv_rw3wmx.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3950), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg", new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3953), new DateTime(2023, 9, 24, 14, 54, 19, 424, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "68aec487-8485-463b-9d90-2e1906860a54", "a493a37a-c3a2-4ce7-aa82-faa5494d9e5c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68aec487-8485-463b-9d90-2e1906860a54", "a493a37a-c3a2-4ce7-aa82-faa5494d9e5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31db17e7-9331-41a2-9335-09cf1f095e42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68aec487-8485-463b-9d90-2e1906860a54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a493a37a-c3a2-4ce7-aa82-faa5494d9e5c");

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

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/cyberpunk2077coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6588), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/skyrimcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6592), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/minecraftcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6595), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/assassinscreedvalhallacoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/zeldabreathofthewildcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6604), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/fifa22coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/horizonzerodawncoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6612), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/doometernalcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/amonguscoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/cyberpunk2078coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/megaracingchampionshipcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/bioshockinfinitecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/stardewvalleycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/elderscrollsvicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7860), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/minecraftcoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7864), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/residentevilvillagecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7879), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/assassinscreedodysseycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7882), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/thelastofuspartiicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/civilizationvicoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/haloinfinitecoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7894), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/fifa24coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7897), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/horizonzerodawncoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7901), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/cyberpunk2078coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7905), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/zeldabreathofthewild2coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7909), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/stardewvalleycoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7912), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/minecraftdungeonscoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7916), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/overwatch2coverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7919), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CoverImage", "CreatedAt", "UpdatedAt" },
                values: new object[] { "https://example.com/subnauticacoverimage.jpg", new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7923), new DateTime(2023, 9, 24, 13, 32, 0, 530, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0e90aff9-c136-4230-b972-647fe23c8848", "f6a354a0-387e-4709-9389-9e62f70e3dcf" });
        }
    }
}
