using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Grasses
{
    public class LittleBlueStem : Plant
    {
        public override string PlantType { get; set; } = "Grass";
        public override string CommonName { get; set; } = "Little Bluestem";
        public override string ScientificName { get; set; } = "Schizachyrium scoparium";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun" };
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy", "Clay" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry" };

        public override string PlantSummary { get; set; } = "Little Bluestem is an ornamental grass with small, delicate, purplish-blue-bronze flowers, which appear in August. " +
                                                            "Leaf blades are blue at the base, turning green at the tip. " +
                                                            "Dried seed heads are silvery-white and offer winter interest.";

        public LittleBlueStem()
        {

        }
    }
}
