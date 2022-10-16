using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class LanguagePhoneme
    {
        public int? LanguageId { get; set; }
        public int? PhonemeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
