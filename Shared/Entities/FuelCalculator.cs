using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class FuelCalculator
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int RaceLength { get; set; } = 0;
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int LapTimeMin { get; set; } = 1;
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int LapTimeSec { get; set; } = 0;
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public double FuelPerLap { get; set; } = 0.0;

    }
}