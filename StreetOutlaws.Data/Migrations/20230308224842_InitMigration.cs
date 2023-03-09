using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StreetOutlaws.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fire" },
                    { 2, "Water" },
                    { 3, "Wind" },
                    { 4, "Earth" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indianapolis,Indiana" },
                    { 2, "Detroit,Michigan" },
                    { 3, "Chicago,Illinois" },
                    { 4, "Columbus,Ohio" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, "DeJuan Colbert", 1 },
                    { 2, "Zachary Himes", 1 },
                    { 3, "Jordan Hershberger", 1 },
                    { 4, "Brody Hinton", 1 },
                    { 5, "Darneisha Miller", 2 },
                    { 6, "Cory Smith", 2 },
                    { 7, "Jamie Coakley", 2 },
                    { 8, "Michael Kinsey", 2 },
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
                    { 1, 1, "Pontiac", "GTO", 1970 },
                    { 2, 2, "Chevy", "Camero", 1969 },
                    { 3, 3, "Chevy", "Camero", 1999 },
                    { 4, 4, "Chevy", "Camero", 2010 },
                    { 5, 5, "Chevrolet", "Chevy II Nova", 1963 },
                    { 6, 6, "Chevrolet", "Chevy II Nova", 1965 },
                    { 7, 7, "Chevrolet", "El Camino", 1969 },
                    { 8, 8, "Chevrolet", "El Camino", 1981 },
                    { 9, 9, "Pontiac", "LeMans", 1969 },
                    { 10, 10, "Pontiac", "LeMans", 1972 },
                    { 11, 11, "Chevrolet", "Vega", 1977 },
                    { 12, 12, "Chevrolet", "C10", 1970 },
                    { 13, 13, "Chevrolet", "Monte Carlo", 1971 },
                    { 14, 14, "Dodge", "Dart", 1967 },
                    { 15, 15, "Ford", "Mustang", 1981 },
                    { 16, 16, "Ford", "Mustang", 2010 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DriverId",
                table: "Cars",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_TeamId",
                table: "Drivers",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
