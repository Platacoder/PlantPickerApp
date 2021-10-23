using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Trees
{
    class PawPaw: Plant
    {
        public override string PlantType { get; set; } = "Tree";
        public override string CommonName { get; set; } = "Pawpaw";
        public override string ScientificName { get; set; } = "Asimina triloba";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade"};
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry", "Moist", "Wet" };

        public override string PlantSummary { get; set; } = "Pawpaw is a small understory tree or large shrub, which grows to form thickets. " +
                                                            "It has large, drooping, tropical-like leaves. " +
                                                            "Its cup-shaped, purple flowers bloom April-May, followed by large, green, edible fruits that taste like a mixture of bananas and pineapples.";

        public PawPaw()
        {

        }
    }
}
