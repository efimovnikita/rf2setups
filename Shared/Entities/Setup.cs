using System;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Setup
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public Guid Car { get; set; }
        [Required]
        public Guid Track { get; set; }
    }
}