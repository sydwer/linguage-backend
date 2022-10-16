using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class Comparison
    {
        public int? NativeLanguageId { get; set; }
        public int? TargetLanguageId { get; set; }
        public double? ContrastiveValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
