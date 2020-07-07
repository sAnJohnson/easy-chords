using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyChords.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicalKeys",
                columns: table => new
                {
                    MusicalKeyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicalKeyName = table.Column<string>(nullable: true),
                    IsMajor = table.Column<bool>(nullable: false),
                    IsNatural = table.Column<bool>(nullable: false),
                    IsSharp = table.Column<bool>(nullable: false),
                    IsFlat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicalKeys", x => x.MusicalKeyId);
                });

            migrationBuilder.CreateTable(
                name: "Chords",
                columns: table => new
                {
                    ChordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChordName = table.Column<string>(nullable: true),
                    IsMajor = table.Column<bool>(nullable: false),
                    IsMinor = table.Column<bool>(nullable: false),
                    IsNatural = table.Column<bool>(nullable: false),
                    IsSharp = table.Column<bool>(nullable: false),
                    IsFlat = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    MusicalKeyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chords", x => x.ChordId);
                    table.ForeignKey(
                        name: "FK_Chords_MusicalKeys_MusicalKeyId",
                        column: x => x.MusicalKeyId,
                        principalTable: "MusicalKeys",
                        principalColumn: "MusicalKeyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chords_MusicalKeyId",
                table: "Chords",
                column: "MusicalKeyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chords");

            migrationBuilder.DropTable(
                name: "MusicalKeys");
        }
    }
}
