using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.Migrations
{
    public partial class SeedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "Genre", "YearFounded" },
                values: new object[,]
                {
                    { 2, "Tupac Shakur", "Hip Hop", 1989 },
                    { 3, "Phil Ochs", "Folk", 1962 },
                    { 4, "The Coup", "Hip Hop", 1991 },
                    { 5, "Refused", "Punk", 1991 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 5);
        }
    }
}
