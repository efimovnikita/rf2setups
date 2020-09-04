using System;
using System.Collections.Generic;
using System.Linq;
using rf2setups.Shared.Entities;

namespace rf2setups.Shared
{
    public class AppData
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Track> Tracks { get; set; } = new List<Track>();
        public List<Setup> Setups { get; set; } = new List<Setup>();

        public void DeleteSetupById(Guid id) {
            var setup = Setups.Where(s => s.Id == id).FirstOrDefault();
            if (setup != null)
                Setups.Remove(setup);
        }
    }
}