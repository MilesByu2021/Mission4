using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddNewMovies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNewMovies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "AddNewMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Marfia", "Francis Ford Coppola", false, "Shaun", "Michael is the real boss", "R", "The Godfather", 1972 });

            migrationBuilder.InsertData(
                table: "AddNewMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Jon Watts", false, "Thor", "Peter Parker is Spiderman", "PG-13", "Spider-Man: No Way Home", 2022 });

            migrationBuilder.InsertData(
                table: "AddNewMovies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Robert Schwentke", true, "Caden", "Sanke Eyes can speak!", "PG-13", "Snake Eyes", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddNewMovies");
        }
    }
}
