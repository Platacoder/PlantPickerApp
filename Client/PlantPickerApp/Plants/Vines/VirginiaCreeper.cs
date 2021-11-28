using System;
using System.Collections.Generic;
using System.Text;

namespace PlantPickerApp.Plants.Vines
{
    class VirginiaCreeper : Plant
    {
        public override string PlantType { get; set; } = "Vine";
        public override string CommonName { get; set; } = "Virginia Creeper";
        public override string ScientificName { get; set; } = "Parthenocissus quinquefolia";
        public override List<string> LightRequirements { get; set; } = new List<string> { "Full Sun", "Partial Shade", "Shade" };
        public override List<string> SoilType { get; set; } = new List<string> { "Loam", "Organic", "Sandy", "Clay" };
        public override List<string> SoilMoisture { get; set; } = new List<string> { "Dry" };

        public override string PlantSummary { get; set; } = "Virginia Creeper is a wildlife-friendly, woody, deciduous vine. " +
                                                            "Insignificant, greenish-white flowers bloom May-August, leading to attractive, dark blue to black berries, valued as food by birds and wildlife. " +
                                                            "Green, compound-palmate leaves turn deep red-crimson in the fall.";
        public VirginiaCreeper()
        {

        }
    }
}
