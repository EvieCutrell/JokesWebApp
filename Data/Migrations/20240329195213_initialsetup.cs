using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokesWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jokeQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jokeAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joke", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joke");
        }
    }
}
