using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Grasses
{
    public class Woolgrass : Plant
    {
        public override string PlantType { get; set; } = "Grass";
        public override string CommonName { get; set; } = "Woolgrass";
        public override string ScientificName { get; set; } = "Scirpus cyperinus";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun" };
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy", "Clay" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Moist, Wet" };

        public override string PlantSummary { get; set; } = "Woolgrass needs wet, partly shady conditions. This wildlife-friendly plant has seeds and roots that are eaten by waterfowl. " +
            "It also provides waterfowl with cover and nesting sites. It is a host plant for butterfly and moth larvae.";

        public Woolgrass()
        {

        }
    }
}
