﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using linguage_backend.Data.Contexts;

#nullable disable

namespace linguage_backend.Migrations
{
    [DbContext(typeof(LinguageBackendContext))]
    [Migration("20221015130252_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("linguage_backend.Data.Models.Comparison", b =>
                {
                    b.Property<double?>("ContrastiveValue")
                        .HasColumnType("float")
                        .HasColumnName("contrastive_value");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int?>("NativeLanguageId")
                        .HasColumnType("int")
                        .HasColumnName("native_language_id");

                    b.Property<int?>("TargetLanguageId")
                        .HasColumnType("int")
                        .HasColumnName("target_language_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.ToTable("comparisons", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.Language", b =>
                {
                    b.Property<string>("ContrastiveDiacritic")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("contrastive_diacritic");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Duolingo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("duolingo");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("flag");

                    b.Property<string>("Hello")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hello");

                    b.Property<string>("John")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("john");

                    b.Property<int?>("LanguageFamilyId")
                        .HasColumnType("int")
                        .HasColumnName("language_family_id");

                    b.Property<string>("Mary")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("mary");

                    b.Property<int?>("MorphologyId")
                        .HasColumnType("int")
                        .HasColumnName("morphology_id");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("NounClasses")
                        .HasColumnType("int")
                        .HasColumnName("noun_classes");

                    b.Property<int?>("OrthographyId")
                        .HasColumnType("int")
                        .HasColumnName("orthography_id");

                    b.Property<string>("Speakers")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("speakers");

                    b.Property<string>("SyllableStructure")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("syllable_structure");

                    b.Property<string>("SyllableStructure2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("syllable_structure_2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<string>("WrittenName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("written_name");

                    b.ToTable("languages", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.LanguageFamily", b =>
                {
                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("GeneralFamily")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("general_family");

                    b.Property<string>("SpecificFamily")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("specific_family");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<double?>("XCoordinate")
                        .HasColumnType("float")
                        .HasColumnName("x_coordinate");

                    b.Property<double?>("YCoordinate")
                        .HasColumnType("float")
                        .HasColumnName("y_coordinate");

                    b.ToTable("language_families", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.LanguagePhoneme", b =>
                {
                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<int?>("PhonemeId")
                        .HasColumnType("int")
                        .HasColumnName("phoneme_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.ToTable("language_phonemes", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.Morphology", b =>
                {
                    b.Property<int?>("CoordinateValue")
                        .HasColumnType("int")
                        .HasColumnName("coordinate_value");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.ToTable("morphologies", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.Orthography", b =>
                {
                    b.Property<string>("CoordinateValue")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("coordinate_value");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("System")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("system");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.ToTable("orthographies", (string)null);
                });

            modelBuilder.Entity("linguage_backend.Data.Models.Phoneme", b =>
                {
                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("category");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Latin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("latin");

                    b.Property<string>("Manner")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("manner");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("place");

                    b.Property<string>("SoundUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sound_url");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("symbol");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.ToTable("phonemes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
