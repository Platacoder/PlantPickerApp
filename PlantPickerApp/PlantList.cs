using System;
using System.Collections.Generic;
using System.Text;
using PlantPickerApp;
using PlantPickerApp.Plants;
using PlantPickerApp.Plants.Shrubs;
using PlantPickerApp.Plants.Trees;
using PlantPickerApp.Plants.Grasses;
using PlantPickerApp.Plants.Herbacious;
using PlantPickerApp.Plants.Vines;

namespace PlantPickerApp
{
    class PlantList
    {
        public List<Plant> PlantHolder { get; set; } = new List<Plant>();

        public void PopulateList()
        {
            //Initializes the objects to run the program. This is a temporary fix and final program will pull data from database. Currently the app only has a handful
            //of objects to test base business logic.

            //Shrubs
            CanadianServiceberry canadianServiceberry = new CanadianServiceberry();
            SummerSweet summerSweet = new SummerSweet();
            //Trees
            BoxElder boxElder = new BoxElder();
            PawPaw pawPaw = new PawPaw();
            //Grasses
            LittleBlueStem littleBlueStem = new LittleBlueStem();
            Woolgrass woolgrass = new Woolgrass();
            //Herbacious
            ButterflyWeed butterflyWeed = new ButterflyWeed();
            EasternBluestar easternBluestar = new EasternBluestar();
            //Vines
            TrumpetHoneysuckle trumpetHoneysuckle = new TrumpetHoneysuckle();
            VirginiaCreeper virginiaCreeper = new VirginiaCreeper();

            PlantHolder.Add(canadianServiceberry);
            PlantHolder.Add(summerSweet);
            PlantHolder.Add(boxElder);
            PlantHolder.Add(pawPaw);
            PlantHolder.Add(littleBlueStem);
            PlantHolder.Add(woolgrass);
            PlantHolder.Add(butterflyWeed);
            PlantHolder.Add(easternBluestar);
            PlantHolder.Add(trumpetHoneysuckle);
            PlantHolder.Add(virginiaCreeper);
        }

    }
}
