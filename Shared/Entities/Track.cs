using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Track
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Guid> Setups { get; set; } = new List<Guid>();
        public DateTime Date { get; set; }
        [Required]
        public string TrackMapImageURL { get; set; }
    }
}