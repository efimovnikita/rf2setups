using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rf2setups.Shared.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<Guid> Setups { get; set; } = new List<Guid>();
        public DateTime Date { get; set; }
        public string CarBrandImageURL { get; set; }
        public string Class { get; set; }
    }
}