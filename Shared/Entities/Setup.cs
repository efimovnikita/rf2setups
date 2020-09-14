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
        public TiresSetups Tyres { get; set; }
        public BrakesSetups Brakes { get; set; }
        public SuspensionSetups Suspension { get; set; }
        public AerodynamicsSetups Aerodynamics { get; set; }
        public ElectronicsSetups Electronics { get; set; }
    }

    public class TiresSetups
    {
        public double FrontLeftCamber { get; set; } = -3.8;
        public double FrontRightCamber { get; set; } = -3.8;
        public double RearLeftCamber { get; set; } = -3.8;
        public double RearRightCamber { get; set; } = -3.8;
        public string FrontCompound { get; set; } = "Soft";
        public string RearCompound { get; set; } = "Soft";
    }

    public class BrakesSetups
    {
        public double FrontBrakeBias { get; set; } = 54.0;
        public double RearBrakeBias { get; set; } = 46.0;
        public int MaxPedalForce { get; set; } = 80;
    }

    public class SuspensionSetups
    {
        public int FrontSpringRateLeft { get; set; } = 160;
        public int FrontSpringRateRight { get; set; } = 160;
        public int RearSpringRateLeft { get; set; } = 160;
        public int RearSpringRateRight { get; set; } = 160;
        public int FrontSlowBumpLeft { get; set; } = 8;
        public int FrontSlowBumpRight { get; set; } = 8;
        public int RearSlowBumpLeft { get; set; } = 8;
        public int RearSlowBumpRight { get; set; } = 8;
        public int FrontSlowReboundLeft { get; set; } = 7;
        public int FrontSlowReboundRight { get; set; } = 7;
        public int RearSlowReboundLeft { get; set; } = 7;
        public int RearSlowReboundRight { get; set; } = 7;
        public int FrontFastBumpLeft { get; set; } = 5;
        public int FrontFastBumpRight { get; set; } = 5;
        public int RearFastBumpLeft { get; set; } = 5;
        public int RearFastBumpRight { get; set; } = 5;
        public int FrontFastReboundLeft { get; set; } = 4;
        public int FrontFastReboundRight { get; set; } = 4;
        public int RearFastReboundLeft { get; set; } = 4;
        public int RearFastReboundRight { get; set; } = 4;
        public double FrontPackersLeft { get; set; } = 2.8;
        public double FrontPackersRight { get; set; } = 2.8;
        public double RearPackersLeft { get; set; } = 2.8;
        public double RearPackersRight { get; set; } = 2.8;
        public double FrontRideHeightLeft { get; set; } = 5.8;
        public double FrontRideHeightRight { get; set; } = 5.8;
        public double RearRideHeightLeft { get; set; } = 5.8;
        public double RearRideHeightRight { get; set; } = 5.8;
        public int FrontAntisway { get; set; } = 2;
        public int RearAntisway { get; set; } = 2;
        public double FrontToeIn { get; set; } = -0.12;
        public double RearToeIn { get; set; } = -0.12;
    }

    public class AerodynamicsSetups
    {
        public int FrontWing { get; set; } = 4;
        public int RearWing { get; set; } = 4;

    }

    public class ElectronicsSetups
    {
        public int TractionControl { get; set; } = 5;
        public int ABS { get; set; } = 2;
    }

    public class DriveTrainSetups
    {
        public int Preload { get; set; } = 140;
    }
}