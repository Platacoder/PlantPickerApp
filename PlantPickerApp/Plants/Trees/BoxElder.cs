using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Trees
{
    public class BoxElder : Plant
    {
        public override string PlantType { get; set; } = "Tree";
        public override string CommonName { get; set; } = "Boxelder";
        public override string ScientificName { get; set; } = "Acer negundo";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun" };
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy", "Clay" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry", "Moist", "Wet" };

        public override string PlantSummary { get; set; } = "Boxelder is a medium-sized, fast-growing deciduous tree. Its compound leaves are different from most other maples. " +
        " Non-showy, yellow-green flowers bloom March-April on separate male and female trees.";
        public BoxElder()
        {

        }
    }
}
