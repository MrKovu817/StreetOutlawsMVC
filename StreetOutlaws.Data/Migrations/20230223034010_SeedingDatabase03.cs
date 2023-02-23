using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreetOutlaws.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatabase03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "DriverId",
                value: 12);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "DriverId",
                value: 812);
        }
    }
}
