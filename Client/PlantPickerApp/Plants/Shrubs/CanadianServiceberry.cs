using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Shrubs
{
    public class CanadianServiceberry : Plant
    {
        public override string PlantType { get; set; } = "Shrub";
        public override string CommonName { get; set; } = "Canadian Serviceberry";
        public override string ScientificName { get; set; } = "Amelanchier canadensis";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade" };
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry", "Moist" };

        public override string PlantSummary { get; set; } = "Canadian Serviceberry is a wildlife-friendly, large deciduous shrub." +
        "Drooping clusters of slightly fragrant, white flowers bloom before leaves appear, March-April.";

        public CanadianServiceberry()
        {

        }

    }
}
