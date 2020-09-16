using System;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Setup
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; } = "Setup";
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public Guid Car { get; set; }
        [Required]
        public Guid Track { get; set; }
        public TiresSetups Tyres { get; set; } = new TiresSetups();
        public BrakesSetups Brakes { get; set; } = new BrakesSetups();
        public SuspensionSetups Suspension { get; set; } = new SuspensionSetups();
        public AerodynamicsSetups Aerodynamics { get; set; } = new AerodynamicsSetups();
        public ElectronicsSetups Electronics { get; set; } = new ElectronicsSetups();
        public DriveTrainSetups DriveTrain { get; set; } = new DriveTrainSetups();
    }

    public class TiresSetups
    {
        [Required]
        [Range(-10.0, 10.0, ErrorMessage = "Please enter a number between -10 and 10")]
        public double FrontLeftCamber { get; set; } = -3.8;
        [Required]
        [Range(-10.0, 10.0, ErrorMessage = "Please enter a number between -10 and 10")]
        public double FrontRightCamber { get; set; } = -3.8;
        [Required]
        [Range(-10.0, 10.0, ErrorMessage = "Please enter a number between -10 and 10")]
        public double RearLeftCamber { get; set; } = -3.8;
        [Required]
        [Range(-10.0, 10.0, ErrorMessage = "Please enter a number between -10 and 10")]
        public double RearRightCamber { get; set; } = -3.8;
        [Required]
        public string FrontCompound { get; set; } = "Soft";
        [Required]
        public string RearCompound { get; set; } = "Soft";
    }

    public class BrakesSetups
    {
        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Please enter a number between 0 and 100")]
        public double FrontBrakeBias { get; set; } = 54.0;
        [Required]
        [Range(0.0, 100.0, ErrorMessage = "Please enter a number between 0 and 100")]
        public double RearBrakeBias { get; set; } = 46.0;
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public int MaxPedalForce { get; set; } = 80;
    }

    public class SuspensionSetups
    {
        [Required]
        [Range(0, 300, ErrorMessage = "Please enter a number between 0 and 300")]
        public int FrontSpringRateLeft { get; set; } = 160;
        [Required]
        [Range(0, 300, ErrorMessage = "Please enter a number between 0 and 300")]
        public int FrontSpringRateRight { get; set; } = 160;
        [Required]
        [Range(0, 300, ErrorMessage = "Please enter a number between 0 and 300")]
        public int RearSpringRateLeft { get; set; } = 160;
        [Required]
        [Range(0, 300, ErrorMessage = "Please enter a number between 0 and 300")]
        public int RearSpringRateRight { get; set; } = 160;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontSlowBumpLeft { get; set; } = 8;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontSlowBumpRight { get; set; } = 8;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearSlowBumpLeft { get; set; } = 8;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearSlowBumpRight { get; set; } = 8;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontSlowReboundLeft { get; set; } = 7;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontSlowReboundRight { get; set; } = 7;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearSlowReboundLeft { get; set; } = 7;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearSlowReboundRight { get; set; } = 7;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontFastBumpLeft { get; set; } = 5;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontFastBumpRight { get; set; } = 5;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearFastBumpLeft { get; set; } = 5;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearFastBumpRight { get; set; } = 5;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontFastReboundLeft { get; set; } = 4;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontFastReboundRight { get; set; } = 4;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearFastReboundLeft { get; set; } = 4;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearFastReboundRight { get; set; } = 4;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double FrontPackersLeft { get; set; } = 2.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double FrontPackersRight { get; set; } = 2.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double RearPackersLeft { get; set; } = 2.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double RearPackersRight { get; set; } = 2.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double FrontRideHeightLeft { get; set; } = 5.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double FrontRideHeightRight { get; set; } = 5.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double RearRideHeightLeft { get; set; } = 5.8;
        [Required]
        [Range(0.0, 10.0, ErrorMessage = "Please enter a number between 0 and 10")]
        public double RearRideHeightRight { get; set; } = 5.8;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int FrontAntisway { get; set; } = 2;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int RearAntisway { get; set; } = 2;
        [Required]
        [Range(-2.0, 2.0, ErrorMessage = "Please enter a number between -2 and 2")]
        public double FrontToeIn { get; set; } = -0.12;
        [Required]
        [Range(-2.0, 2.0, ErrorMessage = "Please enter a number between -2 and 2")]
        public double RearToeIn { get; set; } = -0.12;
    }

    public class AerodynamicsSetups
    {
        [Required]
        [Range(0, 12, ErrorMessage = "Please enter a number between 0 and 12")]
        public int FrontWing { get; set; } = 4;
        [Required]
        [Range(0, 12, ErrorMessage = "Please enter a number between 0 and 12")]
        public int RearWing { get; set; } = 4;

    }

    public class ElectronicsSetups
    {
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int TractionControl { get; set; } = 5;
        [Required]
        [Range(0, 10, ErrorMessage = "Please enter a number between 0 and 10")]
        public int ABS { get; set; } = 2;
    }

    public class DriveTrainSetups
    {
        [Required]
        [Range(0, 200, ErrorMessage = "Please enter a number between 0 and 200")]
        public int Preload { get; set; } = 140;
    }
}