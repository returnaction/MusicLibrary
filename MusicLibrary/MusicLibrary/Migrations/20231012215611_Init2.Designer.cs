﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibrary.Data;

#nullable disable

namespace MusicLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231012215611_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "The hood",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(5864),
                            Title = "I am back"
                        },
                        new
                        {
                            Id = 2,
                            Album = "The hood",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6001),
                            Title = "Hello"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6005),
                            Title = "Sacramento"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6008),
                            Title = "Table on "
                        },
                        new
                        {
                            Id = 5,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Likes = 0,
                            ReleaseDate = new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6010),
                            Title = "No more killing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
