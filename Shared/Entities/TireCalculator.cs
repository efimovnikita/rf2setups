using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class TireCalculator
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public double KPA { get; set; } = 0.0;
    }
}