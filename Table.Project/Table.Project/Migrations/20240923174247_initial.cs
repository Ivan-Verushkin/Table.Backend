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
                    { 29, 29, "Ferland Mendy", "Defender", 81, "Defense" },
                    { 30, 30, "Harry Kane", "Forward", 90, "Finishing" },
                    { 31, 31, "Son Heung-Min", "Forward", 88, "Finishing" },
                    { 32, 28, "Pierre-Emile Højbjerg", "Midfielder", 0, "Defensive Midfield" },
                    { 33, 25, "Cristian Romero", "Defender", 85, "Defense" },
                    { 34, 26, "Rodrigo Bentancur", "Midfielder", 83, "Playmaker" },
                    { 35, 31, "Jan Oblak", "Goalkeeper", 91, "Goalkeeping" },
                    { 36, 33, "Antoine Griezmann", "Forward", 88, "Finishing" },
                    { 37, 28, "Marcos Llorente", "Midfielder", 85, "Versatile" },
                    { 38, 29, "José María Giménez", "Defender", 85, "Defense" },
                    { 39, 29, "Saúl Ñíguez", "Midfielder", 82, "Midfield Control" },
                    { 40, 30, "Sandesh Jhingan", "Defender", 74, "Defense" },
                    { 41, 39, "Sunil Chhetri", "Forward", 78, "Finishing" },
                    { 42, 26, "Anirudh Thapa", "Midfielder", 72, "Midfield Control" },
                    { 43, 26, "Lallianzuala Chhangte", "Forward", 70, "Winger" },
                    { 44, 30, "Amrinder Singh", "Goalkeeper", 68, "Goalkeeping" },
                    { 45, 30, "Memphis Depay", "Forward", 84, "Finishing" },
                    { 46, 32, "Koke", "Midfielder", 85, "Playmaker" },
                    { 47, 37, "Hugo Lloris", "Goalkeeper", 85, "Goalkeeping" },
                    { 48, 34, "Ivan Perišić", "Midfielder", 84, "Winger" },
                    { 49, 26, "Richarlison", "Forward", 83, "Finishing" },
                    { 50, 26, "Rohit Kumar", "Midfielder", 65, "Midfield Control" },
                    { 51, 35, "Mourtada Fall", "Defender", 72, "Defense" },
                    { 52, 26, "Ashique Kuruniyan", "Forward", 68, "Winger" },
                    { 53, 44, "Florin Cernat", "Midfielder", 80, "Veteran Midfield" },
                    { 54, 26, "Renato Sanches", "Midfielder", 83, "Midfield Power" },
                    { 55, 27, "Sergio Reguilón", "Defender", 82, "Defense" },
                    { 56, 28, "Moses Simon", "Forward", 82, "Winger" },
                    { 57, 30, "Yannick Carrasco", "Forward", 85, "Winger" },
                    { 58, 20, "Jude Bellingham", "Midfielder", 86, "Playmaker" },
                    { 59, 24, "João Félix", "Forward", 84, "Playmaker" },
                    { 60, 33, "Stefan Savić", "Defender", 83, "Defense" },
                    { 61, 29, "Reinildo Mandava", "Defender", 81, "Defense" },
                    { 62, 26, "Ruben Dias", "Defender", 87, "Defense" },
                    { 63, 37, "Sergio Ramos", "Defender", 83, "Defense" },
                    { 64, 32, "David de Gea", "Goalkeeper", 86, "Goalkeeping" },
                    { 65, 31, "Mohamed Salah", "Forward", 90, "Finishing" },
                    { 66, 32, "Virgil van Dijk", "Defender", 89, "Defense" },
                    { 67, 24, "Declan Rice", "Midfielder", 87, "Defensive Midfield" }
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
