using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plantAPI.Models;
using System.Data.SqlClient;

namespace plantAPI.DAO
{
    public class PlantDAO : IPlantDAO
    {
        private readonly string connectionString;

        public PlantDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

         public List<Plant> GetAllPlants()
        {
            List<Plant> allPlants = new List<Plant>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM plant_profiles", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Plant plant = GetPlantFromReader(reader);
                        allPlants.Add(plant);
                    }
                    return allPlants;
                }  
            }
            catch(SqlException)
            {
                throw;
            }
        }
        public Plant GetPlant(int plantID)
        {
            Plant selectedPlant = new Plant();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM plant_profiles WHERE plant_id = @plant_id", conn);
                    cmd.Parameters.AddWithValue("@plant_id", plantID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        selectedPlant = GetPlantFromReader(reader);
                    }
                    return selectedPlant;
                }
            }
            catch(SqlException)
            {
                throw;
            }
        }
        public List<Plant> QueryPlants()
        {

        }
        public bool AddNewPlant(Plant newPlant)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO plant_profiles (plant_type, common_name, scientific_name, light_requirements, soil_type, soil_moisture, summary) " +
                                                    "VALUES (@plant_type, @common_name, @scientific_name, @light_requirements, @soil_type, @soil_moisture, @summary)", conn);
                    cmd.Parameters.AddWithValue("@plant_type", newPlant.PlantType);
                    cmd.Parameters.AddWithValue("@common_name", newPlant.CommonName);
                    cmd.Parameters.AddWithValue("@scientific_name", newPlant.ScientificName);
                    cmd.Parameters.AddWithValue("@light_requirements", newPlant.LightRequirements);
                    cmd.Parameters.AddWithValue("@soil_type", newPlant.SoilType);
                    cmd.Parameters.AddWithValue("@soil_moisture", newPlant.SoilMoisture);
                    cmd.Parameters.AddWithValue("@summary", newPlant.Summary);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch(SqlException)
            {
                throw;
            }

        }
        public bool RemovePlant(int plantID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE * FROM plant_profiles WHERE plant_id = @plant_id", conn);
                    cmd.Parameters.AddWithValue("@plant_id", plantID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            catch(SqlException)
            {
                throw;
            }

        }

        private Plant GetPlantFromReader(SqlDataReader reader)
        {
            Plant plant = new Plant()
            {
                PlantID = Convert.ToInt32(reader["plant_id"]),
                PlantType = Convert.ToString(reader["plant_type"]),
                CommonName = Convert.ToString(reader["common_name"]),
                ScientificName = Convert.ToString(reader["scientific_name"]),
                LightRequirements = Convert.ToString(reader["light_requirements"]),
                SoilType = Convert.ToString(reader["soil_type"]),
                SoilMoisture = Convert.ToString(reader["soil_moisture"]),
                Summary = Convert.ToString(reader["summary"])
            };

            return plant;
        }
    }
}
