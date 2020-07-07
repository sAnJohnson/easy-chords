using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyChords.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicalKeys",
                columns: new[] { "MusicalKeyId", "IsFlat", "IsMajor", "IsNatural", "IsSharp", "MusicalKeyName" },
                values: new object[] { 1, false, true, true, false, "C Major" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicalKeys",
                keyColumn: "MusicalKeyId",
                keyValue: 1);
        }
    }
}
