using linguage_backend.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace linguage_backend.Data.Contexts
{
    public partial class LinguageBackendContext : DbContext
    {
        public LinguageBackendContext()
        {
        }

        public LinguageBackendContext(DbContextOptions<LinguageBackendContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comparison> Comparisons { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<LanguageFamily> LanguageFamilies { get; set; } = null!;
        public virtual DbSet<LanguagePhoneme> LanguagePhonemes { get; set; } = null!;
        public virtual DbSet<Morphology> Morphologies { get; set; } = null!;
        public virtual DbSet<Orthography> Orthographies { get; set; } = null!;
        public virtual DbSet<Phoneme> Phonemes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=linguage-backend;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("comparisons");

                entity.Property(e => e.ContrastiveValue).HasColumnName("contrastive_value");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.NativeLanguageId).HasColumnName("native_language_id");

                entity.Property(e => e.TargetLanguageId).HasColumnName("target_language_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("languages");

                entity.Property(e => e.ContrastiveDiacritic).HasColumnName("contrastive_diacritic");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Duolingo).HasColumnName("duolingo");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Hello).HasColumnName("hello");

                entity.Property(e => e.John).HasColumnName("john");

                entity.Property(e => e.LanguageFamilyId).HasColumnName("language_family_id");

                entity.Property(e => e.Mary).HasColumnName("mary");

                entity.Property(e => e.MorphologyId).HasColumnName("morphology_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NounClasses).HasColumnName("noun_classes");

                entity.Property(e => e.OrthographyId).HasColumnName("orthography_id");

                entity.Property(e => e.Speakers).HasColumnName("speakers");

                entity.Property(e => e.SyllableStructure).HasColumnName("syllable_structure");

                entity.Property(e => e.SyllableStructure2).HasColumnName("syllable_structure_2");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.WrittenName).HasColumnName("written_name");
            });

            modelBuilder.Entity<LanguageFamily>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("language_families");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.GeneralFamily).HasColumnName("general_family");

                entity.Property(e => e.SpecificFamily).HasColumnName("specific_family");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.XCoordinate).HasColumnName("x_coordinate");

                entity.Property(e => e.YCoordinate).HasColumnName("y_coordinate");
            });

            modelBuilder.Entity<LanguagePhoneme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("language_phonemes");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.PhonemeId).HasColumnName("phoneme_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Morphology>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("morphologies");

                entity.Property(e => e.CoordinateValue).HasColumnName("coordinate_value");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Orthography>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orthographies");

                entity.Property(e => e.CoordinateValue).HasColumnName("coordinate_value");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.System).HasColumnName("system");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Phoneme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("phonemes");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Latin).HasColumnName("latin");

                entity.Property(e => e.Manner).HasColumnName("manner");

                entity.Property(e => e.Place).HasColumnName("place");

                entity.Property(e => e.SoundUrl).HasColumnName("sound_url");

                entity.Property(e => e.Symbol).HasColumnName("symbol");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
