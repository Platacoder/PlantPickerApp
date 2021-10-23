using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Herbacious
{
    public class ButterflyWeed : Plant
    {
        public override string PlantType { get; set; } = "Herbacious";
        public override string CommonName { get; set; } = "Butterfly Weed";
        public override string ScientificName { get; set; } = "Asclepias tuberosa";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun"};
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry" };

        public override string PlantSummary { get; set; } = "Butterfly Weed is a long-blooming, drought-tolerant, wildlife-friendly perennial. " +
                                                            "Its showy, bright orange flowers bloom in flat-topped clusters, June-August. " +
                                                            "The nectar is attractive to bees, butterflies, and hummingbirds; it has special value for native bees.";

        public ButterflyWeed()
        {

        }
    }
}
