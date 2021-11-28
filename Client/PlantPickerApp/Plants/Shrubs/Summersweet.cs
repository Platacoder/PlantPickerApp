using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Shrubs
{
    public class SummerSweet : Plant
    {
        public override string PlantType { get; set; } = "Shrub";
        public override string CommonName { get; set; } = "Summersweet";
        public override string ScientificName { get; set; } = "Clethra alnifolia";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade", "Shade"};
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry", "Moist" };

        public override string PlantSummary { get; set; } = "Summersweet is a multi-branched deciduous shrub with dark green, aromatic leaves." +
                                                            "It is one of the few summer-flowering shrubs that will bloom in shade. " +
                                                            "The sweetly fragrant, white flowers bloom in upright clusters on the tips of stems, July-August.";
        public SummerSweet() 
        {
            
        }
    }
}
