using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class LanguageFamily
    {
        public string? SpecificFamily { get; set; }
        public string? GeneralFamily { get; set; }
        public double? XCoordinate { get; set; }
        public double? YCoordinate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
