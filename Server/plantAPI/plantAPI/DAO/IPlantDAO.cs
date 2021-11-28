using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plantAPI.Models;

namespace plantAPI.DAO
{
    public interface IPlantDAO
    {
        List<Plant> GetAllPlants();
        Plant GetPlant(int id);

        List<Plant> QueryPlants();
        bool AddNewPlant(Plant newPlant);
        bool RemovePlant(int id);
    }
}
