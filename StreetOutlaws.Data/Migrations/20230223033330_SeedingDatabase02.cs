using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StreetOutlaws.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatabase02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DriverId", "Make", "Model", "Year" },
                values: new object[] { 12, 812, "Chevrolet", "C10", 1970 });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 2, "Zachary Himes", 1 },
                    { 3, "Jordan Hershberger", 1 },
                    { 4, "Brody Hinton", 1 },
                    { 5, "Darneisha Miller", 2 },
                    { 6, "Cory Smith", 2 },
                    { 7, "Jamie Coakley", 2 },
                    { 8, "Michael Kinsey", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Water");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Wind" },
                    { 4, "Earth" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DriverId", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 2, 2, "Chevy", "Camero", 1969 },
                    { 3, 3, "Chevy", "Camero", 1999 },
                    { 4, 4, "Chevy", "Camero", 2010 },
                    { 5, 5, "Chevrolet", "Chevy II Nova", 1963 },
                    { 6, 6, "Chevrolet", "Chevy II Nova", 1965 },
                    { 7, 7, "Chevrolet", "El Camino", 1969 },
                    { 8, 8, "Chevrolet", "El Camino", 1981 }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 9, "Celio Arias", 3 },
                    { 10, "Cassandra Emery", 3 },
                    { 11, "Catlin Simon", 3 },
                    { 12, "Terry Brown", 3 },
                    { 13, "Nelson Fant IV", 4 },
                    { 14, "Charles Lipperd", 4 },
                    { 15, "Adam Lair", 4 },
                    { 16, "Katelyn Hedlund", 4 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DriverId", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 9, 9, "Pontiac", "LeMans", 1969 },
                    { 10, 10, "Pontiac", "LeMans", 1972 },
                    { 11, 11, "Chevrolet", "Vega", 1977 },
                    { 13, 13, "Chevrolet", "Monte Carlo", 1971 },
                    { 14, 14, "Dodge", "Dart", 1967 },
                    { 15, 15, "Ford", "Mustang", 1981 },
                    { 16, 16, "Ford", "Mustang", 2010 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Earth");
        }
    }
}
