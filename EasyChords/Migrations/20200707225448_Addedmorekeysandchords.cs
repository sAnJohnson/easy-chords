using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyChords.Migrations
{
    public partial class Addedmorekeysandchords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFlat",
                table: "MusicalKeys");

            migrationBuilder.DropColumn(
                name: "IsSharp",
                table: "MusicalKeys");

            migrationBuilder.UpdateData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://chordify.net/img/diagrams/piano/C_maj.png");

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "ChordId", "ChordName", "ImageUrl", "IsMajor", "IsNatural", "MusicalKeyId" },
                values: new object[] { 6, "D Minor", "https://chordify.net/img/diagrams/piano/D_min.png", false, true, 1 });

            migrationBuilder.InsertData(
                table: "MusicalKeys",
                columns: new[] { "MusicalKeyId", "IsMajor", "IsNatural", "MusicalKeyName" },
                values: new object[,]
                {
                    { 2, false, true, "C Minor" },
                    { 3, true, false, "C# Major" },
                    { 4, false, false, "C# Minor" },
                    { 5, true, true, "D Major" }
                });

            migrationBuilder.UpdateData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 2,
                columns: new[] { "ChordName", "ImageUrl", "MusicalKeyId" },
                values: new object[] { "C Minor", "https://chordify.net/img/diagrams/piano/C_min.png", 2 });

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "ChordId", "ChordName", "ImageUrl", "IsMajor", "IsNatural", "MusicalKeyId" },
                values: new object[,]
                {
                    { 3, "C#/Db Major", "https://chordify.net/img/diagrams/piano/Cs_maj.png", true, false, 3 },
                    { 4, "C#/Db Minor", "https://chordify.net/img/diagrams/piano/Cs_min.png", false, false, 4 },
                    { 5, "D Major", "https://chordify.net/img/diagrams/piano/D_maj.png", true, true, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MusicalKeys",
                keyColumn: "MusicalKeyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicalKeys",
                keyColumn: "MusicalKeyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicalKeys",
                keyColumn: "MusicalKeyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MusicalKeys",
                keyColumn: "MusicalKeyId",
                keyValue: 5);

            migrationBuilder.AddColumn<bool>(
                name: "IsFlat",
                table: "MusicalKeys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSharp",
                table: "MusicalKeys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Chords",
                keyColumn: "ChordId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://cdn.instructables.com/F01/5VA7/IQPFDKBU/F015VA7IQPFDKBU.LARGE.jpg?auto=webp&frame=1&fit=bounds");

            migrationBuilder.InsertData(
                table: "Chords",
                columns: new[] { "ChordId", "ChordName", "ImageUrl", "IsMajor", "IsNatural", "MusicalKeyId" },
                values: new object[] { 2, "D Minor", "https://www.pianochord.org/images/dm.png", false, true, 1 });
        }
    }
}
