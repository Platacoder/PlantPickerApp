using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Herbacious
{
    public class EasternBluestar : Plant
    {
        public override string PlantType { get; set; } = "Herbacious";
        public override string CommonName { get; set; } = "Eastern Bluestar";
        public override string ScientificName { get; set; } = "Amsonia tabernaemontana";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade"};
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry", "Moist" };

        public override string PlantSummary { get; set; } = "Eastern Bluestar is an easy-to-grow, clump-forming perennial. " +
        "Clusters of light blue, star-shaped flowers bloom at the top of stems in late spring to early summer.";
        public EasternBluestar()
        {

        }
    }
}
