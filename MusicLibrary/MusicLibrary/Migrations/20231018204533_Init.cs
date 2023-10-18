using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Album = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Likes", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The hood", "Eminem", "Rap", 0, new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8002), "I am back" },
                    { 2, "The hood", "Eminem", "Rap", 0, new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8055), "Hello" },
                    { 3, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8057), "Sacramento" },
                    { 4, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8060), "Table on " },
                    { 5, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 18, 16, 45, 33, 742, DateTimeKind.Local).AddTicks(8062), "No more killing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
