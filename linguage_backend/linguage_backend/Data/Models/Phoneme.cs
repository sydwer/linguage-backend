using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace linguage_backend.Data.Models
{
    public partial class Phoneme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string? Symbol { get; set; }
        public string? Place { get; set; }
        public string? Manner { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SoundUrl { get; set; }
        public string? Latin { get; set; }
    }
}
