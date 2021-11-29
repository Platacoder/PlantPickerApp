using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plantAPI.Models
{
    public class LandRequirements
    {
        public string PlantType { get; set; }
        public string LightRequirements { get; set; }
        public string SoilType { get; set; }
        public string SoilMoisture { get; set; }
    }
}
