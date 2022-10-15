using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class Language
    {
        public string? Name { get; set; }
        public string? WrittenName { get; set; }
        public string? Hello { get; set; }
        public string? Speakers { get; set; }
        public string? Flag { get; set; }
        public string? Duolingo { get; set; }
        public string? ContrastiveDiacritic { get; set; }
        public string? SyllableStructure { get; set; }
        public string? SyllableStructure2 { get; set; }
        public string? Mary { get; set; }
        public string? John { get; set; }
        public int? MorphologyId { get; set; }
        public int? LanguageFamilyId { get; set; }
        public int? OrthographyId { get; set; }
        public int? NounClasses { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
