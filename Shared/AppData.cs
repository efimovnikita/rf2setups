using System;
using System.Collections.Generic;
using System.Linq;
using rf2setups.Shared.Entities;

namespace rf2setups.Shared
{
    public class AppData
    {
        public string API { get; set; } = "http://localhost:5001/rf2setups/us-central1/api";
        //public string API { get; set; } = "https://us-central1-rf2setups.cloudfunctions.net/api";
        public List<Car> Cars { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Setup> Setups { get; set; }

        public void DeleteSetupById(Guid id) {
            var setup = Setups.Where(s => s.Id == id).FirstOrDefault();
            if (setup != null)
                Setups.Remove(setup);
        }
    }
}