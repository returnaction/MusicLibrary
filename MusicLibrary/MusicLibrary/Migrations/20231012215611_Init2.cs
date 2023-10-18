using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLibrary.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Song");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Album",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Song",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Album", "Artist", "Genre", "Likes", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The hood", "Eminem", "Rap", 0, new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(5864), "I am back" },
                    { 2, "The hood", "Eminem", "Rap", 0, new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6001), "Hello" },
                    { 3, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6005), "Sacramento" },
                    { 4, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6008), "Table on " },
                    { 5, "Shady", "Eminem", "Rap", 0, new DateTime(2023, 10, 12, 17, 56, 11, 744, DateTimeKind.Local).AddTicks(6010), "No more killing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Song");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Song",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Album",
                table: "Song",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Song",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
