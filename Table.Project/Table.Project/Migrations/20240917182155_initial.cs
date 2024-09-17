using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Table.Project.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FifaSoccerers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FifaSoccerers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FifaSoccerers",
                columns: new[] { "Id", "Age", "Name", "Position", "Score", "Skill" },
                values: new object[,]
                {
                    { 1, 31, "Marc-André ter Stegen", "Goalkeeper", 88, "Goalkeeping" },
                    { 2, 24, "Jules Koundé", "Defender", 85, "Defense" },
                    { 3, 24, "Ronald Araújo", "Defender", 86, "Defense" },
                    { 4, 21, "Pedri", "Midfielder", 88, "Passing" },
                    { 5, 19, "Gavi", "Midfielder", 84, "Dribbling" },
                    { 6, 35, "Robert Lewandowski", "Forward", 91, "Finishing" },
                    { 7, 26, "Frenkie de Jong", "Midfielder", 87, "Passing" },
                    { 8, 23, "Ferran Torres", "Forward", 82, "Dribbling" },
                    { 9, 21, "Ansu Fati", "Forward", 81, "Finishing" },
                    { 10, 31, "Sergi Roberto", "Midfielder", 79, "Versatile" },
                    { 11, 31, "Thibaut Courtois", "Goalkeeper", 90, "Goalkeeping" },
                    { 12, 26, "Éder Militão", "Defender", 85, "Defense" },
                    { 13, 31, "David Alaba", "Defender", 85, "Defense" },
                    { 14, 34, "Toni Kroos", "Midfielder", 88, "Passing" },
                    { 15, 38, "Luka Modrić", "Midfielder", 88, "Vision" },
                    { 16, 25, "Federico Valverde", "Midfielder", 87, "Versatile" },
                    { 17, 23, "Vinícius Júnior", "Forward", 90, "Dribbling" },
                    { 18, 23, "Rodrygo", "Forward", 85, "Dribbling" },
                    { 19, 30, "Antonio Rüdiger", "Defender", 84, "Defense" },
                    { 20, 23, "Aurélien Tchouaméni", "Midfielder", 84, "Defense" },
                    { 21, 27, "Andreas Christensen", "Defender", 83, "Defense" },
                    { 22, 23, "Sergiño Dest", "Defender", 78, "Dribbling" },
                    { 23, 33, "Marcos Alonso", "Defender", 79, "Defense" },
                    { 24, 24, "Ferran Jutglà", "Forward", 77, "Finishing" },
                    { 25, 25, "Iñaki Peña", "Goalkeeper", 75, "Goalkeeping" },
                    { 26, 24, "Fran García", "Defender", 80, "Defense" },
                    { 27, 34, "Joselu", "Forward", 82, "Finishing" },
                    { 28, 21, "Eduardo Camavinga", "Midfielder", 85, "Versatile" },
                    { 29, 29, "Ferland Mendy", "Defender", 81, "Defense" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FifaSoccerers");
        }
    }
}
