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
                new FifaSoccerer { Id = 29, Name = "Ferland Mendy", Age = 29, Skill = "Defense", Position = "Defender", Score = 81 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
