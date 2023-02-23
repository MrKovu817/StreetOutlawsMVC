using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StreetOutlaws.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatabase01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fire" },
                    { 2, "Earth" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[] { 1, "DeJuan Colbert", 1 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DriverId", "Make", "Model", "Year" },
                values: new object[] { 1, 1, "Pontiac", "GTO", 1970 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
