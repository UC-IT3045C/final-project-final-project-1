using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPdemo.Migrations
{
    /// <inheritdoc />
    public partial class RemovedCrPtfTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrenciesPortfolios");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "090308e3-a486-4928-8ed9-2e676e9343b9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7269",
                column: "ConcurrencyStamp",
                value: "4f7e4cad-c588-46e4-af22-01c155720ec9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048c569",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71b6fb6e-dbc5-4ac2-b673-734bb18bb116", "AQAAAAIAAYagAAAAEIhO2LSV3q1u2bDofdPOIigYuk3PpF0L6+Sv+w/+e1SXIjqdbl4BINnHeDo1+xPMJA==", "3d8f681e-caf7-40b9-8b6c-10de12c8c73e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3854cea0-dbc3-4a42-8b70-e47d44484556", "AQAAAAIAAYagAAAAEORq9a8F/i/bjmPoNu+RD0eD6n3roWSQEb/7ZNXGYmulmx7LJJ4WbvtayAGlKNkQMw==", "79bdec91-f03d-49a5-a881-4b097cec4eaa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "401d327a-5ccf-4911-82e0-5205b4bda0b0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7269",
                column: "ConcurrencyStamp",
                value: "05393c2a-d153-4914-97a3-cc875057c6b1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048c569",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d2a6213-fa22-4436-83db-ccf443af2ef3", "AQAAAAIAAYagAAAAEGVv/4UQqCL5HniH4xdiu/baqWmqT3pDkDOHZEU90ksUyyORlXBed941Ue7N76JAiA==", "5de09719-d1d8-446e-9bce-51c82b025fa8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6e82e28-fab8-4a28-9e0b-139c13907168", "AQAAAAIAAYagAAAAEKzOuCo6yn1Z+9ox/0n4rnSwowbQ8G6bLknZ6rqf6l9xYJUkuzbFtTU4grygq3Z5ow==", "0fbdbb55-81a5-4263-b322-aaf96ac5c230" });

            migrationBuilder.CreateIndex(
                name: "IX_CurrenciesPortfolios_CurrencyId",
                table: "CurrenciesPortfolios",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrenciesPortfolios_PortfolioId",
                table: "CurrenciesPortfolios",
                column: "PortfolioId");
        }
    }
}
