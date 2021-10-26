using System;
using System.Collections.Generic;
using System.Text;
using PlantPickerApp.Plants;


namespace PlantPickerApp
{

    //Runs the algorithms that organize the plant objects into list, query's them based of user input, and displays it back to the console.
    public class Controller
    {
        public string PlantTypeInput;
        public string LightRequirementInput;
        public string SoilTypeInput;
        public string SoilMoistureInput;
        public string[] LightRequirementInputs;
        public string[] SoilTypeInputs;
        public string[] SoilMoistureInputs;
        
        public void AppGreeting()
        {
            Console.WriteLine("Welcome to the Plant Picker App!");
            Console.WriteLine("Have you wanted to have a more environmentally friendly yard but didnt know how? ");
            Console.WriteLine("Well were here to help!");
            Console.WriteLine("Select the conditions your lawn or yard have and we will recommend some native plants that will feel right at home.");
            Console.WriteLine("");
        }
        public void AppUserInputs()
        {
            Console.WriteLine("Please type in the relevant inputs below. You may select more than one answer \nfor light and soil requirements (seperated by | ).");
            Console.WriteLine();
            Console.WriteLine("For a list of all plants, type in \"All Plants\".");
            Console.WriteLine("Plant Type (Shrub|Herbacious|Tree|Grass|Vine):");
            
            PlantTypeInput = Console.ReadLine();

            if (PlantTypeInput == "All Plants")
            {
                PlantList plantList = new PlantList();
                plantList.PopulateList();
                DisplayReturnedPlants(plantList.PlantHolder);
            }
            else
            {
                Console.Write("Light Requirements (Full Sun|Partial Shade|Shade):");
                LightRequirementInput = Console.ReadLine();

                Console.Write("Soil Type (Clay|Loam|Sandy|Organic):");
                SoilTypeInput = Console.ReadLine();

                Console.Write("Soil Moisture (Dry|Moist|Wet):");
                SoilMoistureInput = Console.ReadLine();
            }
        }
        public void  inputSplitter()
        {
            if (LightRequirementInput != null && SoilTypeInput != null && SoilMoistureInput != null)
            {
                LightRequirementInputs = LightRequirementInput.Split("|");
                SoilTypeInputs = SoilTypeInput.Split("|");
                SoilMoistureInputs = SoilMoistureInput.Split("|");
            }
        }
        public bool HasRequiredInputs(Plant plant, string searchType)
        {
            bool result = false;
            if (searchType == "light")
            {
                for (int i = 0; i < plant.LightRequirements.Count; i++)
                {
                    string conditionToCompare = plant.LightRequirements[i];

                    for (int j = 0; j < LightRequirementInputs.Length; j++)
                    {
                        if (conditionToCompare == LightRequirementInputs[j])
                        {
                            result = true;
                        }
                    }
                }
            }
            else if (searchType == "soilType")
            {
                for (int i = 0; i < plant.SoilType.Count; i++)
                {
                    string conditionToCompare = plant.SoilType[i];

                    for (int j = 0; j < SoilTypeInputs.Length; j++)
                    {
                        if (conditionToCompare == SoilTypeInputs[j])
                        {
                            result = true;
                        }
                    }
                }
            }
            else if (searchType == "soilMoisture")
            {
                for (int i = 0; i < plant.SoilMoisture.Count; i++)
                {
                    string conditionToCompare = plant.SoilMoisture[i];
                    for (int j = 0; j < SoilMoistureInputs.Length; j++)
                    {
                        if (conditionToCompare == SoilMoistureInputs[j])
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }
        public void DisplayReturnedPlants(List<Plant> listToDisplay)
        {
            if(listToDisplay.Count > 0)
            {
                foreach (Plant plant in listToDisplay)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{plant.CommonName} ({plant.ScientificName})");
                    Console.WriteLine($"Plant Type: {plant.PlantType}");
                    Console.WriteLine($"Light Requirements: {DisplayRequirements(plant.LightRequirements)}");
                    Console.WriteLine($"Soil Type Requirements: {DisplayRequirements(plant.SoilType)}");
                    Console.WriteLine($"Soil Moisture Requirements: {DisplayRequirements(plant.SoilMoisture)}");
                    Console.WriteLine("----------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry but there are currently no plants in the database that match those inputs." +
                                  " Please try again.");
            }
            
        }
        public string DisplayRequirements(List<string> requirementsToList)
        {
            string requirements = "";

            for(int i = 0; i < requirementsToList.Count; i++)
            {
                int lastElement = requirementsToList.Count - 1;

                if (i == lastElement)
                {
                    requirements += $"{requirementsToList[i]}.";
                }
                else
                {
                    requirements += $"{requirementsToList[i]}, ";
                }
            }
            return requirements;
        }
        public List<Plant> PlantSearch()
        {
            PlantList plantList = new PlantList();
            plantList.PopulateList();
            List<Plant> UpdatedList = plantList.PlantHolder;
            List<Plant> returnedPlantList = new List<Plant>();
            int initialPlantTotal = UpdatedList.Count;

            for (int i = 0; i < initialPlantTotal; i++)
            {
                if(UpdatedList[i].PlantType == PlantTypeInput)
                {
                    returnedPlantList.Add(UpdatedList[i]);
                }
            }
            UpdatedList = returnedPlantList;

            for (int j = 0; j < UpdatedList.Count; j++)
            {
                if (!HasRequiredInputs(returnedPlantList[j], "light"))
                {
                    returnedPlantList.RemoveAt(j);
                }
            }
            UpdatedList = returnedPlantList;

            for (int k = 0; k < UpdatedList.Count; k++)
            {
                if (!HasRequiredInputs(returnedPlantList[k], "soilType"))
                {
                    returnedPlantList.RemoveAt(k);
                }
            }
            UpdatedList = returnedPlantList;

            for (int h = 0; h < UpdatedList.Count; h++)
            {
                if (!HasRequiredInputs(returnedPlantList[h], "soilMoisture"))
                {
                    returnedPlantList.RemoveAt(h);
                }
            }
            return returnedPlantList;
        }
    }


}
