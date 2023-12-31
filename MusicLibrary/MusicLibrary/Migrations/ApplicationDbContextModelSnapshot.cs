﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibrary.Data;

#nullable disable

namespace MusicLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicLibrary.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "The hood",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8002),
                            Title = "I am back"
                        },
                        new
                        {
                            Id = 2,
                            Album = "The hood",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8055),
                            Title = "Hello"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8057),
                            Title = "Sacramento"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8060),
                            Title = "Table on "
                        },
                        new
                        {
                            Id = 5,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8062),
                            Title = "No more killing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
