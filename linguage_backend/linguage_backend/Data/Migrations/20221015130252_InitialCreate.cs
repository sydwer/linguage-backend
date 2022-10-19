using System;
using Microsoft.EntityFrameworkCore.Metadata;
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
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    native_language_id = table.Column<int>(type: "int", nullable: true),
                    target_language_id = table.Column<int>(type: "int", nullable: true),
                    contrastive_value = table.Column<double>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("comparisons_primarykey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language_families",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    specific_family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    general_family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    x_coordinate = table.Column<double>(type: "float", nullable: true),
                    y_coordinate = table.Column<double>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("language_families_primarykey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    id = table.Column<int>(type:"int",nullable:false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "Nvarchar(max)", nullable: true),
                    written_name = table.Column<string>(type: "Nvarchar(max)", nullable: true),
                    hello = table.Column<string>(type: "Nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("language_primarykey", x => x.id); 
                });

            migrationBuilder.CreateTable(
                name: "morphologies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coordinate_value = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("morphologies_primarykey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orthographies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    system = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coordinate_value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("orthographies_primarykey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "phonemes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: true, collation: "Latin1_General_BIN"),
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
                    table.PrimaryKey("phoneme_primarykey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "language_phonemes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    phoneme_id = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("language_phonemes_primarykey", x => x.id);
                    table.ForeignKey("FK_language_languagephonemes", x => x.language_id, "languages", "id");
                    table.ForeignKey("FK_phoneme_languagephonemes", x => x.phoneme_id, "phonemes", "id");
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
