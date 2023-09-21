﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
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
                    table.ForeignKey(
                        name: "FK_DLCs_Games_GameId",
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
                        onDelete: ReferentialAction.Restrict);
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
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
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
                    table.ForeignKey(
                        name: "FK_DLCImages_DLCs_DLCId",
                        column: x => x.DLCId,
                        principalTable: "DLCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DLCImages_DLCs_DLCId1",
                        column: x => x.DLCId1,
                        principalTable: "DLCs",
                        principalColumn: "Id");
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
                values: new object[] { "eabac265-7f54-45bd-b77b-65df399594e8", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AchievementsDb", "Address", "Bio", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FavoriteGame", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TotalGamesPlayed", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "66aa6d15-c7ad-4ad8-9f98-7d0f35264bda", 0, "", "", null, null, "c63a2b66-acfb-457a-9d05-c088fa150b11", null, "user@videogameshop.com", true, null, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAENyDK303FomGHPu967XWLQtrqzhqCyN4TnV9vGoNhFTrvXfV47uyyKVqIgM8JiTFxA==", null, false, null, "b59b968c-702c-4ce2-a283-328a686d961f", null, 0, false, "user" },
                    { "a9507ff2-9097-4cfb-93a4-f64db2dae03c", 0, "", "", null, null, "77ac692a-cb51-4f22-a39b-3265f6ce8810", null, "admin@videogameshop.com", true, null, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEOCIkEi1CiVwcJ3ogDKavonYSpncS0FDdQhqB/+PAP2rfyZIVMLU8IEwrK2uh4pXuA==", null, false, null, "1d01d425-2142-427d-a873-fe44c1f1cfac", null, 0, false, "admin" }
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
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Medieval" },
                    { 3, "Story Rich" },
                    { 4, "Sci-Fi" },
                    { 5, "Post-Apocalyptic" },
                    { 6, "Horror" },
                    { 7, "Survival" },
                    { 8, "Retro" },
                    { 9, "Puzzle" },
                    { 10, "Platformer" },
                    { 11, "Shooter" },
                    { 12, "Strategy" },
                    { 13, "RPG" },
                    { 14, "VR" },
                    { 15, "Multiplayer" },
                    { 16, "Singleplayer" },
                    { 17, "Racing" },
                    { 18, "Sports" },
                    { 19, "Open World" },
                    { 20, "Sandbox" },
                    { 21, "City Builder" },
                    { 22, "Management" },
                    { 23, "Simulation" },
                    { 24, "Turn-Based" },
                    { 25, "Roguelike" },
                    { 26, "Narrative" },
                    { 27, "Visual Novel" },
                    { 28, "Anime" },
                    { 29, "Pixel Art" },
                    { 30, "Crafting" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eabac265-7f54-45bd-b77b-65df399594e8", "a9507ff2-9097-4cfb-93a4-f64db2dae03c" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AgeRatingId", "ApplicationUserId", "AverageRating", "CoverImage", "CreatedAt", "Description", "Developer", "DiscountedPrice", "ESRBContentDescriptions", "HasMultiplayerSupport", "MinimumSystemRequirements", "NumberOfLocalPlayers", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "Title", "TrailerUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, null, 4.7999999999999998, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(7943), "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.", "CD Projekt Red", null, null, false, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space", 1, 29.99m, null, "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=c0i88t0Kacs", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(7946) },
                    { 2, 2, null, 4.9000000000000004, "https://www.rockstargames.com/reddeadredemption2/rockstar_games/r_d_r_logo.jpg", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9196), "Red Dead Redemption 2 is an action-adventure game set in the Wild West.", "Rockstar Games", null, null, true, "OS: Windows 7 (64-bit), Processor: Intel Core i5-2500K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770, Storage: 150 GB available space", 1, 49.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 150 GB available space", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption 2", "https://www.youtube.com/watch?v=eaW0tYpxyp0", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9197) },
                    { 3, 2, null, 4.0, "https://www.cyberpunk.net/build/images/home/title-c-logo-8d1c4e3341.svg", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9207), "Cyberpunk 2077 is a role-playing video game developed and published by CD Projekt.", "CD Projekt Red", null, null, false, "OS: Windows 7 (64-bit), Processor: Intel Core i5-3570K, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780, Storage: 70 GB available space", 1, 59.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1060, Storage: 70 GB available space", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=vjF9GgrY9c0", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9207) },
                    { 4, 2, null, 4.5, "https://bethesda.net/game/doom2016", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9272), "Doom Eternal is a first-person shooter video game developed by id Software and published by Bethesda Softworks.", "id Software", null, null, false, "OS: Windows 7 (64-bit), Processor: Intel Core i5-2400, Memory: 8 GB RAM, Graphics: NVIDIA GTX 670, Storage: 50 GB available space", 1, 39.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700K, Memory: 8 GB RAM, Graphics: NVIDIA GTX 1060, Storage: 50 GB available space", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doom Eternal", "https://www.youtube.com/watch?v=FkklG9MA0vM", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9272) },
                    { 5, 2, null, 4.5999999999999996, "https://www.ubisoft.com/en-gb/game/assassins-creed/valhalla", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9277), "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal.", "Ubisoft", null, null, false, "OS: Windows 10 (64-bit), Processor: Intel Core i5-4460, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960, Storage: 50 GB available space", 1, 49.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i7-6700, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 1080, Storage: 50 GB available space", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", "https://www.youtube.com/watch?v=SSYlfRq4ysA", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9277) },
                    { 6, 3, null, 4.7000000000000002, "https://www.ubisoft.com/en-us/game/far-cry/far-cry-6", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9286), "Far Cry 6 is an action-adventure game set in a fictional Caribbean island nation.", "Ubisoft", null, null, true, "OS: Windows 10 (64-bit), Processor: AMD Ryzen 3 1200 or Intel Core i5-4460, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 or AMD Radeon R9 280X, Storage: 60 GB available space", 1, 59.99m, null, "OS: Windows 10 (64-bit), Processor: AMD Ryzen 5 3600X or Intel Core i7-7700, Memory: 16 GB RAM, Graphics: NVIDIA GeForce GTX 1660 Ti or AMD Radeon RX 5700 XT, Storage: 60 GB available space", new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Far Cry 6", "https://www.youtube.com/watch?v=-TmAE6MDlrc", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9286) },
                    { 7, 1, null, 4.9000000000000004, "https://www.minecraft.net/en-us/", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9289), "Minecraft is a sandbox video game that allows players to build and explore their own virtual worlds.", "Mojang Studios", null, null, true, "OS: Windows 7 (64-bit), Processor: Intel Core i3-3210, Memory: 4 GB RAM, Graphics: Integrated GPU (Intel HD Graphics 4000 or equivalent), Storage: 4 GB available space", 4, 29.99m, null, "OS: Windows 10 (64-bit), Processor: Intel Core i5-4690, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 960 or equivalent, Storage: 4 GB available space", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=MmB9b5njVbA", new DateTime(2023, 9, 21, 11, 11, 49, 737, DateTimeKind.Utc).AddTicks(9290) }
                });

            migrationBuilder.InsertData(
                table: "DLCs",
                columns: new[] { "Id", "AverageRating", "DLCImageId", "DLCName", "Description", "Developer", "DiscountedPrice", "GameId", "MinimumSystemRequirements", "Price", "Publisher", "RecommendedSystemRequirements", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, null, null, "The Witcher 3: Hearts of Stone", "Embark on a new adventure as Geralt of Rivia in the Hearts of Stone expansion.", null, null, 1, null, 9.99m, null, null, new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, null, "The Witcher 3: Blood and Wine", "Visit the picturesque land of Toussaint in the Blood and Wine expansion.", null, null, 1, null, 19.99m, null, null, new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, null, "RDR2: Frontier Tales", "Experience new stories from the Wild West in the Frontier Tales expansion.", null, null, 2, null, 14.99m, null, null, new DateTime(2019, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, null, "RDR2: Legend of the East", "Unlock the mysteries of the East in this exciting new DLC.", null, null, 2, null, 19.99m, null, null, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, null, "Cyberpunk: Night City Stories", "Dive deeper into Night City with additional quests and characters.", null, null, 3, null, 12.99m, null, null, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, null, "Cyberpunk: Beyond the Wall", "Venture beyond the city limits and explore the wastelands.", null, null, 3, null, 24.99m, null, null, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, null, "Doom Eternal: Hell's Ascent", "Climb through the new challenges and face tougher demons.", null, null, 4, null, 19.99m, null, null, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, null, "Doom Eternal: The Slayer's Return", "Return to the origin of the Slayer and discover his roots.", null, null, 4, null, 19.99m, null, null, new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, null, null, "AC Valhalla: Rise of the Druids", "Travel to Ireland and confront the Druid cult.", null, null, 5, null, 24.99m, null, null, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, null, null, "AC Valhalla: The Siege of Paris", "Invade the fortified city of Paris and shape its future.", null, null, 5, null, 24.99m, null, null, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 6, 1, "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/5/13/1431520130189/8bfad8ae-5a24-4617-988e-ccafee83324f-1020x612.jpeg?width=700&quality=85&auto=format&fit=max&s=8a7d3e78ea1329d9442f2b175bc7eb14" },
                    { 7, 1, "https://s1.dmcdn.net/v/7dQua1X-34xfWvryS/x1080" },
                    { 8, 1, "https://venturebeat.com/wp-content/uploads/2022/12/witcher-5.jpg?w=791&resize=1200%2C910&strip=all" },
                    { 9, 1, "https://media.thenerdstash.com/wp-content/uploads/2022/12/GOG-Winter-Sale.jpg.webp" },
                    { 10, 1, "https://assetsio.reedpopcdn.com/Site_qTBBJD0.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 11, 2, "https://link-to-first-image-for-RDR2.com" },
                    { 12, 2, "https://link-to-second-image-for-RDR2.com" },
                    { 16, 3, "https://link-to-first-image-for-cyberpunk2077.com" },
                    { 17, 3, "https://link-to-second-image-for-cyberpunk2077.com" },
                    { 21, 4, "https://link-to-first-image-for-doom-eternal.com" },
                    { 22, 4, "https://link-to-second-image-for-doom-eternal.com" },
                    { 26, 5, "https://link-to-first-image-for-AC-valhalla.com" },
                    { 27, 5, "https://link-to-second-image-for-AC-valhalla.com" }
                });

            migrationBuilder.InsertData(
                table: "DLCImages",
                columns: new[] { "Id", "Caption", "DLCId", "DLCId1", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "The Witcher 3: Hearts of Stone DLC Image", 1, null, "https://static.wikia.nocookie.net/witcher/images/0/09/Tw3_expansion_pack_hos.jpg/revision/latest?cb=20150908190146" },
                    { 2, "The Witcher 3: Blood and Wine DLC Image", 2, null, "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "GameGameTags");

            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "GameImages");

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
                name: "Games");

            migrationBuilder.DropTable(
                name: "AgeRatings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
