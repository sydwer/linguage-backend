using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace linguage_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comparisons",
                columns: table => new
                {
                    native_language_id = table.Column<int>(type: "int", nullable: true),
                    target_language_id = table.Column<int>(type: "int", nullable: true),
                    contrastive_value = table.Column<double>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "language_families",
                columns: table => new
                {
                    specific_family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    general_family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    x_coordinate = table.Column<double>(type: "float", nullable: true),
                    y_coordinate = table.Column<double>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "language_phonemes",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "int", nullable: true),
                    phoneme_id = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    written_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hello = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    speakers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duolingo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contrastive_diacritic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    syllable_structure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    syllable_structure_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    john = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    morphology_id = table.Column<int>(type: "int", nullable: true),
                    language_family_id = table.Column<int>(type: "int", nullable: true),
                    orthography_id = table.Column<int>(type: "int", nullable: true),
                    noun_classes = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "morphologies",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coordinate_value = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "orthographies",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    system = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coordinate_value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "phonemes",
                columns: table => new
                {
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    sound_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comparisons");

            migrationBuilder.DropTable(
                name: "language_families");

            migrationBuilder.DropTable(
                name: "language_phonemes");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "morphologies");

            migrationBuilder.DropTable(
                name: "orthographies");

            migrationBuilder.DropTable(
                name: "phonemes");
        }
    }
}
