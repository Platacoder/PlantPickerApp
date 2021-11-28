using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Vines
{
    class TrumpetHoneysuckle : Plant
    {
        public override string PlantType { get; set; } = "Vine";
        public override string CommonName { get; set; } = "Trumpet Honeysuckle";
        public override string ScientificName { get; set; } = "Lonicera sempervirens";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade"};
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy", "Clay"};
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry"};

        public override string PlantSummary { get; set; } = "Trumpet Honeysuckle is a twining, wildlife-friendly deciduous vine, which will attract hummingbirds, butterflies, and bees to your garden! " +
                                                            "It has red-pink-orange, trumpet-shaped flowers that bloom between May-June";
        public TrumpetHoneysuckle()
        {

        }
    }
}
