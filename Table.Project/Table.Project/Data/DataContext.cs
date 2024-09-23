using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Table.Project.Models;

namespace Table.Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<FifaSoccerer> FifaSoccerers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FifaSoccerer>().HasData(
                // Barcelona Players
                new FifaSoccerer { Id = 1, Name = "Marc-André ter Stegen", Age = 31, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 88 },
                new FifaSoccerer { Id = 2, Name = "Jules Koundé", Age = 24, Skill = "Defense", Position = "Defender", Score = 85 },
                new FifaSoccerer { Id = 3, Name = "Ronald Araújo", Age = 24, Skill = "Defense", Position = "Defender", Score = 86 },
                new FifaSoccerer { Id = 4, Name = "Pedri", Age = 21, Skill = "Passing", Position = "Midfielder", Score = 88 },
                new FifaSoccerer { Id = 5, Name = "Gavi", Age = 19, Skill = "Dribbling", Position = "Midfielder", Score = 84 },
                new FifaSoccerer { Id = 6, Name = "Robert Lewandowski", Age = 35, Skill = "Finishing", Position = "Forward", Score = 91 },
                new FifaSoccerer { Id = 7, Name = "Frenkie de Jong", Age = 26, Skill = "Passing", Position = "Midfielder", Score = 87 },
                new FifaSoccerer { Id = 8, Name = "Ferran Torres", Age = 23, Skill = "Dribbling", Position = "Forward", Score = 82 },
                new FifaSoccerer { Id = 9, Name = "Ansu Fati", Age = 21, Skill = "Finishing", Position = "Forward", Score = 81 },
                new FifaSoccerer { Id = 10, Name = "Sergi Roberto", Age = 31, Skill = "Versatile", Position = "Midfielder", Score = 79 },

                // Real Madrid Players
                new FifaSoccerer { Id = 11, Name = "Thibaut Courtois", Age = 31, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 90 },
                new FifaSoccerer { Id = 12, Name = "Éder Militão", Age = 26, Skill = "Defense", Position = "Defender", Score = 85 },
                new FifaSoccerer { Id = 13, Name = "David Alaba", Age = 31, Skill = "Defense", Position = "Defender", Score = 85 },
                new FifaSoccerer { Id = 14, Name = "Toni Kroos", Age = 34, Skill = "Passing", Position = "Midfielder", Score = 88 },
                new FifaSoccerer { Id = 15, Name = "Luka Modrić", Age = 38, Skill = "Vision", Position = "Midfielder", Score = 88 },
                new FifaSoccerer { Id = 16, Name = "Federico Valverde", Age = 25, Skill = "Versatile", Position = "Midfielder", Score = 87 },
                new FifaSoccerer { Id = 17, Name = "Vinícius Júnior", Age = 23, Skill = "Dribbling", Position = "Forward", Score = 90 },
                new FifaSoccerer { Id = 18, Name = "Rodrygo", Age = 23, Skill = "Dribbling", Position = "Forward", Score = 85 },
                new FifaSoccerer { Id = 19, Name = "Antonio Rüdiger", Age = 30, Skill = "Defense", Position = "Defender", Score = 84 },
                new FifaSoccerer { Id = 20, Name = "Aurélien Tchouaméni", Age = 23, Skill = "Defense", Position = "Midfielder", Score = 84 },

                // Additional Barcelona Players
                new FifaSoccerer { Id = 21, Name = "Andreas Christensen", Age = 27, Skill = "Defense", Position = "Defender", Score = 83 },
                new FifaSoccerer { Id = 22, Name = "Sergiño Dest", Age = 23, Skill = "Dribbling", Position = "Defender", Score = 78 },
                new FifaSoccerer { Id = 23, Name = "Marcos Alonso", Age = 33, Skill = "Defense", Position = "Defender", Score = 79 },
                new FifaSoccerer { Id = 24, Name = "Ferran Jutglà", Age = 24, Skill = "Finishing", Position = "Forward", Score = 77 },
                new FifaSoccerer { Id = 25, Name = "Iñaki Peña", Age = 25, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 75 },
                // Additional Real Madrid Players
                new FifaSoccerer { Id = 26, Name = "Fran García", Age = 24, Skill = "Defense", Position = "Defender", Score = 80 },
                new FifaSoccerer { Id = 27, Name = "Joselu", Age = 34, Skill = "Finishing", Position = "Forward", Score = 82 },
                new FifaSoccerer { Id = 28, Name = "Eduardo Camavinga", Age = 21, Skill = "Versatile", Position = "Midfielder", Score = 85 },
                new FifaSoccerer { Id = 29, Name = "Ferland Mendy", Age = 29, Skill = "Defense", Position = "Defender", Score = 81 },
// Additional Players
new FifaSoccerer { Id = 30, Name = "Harry Kane", Age = 30, Skill = "Finishing", Position = "Forward", Score = 90},
new FifaSoccerer { Id = 31, Name = "Son Heung-Min", Age = 31, Skill = "Finishing", Position = "Forward", Score = 88},
new FifaSoccerer { Id = 32, Name = "Pierre-Emile Højbjerg", Age = 28, Skill = "Defensive Midfield", Position = "Midfielder"},
new FifaSoccerer { Id = 33, Name = "Cristian Romero", Age = 25, Skill = "Defense", Position = "Defender", Score = 85 },
new FifaSoccerer { Id = 34, Name = "Rodrigo Bentancur", Age = 26, Skill = "Playmaker", Position = "Midfielder", Score = 83 },
new FifaSoccerer { Id = 35, Name = "Jan Oblak", Age = 31, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 91},
new FifaSoccerer { Id = 36, Name = "Antoine Griezmann", Age = 33, Skill = "Finishing", Position = "Forward", Score = 88 },
new FifaSoccerer { Id = 37, Name = "Marcos Llorente", Age = 28, Skill = "Versatile", Position = "Midfielder", Score = 85 },
new FifaSoccerer { Id = 38, Name = "José María Giménez", Age = 29, Skill = "Defense", Position = "Defender", Score = 85 },
new FifaSoccerer { Id = 39, Name = "Saúl Ñíguez", Age = 29, Skill = "Midfield Control", Position = "Midfielder", Score = 82 },
new FifaSoccerer { Id = 40, Name = "Sandesh Jhingan", Age = 30, Skill = "Defense", Position = "Defender", Score = 74 },
new FifaSoccerer { Id = 41, Name = "Sunil Chhetri", Age = 39, Skill = "Finishing", Position = "Forward", Score = 78 },
new FifaSoccerer { Id = 42, Name = "Anirudh Thapa", Age = 26, Skill = "Midfield Control", Position = "Midfielder", Score = 72 },
new FifaSoccerer { Id = 43, Name = "Lallianzuala Chhangte", Age = 26, Skill = "Winger", Position = "Forward", Score = 70 },
new FifaSoccerer { Id = 44, Name = "Amrinder Singh", Age = 30, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 68 },
new FifaSoccerer { Id = 45, Name = "Memphis Depay", Age = 30, Skill = "Finishing", Position = "Forward", Score = 84 },
new FifaSoccerer { Id = 46, Name = "Koke", Age = 32, Skill = "Playmaker", Position = "Midfielder", Score = 85 },
new FifaSoccerer { Id = 47, Name = "Hugo Lloris", Age = 37, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 85 },
new FifaSoccerer { Id = 48, Name = "Ivan Perišić", Age = 34, Skill = "Winger", Position = "Midfielder", Score = 84 },
new FifaSoccerer { Id = 49, Name = "Richarlison", Age = 26, Skill = "Finishing", Position = "Forward", Score = 83 },
new FifaSoccerer { Id = 50, Name = "Rohit Kumar", Age = 26, Skill = "Midfield Control", Position = "Midfielder", Score = 65 },
new FifaSoccerer { Id = 51, Name = "Mourtada Fall", Age = 35, Skill = "Defense", Position = "Defender", Score = 72 },
new FifaSoccerer { Id = 52, Name = "Ashique Kuruniyan", Age = 26, Skill = "Winger", Position = "Forward", Score = 68},
new FifaSoccerer { Id = 53, Name = "Florin Cernat", Age = 44, Skill = "Veteran Midfield", Position = "Midfielder", Score = 80 },
new FifaSoccerer { Id = 54, Name = "Renato Sanches", Age = 26, Skill = "Midfield Power", Position = "Midfielder", Score = 83 },
new FifaSoccerer { Id = 55, Name = "Sergio Reguilón", Age = 27, Skill = "Defense", Position = "Defender", Score = 82 },
new FifaSoccerer { Id = 56, Name = "Moses Simon", Age = 28, Skill = "Winger", Position = "Forward", Score = 82 },
new FifaSoccerer { Id = 57, Name = "Yannick Carrasco", Age = 30, Skill = "Winger", Position = "Forward", Score = 85},
new FifaSoccerer { Id = 58, Name = "Jude Bellingham", Age = 20, Skill = "Playmaker", Position = "Midfielder", Score = 86 },
new FifaSoccerer { Id = 59, Name = "João Félix", Age = 24, Skill = "Playmaker", Position = "Forward", Score = 84 },
new FifaSoccerer { Id = 60, Name = "Stefan Savić", Age = 33, Skill = "Defense", Position = "Defender", Score = 83 },
new FifaSoccerer { Id = 61, Name = "Reinildo Mandava", Age = 29, Skill = "Defense", Position = "Defender", Score = 81 },
new FifaSoccerer { Id = 62, Name = "Ruben Dias", Age = 26, Skill = "Defense", Position = "Defender", Score = 87},
new FifaSoccerer { Id = 63, Name = "Sergio Ramos", Age = 37, Skill = "Defense", Position = "Defender", Score = 83},
new FifaSoccerer { Id = 64, Name = "David de Gea", Age = 32, Skill = "Goalkeeping", Position = "Goalkeeper", Score = 86 },
new FifaSoccerer { Id = 65, Name = "Mohamed Salah", Age = 31, Skill = "Finishing", Position = "Forward", Score = 90 },
new FifaSoccerer { Id = 66, Name = "Virgil van Dijk", Age = 32, Skill = "Defense", Position = "Defender", Score = 89},
new FifaSoccerer { Id = 67, Name = "Declan Rice", Age = 24, Skill = "Defensive Midfield", Position = "Midfielder", Score = 87 }

            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
