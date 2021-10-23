using System;
using System.Collections.Generic;
using PlantPickerApp.Plants;
using PlantPickerApp.Plants.Shrubs;
using PlantPickerApp.Plants.Trees;
using PlantPickerApp.Plants.Grasses;
using PlantPickerApp.Plants.Herbacious;

namespace PlantPickerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            PlantList plantList = new PlantList();
            plantList.PopulateList();

            controller.AppGreeting();
            controller.AppUserInputs();
            controller.inputSplitter();
            controller.DisplayReturnedPlants(controller.PlantSearch());

            Console.ReadLine();

        }
    }
}
