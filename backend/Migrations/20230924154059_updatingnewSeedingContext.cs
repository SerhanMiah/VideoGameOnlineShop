using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class updatingnewSeedingContext : Migration
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
                    FavoriteGame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalGamesPlayed = table.Column<int>(type: "int", nullable: false),
                    AchievementsDb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultBillingId = table.Column<int>(type: "int", nullable: true),
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
                name: "Billings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Developer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HasMultiplayerSupport = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfLocalPlayers = table.Column<int>(type: "int", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: true),
                    ESRBContentDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AgeRatingId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_Games_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BillingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Billings_BillingId",
                        column: x => x.BillingId,
                        principalTable: "Billings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Billings_BillingId",
                        column: x => x.BillingId,
                        principalTable: "Billings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_CartItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_GameGenres_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_GameImages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "DLCImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DLCId = table.Column<int>(type: "int", nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    MinimumSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedSystemRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDLCImageId = table.Column<int>(type: "int", nullable: true),
                    AverageRating = table.Column<double>(type: "float", nullable: true),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DLCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DLCs_DLCImages_MainDLCImageId",
                        column: x => x.MainDLCImageId,
                        principalTable: "DLCImages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DLCs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "GameLanguages",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLanguages", x => new { x.GameId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_GameLanguages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeRatings",
                columns: new[] { "Id", "Rating" },
                values: new object[,]
                {
                    { 1, "E - Everyone" },
                    { 2, "E10+ - Everyone 10 and older" },
                    { 3, "T - Teen" },
                    { 4, "M - Mature" },
                    { 5, "AO - Adults Only" },
                    { 6, "RP - Rating Pending" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e254c7aa-b2d2-4be6-bfcd-3fa287cb17e7", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "DefaultBillingId", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0628b9bb-d205-4289-a722-1f6b4a020961", 0, "", "", null, null, "092d085e-88b8-4c3d-a088-bf64bb20e737", null, null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEH0g8G/z7Jp2eV9AX83xyr6W+BagKqWeCLcHefmkqYM3hS65Wq+qAAcr7lhOWkoE/g==", null, false, null, "3e5f1855-bbfa-4e3a-a1c3-a89117d367c9", null, 0, false, "user" },
                    { "f1c19d73-322e-4708-ab6b-477f71f4442f", 0, "", "", null, null, "989de1db-609b-4b05-80b8-fcc479f2587c", null, null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAENSWJlZcVyaM1hgKUcp0mj/Xt+d7yjfVZmZDjlN0PEQkoQPSgRuW+QV2oVGjbABClw==", null, false, null, "9390df54-9a47-4db3-8e6a-74289ed7f442", null, 0, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "RPG" },
                    { 4, "Simulation" },
                    { 5, "Strategy" },
                    { 6, "Sports" },
                    { 7, "Puzzle" },
                    { 8, "Horror" },
                    { 9, "Shooter" },
                    { 10, "Platformer" },
                    { 11, "Fighting" },
                    { 12, "Racing" },
                    { 13, "Music" },
                    { 14, "Educational" },
                    { 15, "Card & Board" },
                    { 16, "Survival" },
                    { 17, "Stealth" },
                    { 18, "MMORPG" },
                    { 19, "Battle Royale" },
                    { 20, "Sandbox" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "DLCId", "GameId", "LanguageName" },
                values: new object[,]
                {
                    { 1, null, null, "English" },
                    { 2, null, null, "Spanish" },
                    { 3, null, null, "French" },
                    { 4, null, null, "German" },
                    { 5, null, null, "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "Xbox One" },
                    { 3, "PS4" },
                    { 4, "Nintendo Switch" },
                    { 5, "PS5" },
                    { 6, "Xbox X" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Open World" },
                    { 2, "Multiplayer" },
                    { 3, "Single Player" },
                    { 4, "Fantasy" },
                    { 5, "Sci-Fi" },
                    { 6, "Horror" },
                    { 7, "Action-Adventure" },
                    { 8, "Racing" },
                    { 9, "Sports" },
                    { 10, "Simulation" },
                    { 11, "Strategy" },
                    { 12, "Role-Playing" },
                    { 13, "Puzzle" },
                    { 14, "Platformer" },
                    { 15, "Shooter" },
                    { 16, "Survival" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e254c7aa-b2d2-4be6-bfcd-3fa287cb17e7", "f1c19d73-322e-4708-ab6b-477f71f4442f" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRatingId", "ApplicationUserId", "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "DiscountedPrice", "ESRBContentDescriptions", "HasMultiplayerSupport", "MinimumSystemRequirements", "NumberOfLocalPlayers", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 4, null, 4.7999999999999998, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6338), "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.", "CD Projekt Red", null, null, false, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space", 1, 29.99m, null, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=c0i88t0Kacs", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6342) },
                    { 2, 3, null, 4.9000000000000004, "https://cdn.cloudflare.steamstatic.com/steam/apps/1174180/capsule_sm_120.jpg?t=1677747900", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6362), "Red Dead Redemption 2 is an epic tale of life in America's unforgiving heartland.", "Rockstar Games", null, null, true, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD FX-6300, Memory: 8 GB RAM, Graphics: Nvidia GTX 770 2GB / AMD Radeon R9 280 3GB, Storage: 150 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 12 GB RAM, Graphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB, Storage: 150 GB available space", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://www.youtube.com/watch?v=eaW0tYpxyp0", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6362) },
                    { 3, 4, null, 3.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6366), "Cyberpunk 2077 is an open-world action-adventure game set in a dystopian future.", "CD Projekt Red", null, null, false, "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=game3trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6367) },
                    { 4, 3, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566287/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w_rqc7us.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6370), "The Elder Scrolls V: Skyrim is an open-world RPG known for its vast fantasy world.", "Bethesda Game Studios", null, null, false, "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space", 1, 39.99m, null, "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", "https://www.youtube.com/watch?v=game4trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6371) },
                    { 5, 1, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1695566343/minecraft-hero-banner-desktop-01-ps4-en-07jul21_j0ssuf.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6374), "Minecraft is a sandbox game where players can build and explore blocky worlds.", "Mojang Studios", null, null, true, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space", 4, 29.99m, null, "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=game5trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6374) },
                    { 6, 4, null, 4.5999999999999996, "https://res.cloudinary.com/danedskby/image/upload/v1695566384/91lmTAVXgHL._SL1500__wayp4d.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6379), "Assassin's Creed Valhalla is an action RPG that lets you play as a Viking warrior in medieval England.", "Ubisoft Montreal", null, null, false, "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", "https://www.youtube.com/watch?v=game6trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6379) },
                    { 7, 2, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/an-image-of-link-in-the-new-zelda-breath-of-the-wild-video-game_r3d9ub.avif", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6423), "The Legend of Zelda: Breath of the Wild is an action-adventure game set in the expansive world of Hyrule.", "Nintendo", null, null, false, "OS: Nintendo Switch", 1, 49.99m, null, "OS: Nintendo Switch", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild", "https://www.youtube.com/watch?v=game7trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6424) },
                    { 8, 1, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1695566452/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg_xkadqv.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6429), "FIFA 22 is a sports simulation game that brings the excitement of football (soccer) to your gaming console.", "EA Vancouver", null, null, true, "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space", 4, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 22", "https://www.youtube.com/watch?v=game8trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6429) },
                    { 9, 3, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6432), "Horizon Zero Dawn is an action RPG set in a post-apocalyptic world overrun by robotic creatures.", "Guerrilla Games", null, null, false, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 1, 39.99m, null, "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Zero Dawn", "https://www.youtube.com/watch?v=game9trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6432) },
                    { 10, 4, null, 4.7999999999999998, "https://res.cloudinary.com/danedskby/image/upload/v1695566527/iPKatp6VvEFwBwMeYXSwhR-1024-80.jpg_kctslj.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6437), "DOOM Eternal is a fast-paced first-person shooter where you battle hordes of demons from Hell.", "id Software", null, null, true, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM Eternal", "https://www.youtube.com/watch?v=gFQpxbd9DBg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6438) },
                    { 11, 1, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566572/img08_2x-570x155_mrypo0.png", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6441), "Among Us is a multiplayer party game where players work together on a spaceship while trying to identify impostors.", "InnerSloth", null, null, true, "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", 4, 4.99m, null, "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Among Us", "https://www.youtube.com/watch?v=gFQpxbd9DBg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6441) },
                    { 12, 4, null, 4.5, "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6445), "Cyberpunk 2078 is a futuristic open-world RPG with advanced technology and immersive storytelling.", "FutureTech Games", null, null, true, "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", 1, 69.99m, null, "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space", new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2078", "https://www.youtube.com/watch?v=game12trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6445) },
                    { 13, 2, null, 4.7999999999999998, "https://res.cloudinary.com/danedskby/image/upload/v1695566642/0000000899.600x338_dk8xkx.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6448), "Mega Racing Championship is an adrenaline-pumping racing game with high-speed action and stunning graphics.", "Speedster Studios", null, null, true, "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space", 2, 29.99m, null, "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space", new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mega Racing Championship", "https://www.youtube.com/watch?v=game13trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6448) },
                    { 14, 3, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566675/H2x1_NSwitch_BioshockInfiniteTheCompleteEdition_image1600w_ozd1tp.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6453), "BioShock Infinite is a first-person shooter with a captivating narrative and breathtaking floating cityscapes.", "Irrational Games", null, null, false, "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space", 1, 39.99m, null, "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space", new DateTime(2013, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "BioShock Infinite", "https://www.youtube.com/watch?v=game14trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6453) },
                    { 15, 1, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(6456), "Stardew Valley is a charming farming simulation game where you can build the farm of your dreams.", "ConcernedApe", null, null, true, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", 4, 14.99m, null, "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stardew Valley", "https://www.youtube.com/watch?v=game15trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7414) },
                    { 16, 4, null, 0.0, "https://res.cloudinary.com/danedskby/image/upload/v1695566287/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w_rqc7us.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7433), "The Elder Scrolls VI is an upcoming open-world RPG that takes players to a fantasy realm filled with magic and adventure.", "Bethesda Game Studios", null, null, false, "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space", 1, 69.99m, null, "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls VI", "https://www.youtube.com/watch?v=game16trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7434) },
                    { 17, 1, null, 4.7999999999999998, "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7437), "Minecraft is a sandbox game that allows players to build and explore blocky worlds, limited only by their creativity.", "Mojang Studios", null, null, true, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*", 4, 26.99m, null, "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=game17trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7438) },
                    { 18, 3, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1695566810/resident-evil-village-ps5-screenshot-05-24jul20_dfa6li.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7451), "Resident Evil Village is a survival horror game that plunges players into a mysterious village filled with supernatural threats.", "Capcom", null, null, false, "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space", 1, 49.99m, null, "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village", "https://www.youtube.com/watch?v=game18trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7451) },
                    { 19, 3, null, 4.5999999999999996, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7455), "Assassin's Creed: Odyssey is an action RPG set in ancient Greece, where you embark on an epic journey as a mercenary.", "Ubisoft", null, null, false, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space", 1, 49.99m, null, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed: Odyssey", "https://www.youtube.com/watch?v=game19trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7455) },
                    { 20, 4, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/194522_1357656.bmp.1500x843_q95_crop-smart_upscale_yqaufa.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7458), "The Last of Us Part II is a gripping action-adventure game that continues the story of Ellie in a post-apocalyptic world.", "Naughty Dog", null, null, true, "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space", new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", "https://www.youtube.com/watch?v=game20trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7459) },
                    { 21, 2, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1687547913/VideoGameShop/Animal%20Crossing-%20New%20Horizons/uQgKvtbaN94TWQyn9HyHv_rw3wmx.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7462), "Civilization VI is a turn-based strategy game that allows you to build and lead your own civilization through the ages.", "Firaxis Games", null, null, true, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space", 4, 39.99m, null, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space", new DateTime(2016, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Civilization VI", "https://www.youtube.com/watch?v=game21trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7463) },
                    { 22, 4, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/Halo%20Infinite/halo_infinite_hope_nogun_keyart_horiz_1120-d408b3ea15194141bf68183246babe2e_x5vjdo.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7466), "Halo Infinite is a first-person shooter that continues the legendary Halo series with a new chapter in Master Chief's story.", "343 Industries", null, null, true, "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space", new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo Infinite", "https://www.youtube.com/watch?v=game22trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7466) },
                    { 23, 1, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566452/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg_xkadqv.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7469), "FIFA 24 is the latest installment of the popular soccer simulation game, featuring updated teams, stadiums, and gameplay.", "EA Sports", null, null, true, "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space", 4, 49.99m, null, "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 24", "https://www.youtube.com/watch?v=game23trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7470) },
                    { 24, 4, null, 4.7999999999999998, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/HO8vkO9pfXhwbHi5WHECQJdN_orvh7x.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7473), "Horizon: Zero Dawn is an action RPG set in a post-apocalyptic world inhabited by robotic creatures, offering an engaging storyline.", "Guerrilla Games", null, null, false, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 1, 39.99m, null, "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon: Zero Dawn", "https://www.youtube.com/watch?v=game24trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7473) },
                    { 25, 4, null, 4.5, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7541), "Cyberpunk 2078 is a futuristic open-world RPG set in a cyber-enhanced world where you play as a mercenary navigating the city of Night City.", "CD Projekt Red", null, null, true, "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space", 1, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2078", "https://www.youtube.com/watch?v=game25trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7541) },
                    { 26, 1, null, 0.0, "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/The%20Legend%20of%20Zelda-%20Breath%20of%20the%20Wild/an-image-of-link-in-the-new-zelda-breath-of-the-wild-video-game_r3d9ub.avif", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7546), "The Legend of Zelda: Breath of the Wild 2 is the highly anticipated sequel to the acclaimed action-adventure game, offering new adventures in the kingdom of Hyrule.", "Nintendo", null, null, false, "OS: Nintendo Switch", 1, 49.99m, null, "OS: Nintendo Switch", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Breath of the Wild 2", "https://www.youtube.com/watch?v=game26trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7546) },
                    { 27, 1, null, 4.9000000000000004, "https://res.cloudinary.com/danedskby/image/upload/v1695566716/-1630837682024_bopaae.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7549), "Stardew Valley is a farming simulation game that allows players to build and customize their own farm, interact with villagers, and enjoy rural life.", "ConcernedApe", null, null, true, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space", 4, 14.99m, null, "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space", new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stardew Valley", "https://www.youtube.com/watch?v=game27trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7549) },
                    { 28, 1, null, 4.7000000000000002, "https://res.cloudinary.com/danedskby/image/upload/v1695566343/minecraft-hero-banner-desktop-01-ps4-en-07jul21_j0ssuf.webp", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7553), "Minecraft: Dungeons is an action-adventure game set in the blocky world of Minecraft, featuring dungeon crawling and exploration.", "Mojang Studios", null, null, true, "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space", 4, 29.99m, null, "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space", new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft: Dungeons", "https://www.youtube.com/watch?v=game28trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7553) },
                    { 29, 3, null, 0.0, "https://res.cloudinary.com/danedskby/image/upload/v1687547913/VideoGameShop/Animal%20Crossing-%20New%20Horizons/uQgKvtbaN94TWQyn9HyHv_rw3wmx.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7557), "Overwatch 2 is a team-based first-person shooter with an engaging story, new heroes, and updated gameplay mechanics.", "Blizzard Entertainment", null, null, true, "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space", 6, 59.99m, null, "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch 2", "https://www.youtube.com/watch?v=game29trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7557) },
                    { 30, 2, null, 4.7999999999999998, "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7560), "Subnautica is an underwater adventure game where you explore an alien ocean, craft equipment, and survive in a hostile environment.", "Unknown Worlds Entertainment", null, null, false, "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space", 1, 24.99m, null, "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space", new DateTime(2018, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subnautica", "https://www.youtube.com/watch?v=game30trailerurl", new DateTime(2023, 9, 24, 15, 40, 58, 887, DateTimeKind.Utc).AddTicks(7560) }
                });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MainDLCImageId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, 4.7999999999999998, "The Witcher 3: Hearts of Stone", "Embark on a new adventure as Geralt of Rivia in the Hearts of Stone expansion.", "CD Projekt", null, 1, null, "OS: 64-bit Windows 7, CPU: Intel CPU Core i5-2500K 3.3GHz, RAM: 6GB, Graphics: Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870", 9.99m, "CD Projekt", "OS: 64-bit Windows 7, CPU: Intel CPU Core i7 3770 3.4 GHz, RAM: 8GB, Graphics: Nvidia GPU GeForce GTX 770 / AMD GPU Radeon R9 290", new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=ffdxS9R6NTE" },
                    { 2, 4.7000000000000002, "Red Dead Redemption 2: Outlaws to the End", "Join a gang of outlaws and experience new missions and adventures in the Outlaws to the End DLC.", "Rockstar Games", null, 2, null, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD FX-6300, Memory: 8 GB RAM, Graphics: Nvidia GTX 770 2GB / AMD Radeon R9 280 3GB, Storage: 150 GB available space", 19.99m, "Rockstar Games", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 12 GB RAM, Graphics: Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB, Storage: 150 GB available space", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 4, 0.0, "The Elder Scrolls V: Skyrim - Dawnguard", "Embark on a new questline with the Dawnguard DLC for The Elder Scrolls V: Skyrim, featuring vampires, vampire hunters, and powerful artifacts.", "Bethesda Game Studios", null, 4, null, "OS: Windows 7, Processor: Intel i5-750 / AMD Phenom II X4-945, Memory: 8 GB RAM, Graphics: NVIDIA GTX 470 / AMD HD 7870, Storage: 12 GB available space", 19.99m, "Bethesda Softworks", "OS: Windows 7 / 8.1 / 10, Processor: Intel i5-2400 / AMD FX-8320, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 12 GB available space", new DateTime(2012, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 5, 0.0, "Minecraft - Explorers Pack", "Expand your blocky adventures with the Explorers Pack DLC for Minecraft, including new biomes, creatures, and building materials.", "Mojang Studios", null, 5, null, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600, Memory: 4 GB RAM, Graphics: NVIDIA GeForce 400 Series / AMD Radeon HD 7000 series, Storage: 4 GB available space", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series / AMD Radeon Rx 200 Series, Storage: 4 GB available space", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 6, 0.0, "Assassin's Creed Valhalla - Wrath of the Norsemen", "Expand your Viking saga with the Wrath of the Norsemen DLC for Assassin's Creed Valhalla, featuring new quests, weapons, and armor.", "Ubisoft Montreal", null, 6, null, "OS: Windows 10, Processor: Intel Core i5-4460 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 380, Storage: 50 GB available space", 19.99m, "Ubisoft", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon RX 570, Storage: 50 GB available space", new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 7, 0.0, "The Legend of Zelda: Breath of the Wild - Master Trials", "Embark on the Master Trials in this DLC for The Legend of Zelda: Breath of the Wild, featuring new challenges, items, and a new Master Mode.", "Nintendo", null, 7, null, "OS: Nintendo Switch", 19.99m, "Nintendo", "OS: Nintendo Switch", new DateTime(2017, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 8, 0.0, "FIFA 22 - Ultimate Team Expansion", "Enhance your FIFA 22 experience with the Ultimate Team Expansion DLC, featuring new player cards, stadiums, and challenges.", "EA Vancouver", null, 8, null, "OS: Windows 7/10 (64-bit), Processor: Intel Core i3-6100 / AMD Athlon X4 880K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 / AMD Radeon HD 7850, Storage: 50 GB available space", 14.99m, "Electronic Arts", "OS: Windows 10 (64-bit), Processor: Intel i5-3550K / AMD FX 8150, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 9, 0.0, "Horizon Zero Dawn - Frozen Wilds Expansion", "Venture into the icy wilderness with the Frozen Wilds Expansion DLC for Horizon Zero Dawn, featuring new quests, creatures, and gear.", "Guerrilla Games", null, 9, null, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 14.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 10, 0.0, "DOOM Eternal - Inferno's Fury Expansion", "Unleash the fury of Hell with new weapons and challenges in the Inferno's Fury Expansion for DOOM Eternal.", "id Software", null, 10, null, "OS: Windows 7, Processor: Intel Core i5-2500K / AMD Ryzen 3 2200G, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon HD 7870, Storage: 50 GB available space", 19.99m, "Bethesda Softworks", "OS: Windows 10, Processor: Intel Core i7-6700K / AMD Ryzen 7 1800X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1080 / AMD Radeon RX 5700 XT, Storage: 50 GB available space", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 11, 0.0, "Among Us - Galactic Adventures Pack", "Embark on new adventures in space with the Galactic Adventures Pack for Among Us, featuring new maps and roles.", "InnerSloth", null, 11, null, "OS: Windows 7 SP1+ or macOS 10.13+, Processor: SSE2 instruction set support, Memory: 1 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", 9.99m, "InnerSloth", "OS: Windows 10, Processor: SSE2 instruction set support, Memory: 4 GB RAM, Graphics: DirectX 10 compatible, Storage: 250 MB available space", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 12, 0.0, "Cyberpunk 2078 - Night City Chronicles", "Dive deeper into the mysteries of Night City with new stories, characters, and cyber-enhancements in the Night City Chronicles DLC for Cyberpunk 2078.", "FutureTech Games", null, 12, null, "OS: Windows 10, Processor: Intel Core i7-8700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", 24.99m, "FutureTech Games", "OS: Windows 10, Processor: Intel Core i9-12900K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3090 / AMD Radeon RX 6900 XT, Storage: 100 GB available space", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 13, 0.0, "Mega Racing Championship - Turbo Boost Pack", "Rev up your engines with the Turbo Boost Pack for Mega Racing Championship, featuring new vehicles and high-speed tracks.", "Speedster Studios", null, 13, null, "OS: Windows 7, Processor: Intel Core i5-6600K / AMD Ryzen 5 2600X, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 50 GB available space", 9.99m, "Speedster Studios", "OS: Windows 10, Processor: Intel Core i7-9700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA RTX 3070 / AMD RX 6700 XT, Storage: 50 GB available space", new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 14, 0.0, "BioShock Infinite - Clash in the Clouds", "Take on challenging arena battles in the Clash in the Clouds DLC for BioShock Infinite, featuring new maps, enemies, and rewards.", "Irrational Games", null, 14, null, "OS: Windows Vista, Processor: Intel Core 2 DUO 2.4 GHz / AMD Athlon X2 2.7 GHz, Memory: 2 GB RAM, Graphics: DirectX10 Compatible ATI Radeon HD 3870 / NVIDIA 8800 GT / Intel HD 3000 Integrated Graphics, Storage: 20 GB available space", 9.99m, "2K Games", "OS: Windows 7, Processor: Quad-core processor, Memory: 4 GB RAM, Graphics: DirectX11 Compatible, Storage: 30 GB available space", new DateTime(2013, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 15, 0.0, "Stardew Valley - Greenhouse Expansion", "Expand your farming capabilities with the Greenhouse Expansion DLC for Stardew Valley, allowing year-round crop growth.", "ConcernedApe", null, 15, null, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", 4.99m, "ConcernedApe", "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10 compatible graphics card, Storage: 500 MB available space", new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 16, 0.0, "The Elder Scrolls VI - Knights of Tamriel Expansion", "Embark on a quest to join the legendary Knights of Tamriel in this expansion for The Elder Scrolls VI, introducing new lands, quests, and foes.", "Bethesda Game Studios", null, 16, null, "OS: Windows 10, Processor: Intel Core i5-9600K / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3060 / AMD Radeon RX 6600 XT, Storage: 100 GB available space", 29.99m, "Bethesda Softworks", "OS: Windows 10, Processor: Intel Core i7-12700K / AMD Ryzen 9 5900X, Memory: 32 GB RAM, Graphics: NVIDIA GeForce RTX 3080 / AMD Radeon RX 6800 XT, Storage: 100 GB available space", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 17, 0.0, "Minecraft - Nether Update", "Explore the treacherous Nether dimension with the Nether Update DLC for Minecraft, featuring new biomes, mobs, and resources.", "Mojang Studios", null, 17, null, "OS: Windows 7 or later, Processor: Intel Core i3-3210 / AMD A8-7600 APU, Memory: 4 GB RAM, Graphics: Integrated: Intel HD Graphics 4000 (Ivy Bridge) or AMD Radeon R5 series (Kaveri line) with OpenGL 4.4*", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: Intel Core i5-4690 / AMD A10-7800 APU, Memory: 8 GB RAM, Graphics: GeForce 700 Series or AMD Radeon Rx 200 Series (excluding integrated chipsets) with OpenGL 4.5", new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 18, 0.0, "Resident Evil Village - Nightmares Unleashed", "Survive new horrors in the Nightmares Unleashed DLC for Resident Evil Village, featuring additional story content, enemies, and challenges.", "Capcom", null, 18, null, "OS: Windows 10, Processor: Intel Core i5-7500 / AMD Ryzen 3 1200, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1050 Ti / AMD Radeon RX 560, Storage: 45 GB available space", 14.99m, "Capcom", "OS: Windows 10, Processor: Intel Core i7-8700 / AMD Ryzen 5 3600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1070 / AMD Radeon RX 5700, Storage: 45 GB available space", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 19, 0.0, "Assassin's Creed: Odyssey - Legacy of the First Blade", "Uncover the secrets of the first Assassins in the Legacy of the First Blade DLC for Assassin's Creed: Odyssey, featuring new storylines and abilities.", "Ubisoft", null, 19, null, "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD FX 6300 @ 3.8 GHz / Intel Core i5 2400 @ 3.1 GHz, Memory: 8 GB RAM, Graphics: AMD Radeon R9 285 / NVIDIA GeForce GTX 660, Storage: 46 GB available space", 19.99m, "Ubisoft", "OS: Windows 7 SP1 / 8.1 / 10, Processor: AMD Ryzen 1700X @ 3.8 GHz / Intel Core i7 7700 @ 4.2 GHz, Memory: 16 GB RAM, Graphics: AMD Vega 64 / NVIDIA GeForce GTX 970, Storage: 46 GB available space", new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 20, 0.0, "The Last of Us Part II - Left Behind Epilogue", "Explore the untold story of Ellie and Riley in the Left Behind Epilogue DLC for The Last of Us Part II, featuring new characters and challenges.", "Naughty Dog", null, 20, null, "OS: Windows 10, Processor: Intel Core i5-2300 / AMD FX-4320, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 760 / AMD Radeon HD 7870, Storage: 100 GB available space", 9.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 5 1600, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 580, Storage: 100 GB available space", new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 21, 0.0, "Civilization VI - Rise and Fall Expansion", "Expand your empire with the Rise and Fall expansion for Civilization VI, introducing new civilizations, leaders, and gameplay features.", "Firaxis Games", null, 21, null, "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Intel Core i3 2.5 Ghz or AMD Phenom II 2.6 Ghz or greater, Memory: 4 GB RAM, Graphics: 1 GB & AMD 5570 or nVidia 450, Storage: 12 GB available space", 29.99m, "2K Games", "OS: Windows 7 64bit / 8.1 64bit / 10 64bit, Processor: Fourth generation Intel Core i5 2.5 Ghz or AMD FX8350 4.0 Ghz or greater, Memory: 8 GB RAM, Graphics: 2GB & AMD 7970 or nVidia 770 or greater, Storage: 12 GB available space", new DateTime(2018, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 22, 0.0, "Halo Infinite - Spartan Ops Expansion", "Continue the adventure in the Halo universe with the Spartan Ops Expansion for Halo Infinite, featuring new missions, weapons, and multiplayer maps.", "343 Industries", null, 22, null, "OS: Windows 10, Processor: AMD Ryzen 5 2600X / Intel Core i5-3470, Memory: 8 GB RAM, Graphics: AMD Radeon RX 570 / NVIDIA GeForce GTX 770, Storage: 50 GB available space", 19.99m, "Xbox Game Studios", "OS: Windows 10, Processor: AMD Ryzen 7 3700X / Intel Core i7-8700, Memory: 16 GB RAM, Graphics: AMD Radeon RX 5700 XT / NVIDIA GeForce RTX 2070, Storage: 50 GB available space", new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 23, 0.0, "FIFA 24 - World Cup Expansion", "Experience the excitement of the World Cup with the World Cup Expansion for FIFA 24, featuring updated teams, stadiums, and tournament modes.", "EA Sports", null, 23, null, "OS: Windows 10, Processor: Intel Core i3-2100 / AMD Phenom II X4 965, Memory: 8 GB RAM, Graphics: NVIDIA GTX 460 / AMD Radeon R7 260, Storage: 50 GB available space", 14.99m, "Electronic Arts", "OS: Windows 10, Processor: Intel Core i5-3550 / AMD FX 8150, Memory: 16 GB RAM, Graphics: NVIDIA GTX 670 / AMD Radeon R9 270X, Storage: 50 GB available space", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 24, 0.0, "Horizon: Zero Dawn - Frozen Wilds Expansion", "Embark on a new journey in the Frozen Wilds Expansion for Horizon: Zero Dawn, featuring a new icy region, machines, and quests.", "Guerrilla Games", null, 24, null, "OS: Windows 10, Processor: Intel Core i5-2500K / AMD FX 6300, Memory: 8 GB RAM, Graphics: NVIDIA GTX 780 / AMD Radeon R9 290, Storage: 100 GB available space", 19.99m, "Sony Interactive Entertainment", "OS: Windows 10, Processor: Intel Core i7-4770K / AMD Ryzen 5 1500X, Memory: 16 GB RAM, Graphics: NVIDIA GTX 1060 / AMD RX 580, Storage: 100 GB available space", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 25, 0.0, "Cyberpunk 2078 - Night City Stories", "Delve deeper into Night City with the Night City Stories DLC for Cyberpunk 2078, featuring new missions, characters, and cyber-enhancements.", "CD Projekt Red", null, 25, null, "OS: Windows 10, Processor: Intel Core i5-4670K / AMD Ryzen 5 3600, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5600 XT, Storage: 70 GB available space", 19.99m, "CD Projekt", "OS: Windows 10, Processor: Intel Core i7-7700K / AMD Ryzen 7 3700X, Memory: 16 GB RAM, Graphics: NVIDIA GeForce RTX 3070 / AMD Radeon RX 6800 XT, Storage: 70 GB available space", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 26, 0.0, "The Legend of Zelda: Breath of the Wild 2 - Secrets of Hyrule", "Uncover the hidden secrets of Hyrule with new quests, dungeons, and mysteries in the Secrets of Hyrule DLC for Breath of the Wild 2.", "Nintendo", null, 26, null, "OS: Nintendo Switch", 14.99m, "Nintendo", "OS: Nintendo Switch", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 27, 0.0, "Stardew Valley - Farming Expansion Pack", "Expand your farm and experiences in Stardew Valley with the Farming Expansion Pack, introducing new crops, animals, and events.", "ConcernedApe", null, 27, null, "OS: Windows Vista or greater, Processor: 2 GHz, Memory: 2 GB RAM, Graphics: 256 MB video memory, DirectX 10, Storage: 500 MB available space", 9.99m, "ConcernedApe", "OS: Windows 7 or greater, Processor: 2.8 GHz, Memory: 4 GB RAM, Graphics: 512 MB video memory, DirectX 10, Storage: 500 MB available space", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 28, 4.5, "Minecraft: Dungeons - Jungle Awakens", "Embark on a journey through the dense jungles of Minecraft with new adventures and challenges in the Jungle Awakens DLC.", "Mojang Studios", null, 28, null, "OS: Windows 7 or higher, Processor: 2.8 GHz Core i3, Memory: 2 GB RAM, Graphics: Intel HD 4000, DirectX 11 compatible, Storage: 6 GB available space", 9.99m, "Mojang Studios", "OS: Windows 10, Processor: 3.3 GHz Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 660 / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 6 GB available space", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 29, 0.0, "Overwatch 2 - Heroes Unleashed", "Experience new heroes, maps, and intense battles in the Heroes Unleashed DLC for Overwatch 2.", "Blizzard Entertainment", null, 29, null, "OS: Windows 10, Processor: Intel Core i5, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 / AMD Radeon R9 280X, Storage: 50 GB available space", 14.99m, "Blizzard Entertainment", "OS: Windows 10, Processor: Intel Core i7, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 / AMD Radeon RX 5700, Storage: 50 GB available space", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 30, 0.0, "Subnautica: Below Zero", "Continue your underwater adventures with Subnautica: Below Zero, featuring a new frozen environment and mysteries to uncover.", "Unknown Worlds Entertainment", null, 30, null, "OS: Windows Vista SP2, Processor: Intel Haswell 2 cores / 4 threads @ 2.5 GHz, Memory: 4 GB RAM, Graphics: Intel HD 4600, DirectX 11 compatible, Storage: 20 GB available space", 19.99m, "Unknown Worlds Entertainment", "OS: Windows 7 SP1, Processor: Intel Haswell 4 cores / 4 threads @ 3.2 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 550 Ti / AMD Radeon HD 7850, DirectX 11 compatible, Storage: 20 GB available space", new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" },
                    { 31, 0.0, "Cyberpunk 2077 - Night City Chronicles", "Experience new adventures in Night City with the Night City Chronicles DLC for Cyberpunk 2077, including new storylines, characters, and weapons.", "CD Projekt Red", null, 3, null, "OS: Windows 7 or 10, Processor: Intel Core i5-3570K / AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 / AMD Radeon RX 470, Storage: 70 GB available space", 19.99m, "CD Projekt", "OS: Windows 10, Processor: Intel Core i7-4790 / AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 / AMD Radeon R9 Fury, Storage: 70 GB available space", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=exampledlctrailerurl" }
                });

            migrationBuilder.InsertData(
                table: "GameGameTags",
                columns: new[] { "GameId", "GameTagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 13 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 2 },
                    { 9, 11 },
                    { 10, 2 },
                    { 10, 5 },
                    { 11, 9 },
                    { 11, 11 },
                    { 12, 1 },
                    { 12, 3 },
                    { 13, 6 },
                    { 13, 12 },
                    { 14, 2 },
                    { 14, 4 },
                    { 15, 8 },
                    { 15, 10 },
                    { 16, 1 },
                    { 16, 3 },
                    { 17, 4 },
                    { 18, 5 },
                    { 18, 12 },
                    { 19, 1 },
                    { 19, 3 },
                    { 20, 6 },
                    { 20, 7 },
                    { 21, 11 },
                    { 22, 1 },
                    { 22, 15 },
                    { 23, 9 },
                    { 24, 1 },
                    { 24, 3 },
                    { 25, 1 },
                    { 25, 5 },
                    { 25, 7 },
                    { 26, 1 },
                    { 26, 4 },
                    { 26, 7 },
                    { 27, 10 },
                    { 27, 13 },
                    { 28, 1 },
                    { 28, 3 },
                    { 29, 2 },
                    { 29, 15 },
                    { 30, 16 }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 11 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 2 },
                    { 9, 12 },
                    { 10, 6 },
                    { 10, 12 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 1 },
                    { 12, 3 },
                    { 13, 4 },
                    { 13, 12 },
                    { 14, 4 },
                    { 14, 6 },
                    { 15, 8 },
                    { 15, 10 },
                    { 16, 1 },
                    { 16, 3 },
                    { 17, 7 },
                    { 18, 6 },
                    { 18, 9 },
                    { 19, 1 },
                    { 19, 3 },
                    { 20, 1 },
                    { 20, 2 },
                    { 21, 11 },
                    { 22, 1 },
                    { 22, 2 },
                    { 23, 8 },
                    { 23, 9 },
                    { 24, 1 },
                    { 24, 3 },
                    { 25, 3 },
                    { 25, 7 },
                    { 26, 1 },
                    { 26, 2 },
                    { 27, 10 },
                    { 28, 1 },
                    { 28, 2 },
                    { 29, 15 },
                    { 30, 2 },
                    { 30, 16 }
                });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/5/13/1431520130189/8bfad8ae-5a24-4617-988e-ccafee83324f-1020x612.jpeg?width=700&quality=85&auto=format&fit=max&s=8a7d3e78ea1329d9442f2b175bc7eb14" },
                    { 2, 1, "https://s1.dmcdn.net/v/7dQua1X-34xfWvryS/x1080" },
                    { 3, 1, "https://venturebeat.com/wp-content/uploads/2022/12/witcher-5.jpg?w=791&resize=1200%2C910&strip=all" },
                    { 4, 1, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp" },
                    { 5, 1, "https://assetsio.reedpopcdn.com/Site_qTBBJD0.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 6, 2, "https://link-to-first-image-for-RDR2.com" },
                    { 7, 2, "https://link-to-second-image-for-RDR2.com" },
                    { 8, 2, "https://link-to-third-image-for-RDR2.com" },
                    { 9, 2, "https://link-to-four-image-for-RDR2.com" }
                });

            migrationBuilder.InsertData(
                table: "GameLanguages",
                columns: new[] { "GameId", "LanguageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 13, 5 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 14, 5 },
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 15, 4 },
                    { 15, 5 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 4 },
                    { 16, 5 },
                    { 17, 1 },
                    { 17, 2 },
                    { 17, 3 },
                    { 17, 4 },
                    { 17, 5 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 18, 4 },
                    { 18, 5 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 19, 4 },
                    { 19, 5 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 4 },
                    { 20, 5 },
                    { 21, 1 },
                    { 21, 2 },
                    { 21, 3 },
                    { 21, 4 },
                    { 21, 5 },
                    { 22, 1 },
                    { 22, 2 },
                    { 22, 3 },
                    { 22, 4 },
                    { 22, 5 },
                    { 23, 1 },
                    { 23, 2 },
                    { 23, 3 },
                    { 23, 4 },
                    { 23, 5 },
                    { 24, 1 },
                    { 24, 2 },
                    { 24, 3 },
                    { 24, 4 },
                    { 24, 5 },
                    { 25, 1 },
                    { 25, 2 },
                    { 25, 3 },
                    { 25, 4 },
                    { 25, 5 },
                    { 26, 1 },
                    { 26, 2 },
                    { 26, 3 },
                    { 26, 4 },
                    { 26, 5 },
                    { 27, 1 },
                    { 27, 2 },
                    { 27, 3 },
                    { 27, 4 },
                    { 27, 5 },
                    { 28, 1 },
                    { 28, 2 },
                    { 28, 3 },
                    { 28, 4 },
                    { 28, 5 },
                    { 29, 1 },
                    { 29, 2 },
                    { 29, 3 },
                    { 29, 4 },
                    { 29, 5 },
                    { 30, 1 },
                    { 30, 2 },
                    { 30, 3 },
                    { 30, 4 },
                    { 30, 5 }
                });

            migrationBuilder.InsertData(
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 15, 4 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 },
                    { 17, 1 },
                    { 17, 4 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 21, 1 },
                    { 22, 1 },
                    { 22, 2 },
                    { 22, 3 },
                    { 23, 1 },
                    { 23, 2 },
                    { 23, 4 },
                    { 24, 1 },
                    { 25, 1 },
                    { 25, 2 },
                    { 25, 3 },
                    { 26, 4 },
                    { 27, 1 },
                    { 27, 2 },
                    { 27, 4 },
                    { 28, 1 },
                    { 28, 4 },
                    { 29, 1 },
                    { 29, 2 },
                    { 29, 3 },
                    { 30, 1 },
                    { 30, 4 }
                });

            migrationBuilder.InsertData(
                table: "DLCImages",
                columns: new[] { "Id", "Caption", "DLCId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "The Witcher 3: Hearts of Stone DLC Image 1", 1, "https://static.wikia.nocookie.net/witcher/images/0/09/Tw3_expansion_pack_hos.jpg/revision/latest?cb=20150908190146" },
                    { 2, "The Witcher 3: Hearts of Stone DLC Image 2", 1, "https://example.com/path_to_second_image.jpg" },
                    { 3, "The Witcher 3: Hearts of Stone DLC Image 3", 1, "https://example.com/path_to_third_image.jpg" }
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
                name: "IX_Billings_UserId",
                table: "Billings",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

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
                column: "DLCId");

            migrationBuilder.CreateIndex(
                name: "IX_DLCs_GameId",
                table: "DLCs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_DLCs_MainDLCImageId",
                table: "DLCs",
                column: "MainDLCImageId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGameTags_GameTagId",
                table: "GameGameTags",
                column: "GameTagId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GenreId",
                table: "GameGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GameImages_GameId",
                table: "GameImages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguages_LanguageId",
                table: "GameLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_PlatformId",
                table: "GamePlatforms",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AgeRatingId",
                table: "Games",
                column: "AgeRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ApplicationUserId",
                table: "Games",
                column: "ApplicationUserId");

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
                name: "IX_Orders_BillingId",
                table: "Orders",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BillingId",
                table: "PaymentMethods",
                column: "BillingId");

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
                name: "IX_UserFriends_FriendId",
                table: "UserFriends",
                column: "FriendId");

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
                name: "FK_DLCImages_DLCs_DLCId",
                table: "DLCImages",
                column: "DLCId",
                principalTable: "DLCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_ApplicationUserId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_DLCs_Games_GameId",
                table: "DLCs");

            migrationBuilder.DropForeignKey(
                name: "FK_DLCImages_DLCs_DLCId",
                table: "DLCImages");

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
                name: "GameGameTags");

            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "GameImages");

            migrationBuilder.DropTable(
                name: "GameLanguages");

            migrationBuilder.DropTable(
                name: "GamePlatforms");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "AgeRatings");

            migrationBuilder.DropTable(
                name: "DLCs");

            migrationBuilder.DropTable(
                name: "DLCImages");
        }
    }
}
