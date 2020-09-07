using System;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Setup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Guid Car { get; set; }
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
}