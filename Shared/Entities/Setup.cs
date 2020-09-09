using System;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Setup
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public Guid Car { get; set; }
        [Required]
        public Guid Track { get; set; }
        public TiresSetups Tyres { get; set; }
        public BrakesSetups Brakes { get; set; }
        public ChassisSetups Chassis { get; set; }
        public SuspensionSetups Suspension { get; set; }
        public AerodynamicsSetups Aerodynamics { get; set; }
        public ElectronicsSetups Electronics { get; set; }
    }

    public class TiresSetups
    {
        public enum Compound
        {
            Soft, 
            Medium,
            Hard
        }

        public double FrontLeftCamber { get; set; }
        public double FrontRightCamber { get; set; }
        public double RearLeftCamber { get; set; }
        public double RearRightCamber { get; set; }
        public Compound FrontCompound { get; set; }
        public Compound RearCompound { get; set; }
    }

    public class BrakesSetups
    {
        public double FrontBrakeBias { get; set; }
        public double RearBrakeBias { get; set; }
        public int MaxPedalForce { get; set; }
    }

    public class ChassisSetups
    {
        
    }

    public class SuspensionSetups
    {
        
    }

    public class AerodynamicsSetups
    {
        
    }

    public class ElectronicsSetups
    {
        
    }

    public class DriveTrainSetups
    {
        public int Preload { get; set; }
    }
}