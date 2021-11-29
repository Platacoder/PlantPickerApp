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
            MainMenu mainMenu = new MainMenu();
            PlantList plantList = new PlantList();
            plantList.PopulateList();

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                mainMenu.AppGreeting();
                mainMenu.AppUserInputs();
                mainMenu.inputSplitter();
                mainMenu.DisplayReturnedPlants(mainMenu.PlantSearch());

                
                bool isRightInput = false;
                while (!isRightInput)
                {
                    Console.WriteLine("Would you like to start another query?(Y/N)");
                    string queryRestartInput = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (queryRestartInput == "y" || queryRestartInput == "n")
                    {
                        isRightInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input the right value (Y/N).");
                    }
                    if (queryRestartInput == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
