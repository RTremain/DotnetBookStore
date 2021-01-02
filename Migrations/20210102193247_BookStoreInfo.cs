using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetBookStore.Migrations
{
    public partial class BookStoreInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AvailableInStore",
                table: "Book",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "AverageRating",
                table: "Book",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "InStorePrice",
                table: "Book",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OnlinePrice",
                table: "Book",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Book",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableInStore",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "InStorePrice",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "OnlinePrice",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Book");
        }
    }
}
