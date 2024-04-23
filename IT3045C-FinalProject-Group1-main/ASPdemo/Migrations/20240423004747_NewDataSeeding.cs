using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPdemo.Migrations
{
    /// <inheritdoc />
    public partial class NewDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "651e37ee-5dbb-4df9-9dde-2ffd96feecec");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7269", "d7dccd18-3e8e-4626-9f0d-761cc657fc7d", "guests", "GUESTS" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7269", "8e445865-a24d-4543-a6c6-9443d048c569" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b86b3ba8-fa48-4d26-b645-0253a5c6b4f7", "AQAAAAIAAYagAAAAEDa0KTWY93dqbmK67I43jQHgaWASv07PCyq0ScM6oGyWhM+NS509TkwV3ZrLirfqEg==", "782e10fe-c0ba-45c1-9218-2faa313d3c7e" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PermissionsLevel", "PhoneNumber", "PhoneNumberConfirmed", "PortfolioId", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048c569", 0, "6996c2fa-0f86-4d1d-b2cc-d44cae9a841f", "guest@guest.com", true, false, null, "GUEST@GUEST.COM", "GUEST", "AQAAAAIAAYagAAAAEAFHx3VNWJb+KvvAZj6R21NsniT21NyLp+AnUcKGyzr4SPUGnQnHtr+jlX8p5ZB7MA==", 0, null, false, 0, "8cfa1ac9-f67c-48db-a662-96358a992a9f", false, 0, "guest" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7269");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7269", "8e445865-a24d-4543-a6c6-9443d048c569" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048c569");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a94c3698-13e4-4c98-ba3a-be341f99f3c9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b2167f2-1fc8-4245-89f2-837ef86c3408", "AQAAAAIAAYagAAAAEA+4RxxlhWrUAsrpZ09k+etnk+XcOo2I9jEHM711r/UPXSlMeu9NZiAtcuvk2OUfxw==", "b7cb266c-a44a-4c0f-9fa7-e3e2adf3a1d5" });
        }
    }
}
