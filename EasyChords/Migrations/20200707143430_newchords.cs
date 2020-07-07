using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyChords.Migrations
{
    public partial class newchords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFlat",
                table: "Chords");

            migrationBuilder.DropColumn(
                name: "IsMinor",
                table: "Chords");

            migrationBuilder.DropColumn(
                name: "IsSharp",
                table: "Chords");

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "ChordId", "ChordName", "ImageUrl", "IsMajor", "IsNatural", "MusicalKeyId" },
                values: new object[] { 1, "C Major", "https://cdn.instructables.com/F01/5VA7/IQPFDKBU/F015VA7IQPFDKBU.LARGE.jpg?auto=webp&frame=1&fit=bounds", true, true, 1 });

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "ChordId", "ChordName", "ImageUrl", "IsMajor", "IsNatural", "MusicalKeyId" },
                values: new object[] { 2, "D Minor", "https://www.pianochord.org/images/dm.png", false, true, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 2);

            migrationBuilder.AddColumn<bool>(
                name: "IsFlat",
                table: "Chords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMinor",
                table: "Chords",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSharp",
                table: "Chords",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
