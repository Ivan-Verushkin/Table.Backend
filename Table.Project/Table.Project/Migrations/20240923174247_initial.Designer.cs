﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Table.Project.Data;

#nullable disable

namespace Table.Project.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240923174247_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Table.Project.Models.FifaSoccerer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FifaSoccerers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 31,
                            Name = "Marc-André ter Stegen",
                            Position = "Goalkeeper",
                            Score = 88,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 2,
                            Age = 24,
                            Name = "Jules Koundé",
                            Position = "Defender",
                            Score = 85,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 3,
                            Age = 24,
                            Name = "Ronald Araújo",
                            Position = "Defender",
                            Score = 86,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 4,
                            Age = 21,
                            Name = "Pedri",
                            Position = "Midfielder",
                            Score = 88,
                            Skill = "Passing"
                        },
                        new
                        {
                            Id = 5,
                            Age = 19,
                            Name = "Gavi",
                            Position = "Midfielder",
                            Score = 84,
                            Skill = "Dribbling"
                        },
                        new
                        {
                            Id = 6,
                            Age = 35,
                            Name = "Robert Lewandowski",
                            Position = "Forward",
                            Score = 91,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 7,
                            Age = 26,
                            Name = "Frenkie de Jong",
                            Position = "Midfielder",
                            Score = 87,
                            Skill = "Passing"
                        },
                        new
                        {
                            Id = 8,
                            Age = 23,
                            Name = "Ferran Torres",
                            Position = "Forward",
                            Score = 82,
                            Skill = "Dribbling"
                        },
                        new
                        {
                            Id = 9,
                            Age = 21,
                            Name = "Ansu Fati",
                            Position = "Forward",
                            Score = 81,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 10,
                            Age = 31,
                            Name = "Sergi Roberto",
                            Position = "Midfielder",
                            Score = 79,
                            Skill = "Versatile"
                        },
                        new
                        {
                            Id = 11,
                            Age = 31,
                            Name = "Thibaut Courtois",
                            Position = "Goalkeeper",
                            Score = 90,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 12,
                            Age = 26,
                            Name = "Éder Militão",
                            Position = "Defender",
                            Score = 85,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 13,
                            Age = 31,
                            Name = "David Alaba",
                            Position = "Defender",
                            Score = 85,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 14,
                            Age = 34,
                            Name = "Toni Kroos",
                            Position = "Midfielder",
                            Score = 88,
                            Skill = "Passing"
                        },
                        new
                        {
                            Id = 15,
                            Age = 38,
                            Name = "Luka Modrić",
                            Position = "Midfielder",
                            Score = 88,
                            Skill = "Vision"
                        },
                        new
                        {
                            Id = 16,
                            Age = 25,
                            Name = "Federico Valverde",
                            Position = "Midfielder",
                            Score = 87,
                            Skill = "Versatile"
                        },
                        new
                        {
                            Id = 17,
                            Age = 23,
                            Name = "Vinícius Júnior",
                            Position = "Forward",
                            Score = 90,
                            Skill = "Dribbling"
                        },
                        new
                        {
                            Id = 18,
                            Age = 23,
                            Name = "Rodrygo",
                            Position = "Forward",
                            Score = 85,
                            Skill = "Dribbling"
                        },
                        new
                        {
                            Id = 19,
                            Age = 30,
                            Name = "Antonio Rüdiger",
                            Position = "Defender",
                            Score = 84,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 20,
                            Age = 23,
                            Name = "Aurélien Tchouaméni",
                            Position = "Midfielder",
                            Score = 84,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 21,
                            Age = 27,
                            Name = "Andreas Christensen",
                            Position = "Defender",
                            Score = 83,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 22,
                            Age = 23,
                            Name = "Sergiño Dest",
                            Position = "Defender",
                            Score = 78,
                            Skill = "Dribbling"
                        },
                        new
                        {
                            Id = 23,
                            Age = 33,
                            Name = "Marcos Alonso",
                            Position = "Defender",
                            Score = 79,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 24,
                            Age = 24,
                            Name = "Ferran Jutglà",
                            Position = "Forward",
                            Score = 77,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 25,
                            Age = 25,
                            Name = "Iñaki Peña",
                            Position = "Goalkeeper",
                            Score = 75,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 26,
                            Age = 24,
                            Name = "Fran García",
                            Position = "Defender",
                            Score = 80,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 27,
                            Age = 34,
                            Name = "Joselu",
                            Position = "Forward",
                            Score = 82,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 28,
                            Age = 21,
                            Name = "Eduardo Camavinga",
                            Position = "Midfielder",
                            Score = 85,
                            Skill = "Versatile"
                        },
                        new
                        {
                            Id = 29,
                            Age = 29,
                            Name = "Ferland Mendy",
                            Position = "Defender",
                            Score = 81,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 30,
                            Age = 30,
                            Name = "Harry Kane",
                            Position = "Forward",
                            Score = 90,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 31,
                            Age = 31,
                            Name = "Son Heung-Min",
                            Position = "Forward",
                            Score = 88,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 32,
                            Age = 28,
                            Name = "Pierre-Emile Højbjerg",
                            Position = "Midfielder",
                            Score = 0,
                            Skill = "Defensive Midfield"
                        },
                        new
                        {
                            Id = 33,
                            Age = 25,
                            Name = "Cristian Romero",
                            Position = "Defender",
                            Score = 85,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 34,
                            Age = 26,
                            Name = "Rodrigo Bentancur",
                            Position = "Midfielder",
                            Score = 83,
                            Skill = "Playmaker"
                        },
                        new
                        {
                            Id = 35,
                            Age = 31,
                            Name = "Jan Oblak",
                            Position = "Goalkeeper",
                            Score = 91,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 36,
                            Age = 33,
                            Name = "Antoine Griezmann",
                            Position = "Forward",
                            Score = 88,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 37,
                            Age = 28,
                            Name = "Marcos Llorente",
                            Position = "Midfielder",
                            Score = 85,
                            Skill = "Versatile"
                        },
                        new
                        {
                            Id = 38,
                            Age = 29,
                            Name = "José María Giménez",
                            Position = "Defender",
                            Score = 85,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 39,
                            Age = 29,
                            Name = "Saúl Ñíguez",
                            Position = "Midfielder",
                            Score = 82,
                            Skill = "Midfield Control"
                        },
                        new
                        {
                            Id = 40,
                            Age = 30,
                            Name = "Sandesh Jhingan",
                            Position = "Defender",
                            Score = 74,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 41,
                            Age = 39,
                            Name = "Sunil Chhetri",
                            Position = "Forward",
                            Score = 78,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 42,
                            Age = 26,
                            Name = "Anirudh Thapa",
                            Position = "Midfielder",
                            Score = 72,
                            Skill = "Midfield Control"
                        },
                        new
                        {
                            Id = 43,
                            Age = 26,
                            Name = "Lallianzuala Chhangte",
                            Position = "Forward",
                            Score = 70,
                            Skill = "Winger"
                        },
                        new
                        {
                            Id = 44,
                            Age = 30,
                            Name = "Amrinder Singh",
                            Position = "Goalkeeper",
                            Score = 68,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 45,
                            Age = 30,
                            Name = "Memphis Depay",
                            Position = "Forward",
                            Score = 84,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 46,
                            Age = 32,
                            Name = "Koke",
                            Position = "Midfielder",
                            Score = 85,
                            Skill = "Playmaker"
                        },
                        new
                        {
                            Id = 47,
                            Age = 37,
                            Name = "Hugo Lloris",
                            Position = "Goalkeeper",
                            Score = 85,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 48,
                            Age = 34,
                            Name = "Ivan Perišić",
                            Position = "Midfielder",
                            Score = 84,
                            Skill = "Winger"
                        },
                        new
                        {
                            Id = 49,
                            Age = 26,
                            Name = "Richarlison",
                            Position = "Forward",
                            Score = 83,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 50,
                            Age = 26,
                            Name = "Rohit Kumar",
                            Position = "Midfielder",
                            Score = 65,
                            Skill = "Midfield Control"
                        },
                        new
                        {
                            Id = 51,
                            Age = 35,
                            Name = "Mourtada Fall",
                            Position = "Defender",
                            Score = 72,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 52,
                            Age = 26,
                            Name = "Ashique Kuruniyan",
                            Position = "Forward",
                            Score = 68,
                            Skill = "Winger"
                        },
                        new
                        {
                            Id = 53,
                            Age = 44,
                            Name = "Florin Cernat",
                            Position = "Midfielder",
                            Score = 80,
                            Skill = "Veteran Midfield"
                        },
                        new
                        {
                            Id = 54,
                            Age = 26,
                            Name = "Renato Sanches",
                            Position = "Midfielder",
                            Score = 83,
                            Skill = "Midfield Power"
                        },
                        new
                        {
                            Id = 55,
                            Age = 27,
                            Name = "Sergio Reguilón",
                            Position = "Defender",
                            Score = 82,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 56,
                            Age = 28,
                            Name = "Moses Simon",
                            Position = "Forward",
                            Score = 82,
                            Skill = "Winger"
                        },
                        new
                        {
                            Id = 57,
                            Age = 30,
                            Name = "Yannick Carrasco",
                            Position = "Forward",
                            Score = 85,
                            Skill = "Winger"
                        },
                        new
                        {
                            Id = 58,
                            Age = 20,
                            Name = "Jude Bellingham",
                            Position = "Midfielder",
                            Score = 86,
                            Skill = "Playmaker"
                        },
                        new
                        {
                            Id = 59,
                            Age = 24,
                            Name = "João Félix",
                            Position = "Forward",
                            Score = 84,
                            Skill = "Playmaker"
                        },
                        new
                        {
                            Id = 60,
                            Age = 33,
                            Name = "Stefan Savić",
                            Position = "Defender",
                            Score = 83,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 61,
                            Age = 29,
                            Name = "Reinildo Mandava",
                            Position = "Defender",
                            Score = 81,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 62,
                            Age = 26,
                            Name = "Ruben Dias",
                            Position = "Defender",
                            Score = 87,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 63,
                            Age = 37,
                            Name = "Sergio Ramos",
                            Position = "Defender",
                            Score = 83,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 64,
                            Age = 32,
                            Name = "David de Gea",
                            Position = "Goalkeeper",
                            Score = 86,
                            Skill = "Goalkeeping"
                        },
                        new
                        {
                            Id = 65,
                            Age = 31,
                            Name = "Mohamed Salah",
                            Position = "Forward",
                            Score = 90,
                            Skill = "Finishing"
                        },
                        new
                        {
                            Id = 66,
                            Age = 32,
                            Name = "Virgil van Dijk",
                            Position = "Defender",
                            Score = 89,
                            Skill = "Defense"
                        },
                        new
                        {
                            Id = 67,
                            Age = 24,
                            Name = "Declan Rice",
                            Position = "Midfielder",
                            Score = 87,
                            Skill = "Defensive Midfield"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
