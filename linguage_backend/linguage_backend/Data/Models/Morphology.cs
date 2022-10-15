using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class Morphology
    {
        public string? Name { get; set; }
        public int? CoordinateValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Description { get; set; }
    }
}
