using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: true),
                    CardLastFourDigits = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CardExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DLCImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DLCId = table.Column<int>(type: "int", nullable: false),
                    DLCId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLCImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DLCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DLCName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    MinimumSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: true),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DLCImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameGenres",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenres", x => new { x.GameId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GameGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameImageId = table.Column<int>(type: "int", nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: true),
                    MinimumSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasMultiplayerSupport = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfLocalPlayers = table.Column<int>(type: "int", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AgeRatingId = table.Column<int>(type: "int", nullable: false),
                    ESRBContentDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_AgeRatings_AgeRatingId",
                        column: x => x.AgeRatingId,
                        principalTable: "AgeRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_GameImages_GameImageId",
                        column: x => x.GameImageId,
                        principalTable: "GameImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GamePlatforms",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatforms", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GamePlatforms_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DLCId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_DLCs_DLCId",
                        column: x => x.DLCId,
                        principalTable: "DLCs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Languages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WishlistId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_WishLists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "WishLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Rating" },
                values: new object[,]
                {
                    { 1, "Everyone" },
                    { 2, "Mature" },
                    { 3, "Teen" },
                    { 4, "Adults Only" },
                    { 5, "Everyone 10+" },
                    { 6, "Adults Only 18+" },
                    { 7, "Everyone 10+ with Cartoon Violence" },
                    { 8, "Mature 17+ with Blood and Gore, Intense Violence" },
                    { 9, "Teen 13+ with Mild Language, Violence" }
                });

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
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open World" },
                    { 2, "Role Playing" },
                    { 3, "Action" },
                    { 4, "Adventure" },
                    { 5, "Strategy" },
                    { 6, "Sports" },
                    { 7, "Simulation" },
                    { 8, "Fighting" },
                    { 9, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "PlayStation 5" },
                    { 3, "Xbox Series X" },
                    { 4, "Nintendo Switch" },
                    { 5, "Mobile" },
                    { 6, "PlayStation 4" },
                    { 7, "Xbox One" },
                    { 8, "Nintendo Switch Lite" },
                    { 9, "Google Stadia" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76a3abba-ecce-48b9-94b2-2bf4051cde83", "fe682112-d074-4768-ad25-5865af0ec009" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRatingId", "AverageRating", "Description", "Developer", "DiscountedPrice", "ESRBContentDescriptions", "GameImageId", "HasMultiplayerSupport", "MinimumSystemRequirements", "NumberOfLocalPlayers", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, 2, 4.2000000000000002, "Cyberpunk 2077 is an open-world, action-adventure story set in Night City.", "CD Projekt Red", null, null, null, false, "OS: Windows 10 (64-bit), Processor: Intel Core i5-3570K or AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 3GB or AMD Radeon RX 470, Storage: 70 GB available space", 1, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790 or AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon R9 Fury, Storage: SSD + 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=ixl31324UxE" },
                    { 2, 2, 4.7999999999999998, "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.", "CD Projekt Red", null, null, null, false, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space", 1, 29.99m, null, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=c0i88t0Kacs" },
                    { 3, 2, 4.9000000000000004, "Red Dead Redemption 2 is an epic tale of life in America's unforgiving heartland.", "Rockstar Games", null, null, null, true, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 280, Storage: 150 GB available space", 1, 49.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K 3.5 GHz or AMD Ryzen 5 1500X 3.5 GHz, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon RX 480 4GB, Storage: 150 GB available space", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://www.youtube.com/watch?v=Dw_oH5oiUSE" },
                    { 4, 1, 4.7000000000000002, "The Legend of Zelda: Breath of the Wild is an action-adventure game set in an open world.", "Nintendo", null, null, null, false, "N/A", 1, 59.99m, null, "N/A", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", "https://www.youtube.com/watch?v=zw47_q9wbBE" },
                    { 5, 4, 4.7000000000000002, "Grand Theft Auto V is an action-adventure game set in an open world.", "Rockstar North", null, null, null, true, "OS: Windows 7 (64-bit), Processor: Intel Core 2 Quad CPU Q6600 2.4 GHz or AMD Phenom 9850 Quad-Core Processor 2.5 GHz, Memory: 4 GB RAM, Graphics: NVIDIA 9800 GT 1GB or AMD HD 4870 1GB, Storage: 72 GB available space", 1, 29.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i5 3470 3.2 GHz or AMD X8 FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 2GB or AMD HD7870 2GB, Storage: 72 GB available space", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V", "https://www.youtube.com/watch?v=3DBrG2YjqQA" },
                    { 6, 1, 4.5, "Minecraft is a sandbox game that allows players to build and explore virtual worlds.", "Mojang Studios", null, null, null, true, "OS: Windows 10 (64-bit), Processor: Intel Core i5-4690 or AMD A10-7800 or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series or AMD Radeon Rx 200 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space", 4, 26.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6500U or AMD A8-6600K or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 900 Series or AMD Radeon Rx 300 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=92AoX5OyiU4" },
                    { 7, 7, 4.5, "Experience the next installment of the popular FIFA football simulation game.", "EA Sports", null, null, null, true, "N/A", 4, 59.99m, null, "N/A", new DateTime(2022, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 22", "https://www.youtube.com/watch?v=Apm59G6LgYo" },
                    { 8, 1, 4.5999999999999996, "Create unique Sims, build their perfect homes, and explore vibrant worlds in The Sims 4.", "Maxis", null, null, null, false, "OS: Windows XP (SP3), Processor: 1.8 GHz Intel Core 2 Duo, AMD Athlon 64 Dual-Core 4000+ or equivalent, Memory: 2 GB RAM, Graphics: NVIDIA GeForce 6600 or ATI Radeon X1300 or Intel GMA X4500, Storage: 10 GB available space", 1, 39.99m, null, "OS: Windows 7, 8, 8.1, 10 (64-bit), Processor: Intel Core i5 or faster, AMD Athlon X4, Memory: 4 GB RAM, Graphics: NVIDIA GTX 650 or better, AMD Radeon HD 7770 or better, Storage: 18 GB available space", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 4", "https://www.youtube.com/watch?v=mf19woWj1lQ" },
                    { 9, 8, 4.2999999999999998, "Join the legendary Street Fighter tournament and prove your skills in intense battles.", "Capcom", null, null, null, true, "OS: Windows 7 (64-bit), Processor: Intel Core i3-4160 @ 3.60GHz, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 480, GTX 570, GTX 670, or better, Storage: 60 GB available space", 2, 19.99m, null, "OS: Windows 7 (64-bit), Processor: Intel Core i5-4690K @3.50GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960, GTX 1060, or better, Storage: 60 GB available space", new DateTime(2016, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Street Fighter V", "https://www.youtube.com/watch?v=wYsujrF_Oj0" },
                    { 10, 9, 4.7999999999999998, "Enter a world of survival horror and face terrifying creatures in Resident Evil Village.", "Capcom", null, null, null, false, "OS: Windows 10 (64-bit), Processor: Intel Core i5-7500 or AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti with 4GB VRAM or AMD Radeon RX 560 with 4GB VRAM, DirectX: Version 12, Storage: 40 GB available space", 1, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-8700 or AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 or AMD Radeon RX 5700, DirectX: Version 12, Storage: 40 GB available space", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village", "https://www.youtube.com/watch?v=3S1QCcVee_Y" }
                });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCImageId", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, null, null, "The Witcher 3: Hearts of Stone", "Embark on a new adventure as Geralt of Rivia in the Hearts of Stone expansion.", null, null, 2, null, 9.99m, null, null, new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, null, "The Witcher 3: Blood and Wine", "Visit the picturesque land of Toussaint in the Blood and Wine expansion.", null, null, 2, null, 19.99m, null, null, new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, null, "Red Dead Redemption 2: Undead Nightmare", "Experience an undead nightmare in the world of Red Dead Redemption 2.", null, null, 3, null, 14.99m, null, null, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, null, "Red Dead Redemption 2: The Ballad of Gay Tony", "Join the high-stakes world of nightclub entertainment in The Ballad of Gay Tony DLC.", null, null, 3, null, 9.99m, null, null, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, null, "The Legend of Zelda: Breath of the Wild - Expansion Pass", "Expand your adventure with two DLC packs for The Legend of Zelda: Breath of the Wild.", null, null, 4, null, 19.99m, null, null, new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, null, "The Legend of Zelda: Breath of the Wild - The Champions' Ballad", "Embark on a new quest and discover the story of the champions in The Champions' Ballad DLC.", null, null, 4, null, 9.99m, null, null, new DateTime(2017, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, null, "Grand Theft Auto V: The Diamond Casino Heist", "Plan and execute the most daring heist in the history of Los Santos in The Diamond Casino Heist DLC.", null, null, 5, null, 9.99m, null, null, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, null, "Grand Theft Auto V: The Cayo Perico Heist", "Infiltrate the remote island of Cayo Perico and pull off a monumental heist in The Cayo Perico Heist DLC.", null, null, 5, null, 14.99m, null, null, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, null, "Minecraft: Nether Update", "Explore the dangerous Nether dimension with new mobs, biomes, and materials in the Nether Update DLC.", null, null, 6, null, 4.99m, null, null, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, null, "Minecraft: Caves & Cliffs Update", "Discover new cave systems, mountain biomes, and blocks in the Caves & Cliffs Update DLC.", null, null, 6, null, 9.99m, null, null, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
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
                    { 1, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Cyberpunk%202077/cyberpunk_2077_unreal_engine_5_wjauye.png" },
                    { 2, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-phantom-liberty_fuqyge.webp" },
                    { 3, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp" },
                    { 4, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    { 5, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp" },
                    { 6, 2, "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/5/13/1431520130189/8bfad8ae-5a24-4617-988e-ccafee83324f-1020x612.jpeg?width=700&quality=85&auto=format&fit=max&s=8a7d3e78ea1329d9442f2b175bc7eb14" },
                    { 7, 2, "https://s1.dmcdn.net/v/7dQua1X-34xfWvryS/x1080" },
                    { 8, 2, "https://venturebeat.com/wp-content/uploads/2022/12/witcher-5.jpg?w=791&resize=1200%2C910&strip=all" },
                    { 9, 2, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp" },
                    { 10, 2, "https://assetsio.reedpopcdn.com/Site_qTBBJD0.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 11, 3, "https://assetsio.reedpopcdn.com/red-dead-redemption-2-review-1540465569009.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp" },
                    { 12, 3, "https://gaming-cdn.com/images/products/5679/616x353/red-dead-redemption-2-pc-game-rockstar-cover.jpg?v=1647026658" },
                    { 13, 3, "https://assets1.ignimgs.com/thumbs/userUploaded/2018/10/25/rdr21280-1540446855527.jpg" },
                    { 14, 3, "https://images.pushsquare.com/5cd7243587ddd/red-dead-redemption-2-how-to-start-a-new-game-guide-1.large.jpg" },
                    { 15, 3, "https://i.ytimg.com/vi/HVRzx17WHVk/maxresdefault.jpg" },
                    { 21, 4, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/wiiu_14/SI_WiiU_TheLegendOfZeldaBreathOfTheWild_image1600w.jpg" },
                    { 22, 4, "https://www.gamespot.com/a/uploads/scale_medium/1197/11970954/3181241-ig-lozbreathofthewildrelease-20170112.jpg" },
                    { 23, 4, "https://i.guim.co.uk/img/media/22d6b308c89e62e229feb220208a639836e31fd9/60_0_1800_1080/master/1800.png?width=700&quality=85&auto=format&fit=max&s=25c588a5203feea6061c32112a66ebdc" },
                    { 24, 4, "https://i2-prod.mirror.co.uk/incoming/article8309144.ece/ALTERNATES/s1200b/zelda-main.jpg" },
                    { 25, 4, "https://i.ytimg.com/vi/1RVts63WgbE/maxresdefault.jpg" },
                    { 26, 5, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 27, 5, "https://assets.xboxservices.com/assets/0b/17/0b179504-412d-4af7-9e00-3e3d92633577.jpg?n=GTA-V_GLP-Page-Hero-1084_1920x1080.jpg" },
                    { 28, 5, "https://image.api.playstation.com/vulcan/ap/rnd/202101/2019/A7bNiu2YBVKYLeEviv8DpcVg.jpg" },
                    { 29, 5, "https://d1e00ek4ebabms.cloudfront.net/production/28993ca1-a36c-4382-a18e-4e9f8bcfa1bb.jpg" },
                    { 30, 5, "https://www.theedgesusu.co.uk/wp-content/uploads/2020/08/GTA_V_Artwork_Trunk-534-1600-1.jpg" },
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
                    { 1, "The Witcher 3: Hearts of Stone DLC Image", 1, null, "https://static.wikia.nocookie.net/witcher/images/0/09/Tw3_expansion_pack_hos.jpg/revision/latest?cb=20150908190146" },
                    { 2, "The Witcher 3: Blood and Wine DLC Image", 2, null, "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032" },
                    { 3, "Red Dead Redemption 2: Undead Nightmare DLC Image", 3, null, "https://example.com/dlc_image_3.jpg" },
                    { 4, "Red Dead Redemption 2: The Ballad of Gay Tony DLC Image", 4, null, "https://example.com/dlc_image_4.jpg" },
                    { 5, "The Legend of Zelda: Breath of the Wild - Expansion Pass DLC Image", 5, null, "https://example.com/dlc_image_5.jpg" },
                    { 6, "The Legend of Zelda: Breath of the Wild - The Champions' Ballad DLC Image", 6, null, "https://example.com/dlc_image_6.jpg" },
                    { 7, "Grand Theft Auto V: The Diamond Casino Heist DLC Image", 7, null, "https://example.com/dlc_image_7.jpg" },
                    { 8, "Grand Theft Auto V: The Cayo Perico Heist DLC Image", 8, null, "https://example.com/dlc_image_8.jpg" },
                    { 9, "Minecraft: Nether Update DLC Image", 9, null, "https://example.com/dlc_image_9.jpg" },
                    { 10, "Minecraft: Caves & Cliffs Update DLC Image", 10, null, "https://example.com/dlc_image_10.jpg" },
                    { 11, "FIFA 22: Ultimate Team Expansion DLC Image", 11, null, "https://example.com/dlc_image_11.jpg" },
                    { 12, "FIFA 22: Career Mode Expansion DLC Image", 12, null, "https://example.com/dlc_image_12.jpg" },
                    { 13, "The Sims 4: Seasons DLC Image", 13, null, "https://example.com/dlc_image_13.jpg" },
                    { 14, "The Sims 4: Get Together DLC Image", 14, null, "https://example.com/dlc_image_14.jpg" },
                    { 15, "Resident Evil Village: The Mercenaries DLC Image", 15, null, "https://example.com/dlc_image_15.jpg" },
                    { 16, "Resident Evil Village: The Tragedy of Ethan Winters DLC Image", 16, null, "https://example.com/dlc_image_16.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_GameId",
                table: "CartItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DLCImages_DLCId",
                table: "DLCImages",
                column: "DLCId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DLCImages_DLCId1",
                table: "DLCImages",
                column: "DLCId1");

            migrationBuilder.CreateIndex(
                name: "IX_DLCs_GameId",
                table: "DLCs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GenreId",
                table: "GameGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GameImages_GameId",
                table: "GameImages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AgeRatingId",
                table: "Games",
                column: "AgeRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameImageId",
                table: "Games",
                column: "GameImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_DLCId",
                table: "Languages",
                column: "DLCId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_GameId",
                table: "Languages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_GameId",
                table: "OrderItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_GameId",
                table: "WishlistItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WishlistId",
                table: "WishlistItems",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Games_GameId",
                table: "CartItems",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DLCImages_DLCs_DLCId",
                table: "DLCImages",
                column: "DLCId",
                principalTable: "DLCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DLCImages_DLCs_DLCId1",
                table: "DLCImages",
                column: "DLCId1",
                principalTable: "DLCs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DLCs_Games_GameId",
                table: "DLCs",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "DLCImages");

            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "DLCs");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "AgeRatings");

            migrationBuilder.DropTable(
                name: "GameImages");
        }
    }
}
