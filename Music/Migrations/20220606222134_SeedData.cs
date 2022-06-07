using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "Genre", "YearFounded" },
                values: new object[] { 1, "NOFX", "Punk", 1990 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);
        }
    }
}
