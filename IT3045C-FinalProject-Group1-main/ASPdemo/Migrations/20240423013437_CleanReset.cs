using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPdemo.Migrations
{
    /// <inheritdoc />
    public partial class CleanReset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CMCCategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CategoryTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NumTokens = table.Column<int>(type: "INTEGER", nullable: false),
                    AvgPriceChange = table.Column<string>(type: "TEXT", nullable: false),
                    MarketCap = table.Column<string>(type: "TEXT", nullable: false),
                    MarketCapChange = table.Column<string>(type: "TEXT", nullable: false),
                    Volume = table.Column<string>(type: "TEXT", nullable: false),
                    VolumeChange = table.Column<string>(type: "TEXT", nullable: false),
                    LastUpdated = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Conversions",
                columns: table => new
                {
                    ConversionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pair1 = table.Column<string>(type: "TEXT", nullable: true),
                    Pair2 = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PercentChange24Hr = table.Column<double>(type: "REAL", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    Volume24 = table.Column<double>(type: "REAL", nullable: true),
                    PercentChange1hr = table.Column<double>(type: "REAL", nullable: true),
                    PercentChange7d = table.Column<double>(type: "REAL", nullable: true),
                    MarketCap = table.Column<double>(type: "REAL", nullable: true),
                    TotalSupply = table.Column<double>(type: "REAL", nullable: true),
                    SecondPercentChange24Hr = table.Column<double>(type: "REAL", nullable: true),
                    SecondDescription = table.Column<string>(type: "TEXT", nullable: true),
                    SecondPrice = table.Column<double>(type: "REAL", nullable: true),
                    SecondVolume24 = table.Column<double>(type: "REAL", nullable: true),
                    SecondPercentChange1hr = table.Column<double>(type: "REAL", nullable: true),
                    SecondPercentChange7d = table.Column<double>(type: "REAL", nullable: true),
                    SecondMarketCap = table.Column<double>(type: "REAL", nullable: true),
                    SecondTotalSupply = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversions", x => x.ConversionId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRoleClaim<string>",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim<string>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserClaim<string>",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioToken",
                columns: table => new
                {
                    PortfolioTokenId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TokenAmount = table.Column<string>(type: "TEXT", nullable: false),
                    TokenName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioToken", x => x.PortfolioTokenId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PortfolioId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermissionsLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CMCId = table.Column<string>(type: "TEXT", nullable: true),
                    CurrencyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Slug = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PercentChange24Hr = table.Column<double>(type: "REAL", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    Volume24 = table.Column<double>(type: "REAL", nullable: true),
                    PercentChange1hr = table.Column<double>(type: "REAL", nullable: true),
                    PercentChange7d = table.Column<double>(type: "REAL", nullable: true),
                    MarketCap = table.Column<double>(type: "REAL", nullable: true),
                    TotalSupply = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                    table.ForeignKey(
                        name: "FK_Currencies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WalletAddress = table.Column<string>(type: "TEXT", nullable: false),
                    PortfolioValue = table.Column<double>(type: "REAL", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioId);
                    table.ForeignKey(
                        name: "FK_Portfolios_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<string>(type: "TEXT", nullable: false),
                    UsersId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrenciesPortfolios",
                columns: table => new
                {
                    CurrenciesPortfoliosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrencyId = table.Column<int>(type: "INTEGER", nullable: false),
                    PortfolioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrenciesPortfolios", x => x.CurrenciesPortfoliosId);
                    table.ForeignKey(
                        name: "FK_CurrenciesPortfolios_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrenciesPortfolios_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "PortfolioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "401d327a-5ccf-4911-82e0-5205b4bda0b0", "admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7269", "05393c2a-d153-4914-97a3-cc875057c6b1", "guests", "GUESTS" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7269", "8e445865-a24d-4543-a6c6-9443d048c569" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermissionsLevel", "PhoneNumber", "PhoneNumberConfirmed", "PortfolioId", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048c569", 0, "8d2a6213-fa22-4436-83db-ccf443af2ef3", "guest@guest.com", true, false, null, "GUEST@GUEST.COM", "GUEST", "AQAAAAIAAYagAAAAEGVv/4UQqCL5HniH4xdiu/baqWmqT3pDkDOHZEU90ksUyyORlXBed941Ue7N76JAiA==", 0, null, false, 0, "5de09719-d1d8-446e-9bce-51c82b025fa8", false, 0, "guest" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "f6e82e28-fab8-4a28-9e0b-139c13907168", "grantrynders@outlook.com", true, false, null, "GRANTRYNDERS@OUTLOOK.COM", "ADMIN", "AQAAAAIAAYagAAAAEKzOuCo6yn1Z+9ox/0n4rnSwowbQ8G6bLknZ6rqf6l9xYJUkuzbFtTU4grygq3Z5ow==", 0, null, false, 0, "0fbdbb55-81a5-4263-b322-aaf96ac5c230", false, 0, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_CategoryId",
                table: "Currencies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrenciesPortfolios_CurrencyId",
                table: "CurrenciesPortfolios",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrenciesPortfolios_PortfolioId",
                table: "CurrenciesPortfolios",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolios",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conversions");

            migrationBuilder.DropTable(
                name: "CurrenciesPortfolios");

            migrationBuilder.DropTable(
                name: "IdentityRoleClaim<string>");

            migrationBuilder.DropTable(
                name: "IdentityUserClaim<string>");

            migrationBuilder.DropTable(
                name: "PortfolioToken");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
