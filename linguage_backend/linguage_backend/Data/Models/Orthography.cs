using System;
using System.Collections.Generic;

namespace linguage_backend.Data.Models
{
    public partial class Orthography
    {
        public string? Name { get; set; }
        public string? System { get; set; }
        public string? CoordinateValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
