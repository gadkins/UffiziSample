using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Setup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Punchline = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joke", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Joke",
                columns: new[] { "Id", "Punchline", "Setup" },
                values: new object[] { 1, "I asked him, What’s the word on the street?", "Yesterday I saw a guy spill all his Scrabble letters on the road" });

            migrationBuilder.InsertData(
                table: "Joke",
                columns: new[] { "Id", "Punchline", "Setup" },
                values: new object[] { 2, "He was just going through a stage", "Did you hear about the actor who fell through the floorboards?" });

            migrationBuilder.InsertData(
                table: "Joke",
                columns: new[] { "Id", "Punchline", "Setup" },
                values: new object[] { 3, "He just needed a little space", "Did you hear about the claustrophobic astronaut?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joke");
        }
    }
}
