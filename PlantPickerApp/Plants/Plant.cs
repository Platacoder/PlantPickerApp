using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants
{
    public abstract class Plant
    {
        public abstract string PlantType { get; set; }
        public abstract string CommonName { get; set; }
        public abstract string ScientificName { get; set; }

        public abstract List<string> LightRequirements { get; set; }
        public abstract List<string> SoilType { get; set; }
        public abstract List<string> SoilMoisture { get; set; } 

        public abstract string PlantSummary { get; set; }

        public  Plant()
        {
            
        }
    }
}
