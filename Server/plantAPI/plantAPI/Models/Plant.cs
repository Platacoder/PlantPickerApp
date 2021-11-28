using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plantAPI.Models
{
    public class Plant
    {
        public int PlantID { get; set; }
        public string PlantType { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string LightRequirements { get; set; }
        public string SoilType { get; set; }
        public string SoilMoisture { get; set; }
        public string Summary { get; set; }
    }
}
