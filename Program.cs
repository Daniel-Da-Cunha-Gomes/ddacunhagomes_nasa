using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        static void Rendu() // apod
        {
            string apiClef = "iiagg5zZv2MSjDkyu6X4QinV2cUEaXCP0eKNy7Br";
            string url = $"https://api.nasa.gov/planetary/apod?api_key={apiClef}";

            using (WebClient client1 = new WebClient())
            {
                string json = client1.DownloadString(url);
                JObject data = JObject.Parse(json);
                string titre = (string)data["title"];
                string date = (string)data["date"];
                string explication = (string)data["explanation"];
                string imgUrl = (string)data["url"];

                Console.WriteLine("titre: " + titre);
                Console.WriteLine("Date: " + date);
                Console.WriteLine("explication: " + explication);
                Console.WriteLine("Image URL: " + imgUrl);
            }
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string apiClef = "iiagg5zZv2MSjDkyu6X4QinV2cUEaXCP0eKNy7Br";
            string url = $"https://api.nasa.gov/neo/rest/v1/neo/browse?api_key={apiClef}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                JObject data = JObject.Parse(json);
                JArray asteroidArray = (JArray)data["near_earth_objects"];
                for (int i = 0; i < asteroidArray.Count; i++)
                {
                    string name = (string)asteroidArray[i]["name"];
                    double diameter = (double)asteroidArray[i]["estimated_diameter"]["meters"]["estimated_diameter_max"];
                    
                    string isPotentiallyHazard = (string)asteroidArray[i]["is_potentially_hazardous_asteroid"];

                    string kilometersEstimatedDiameterMin = (string)asteroidArray[i]["estimated_diameter"]["kilometers"]["estimated_diameter_min"];
                    string kilometersEstimatedDiameterMax = (string)asteroidArray[i]["estimated_diameter"]["kilometers"]["estimated_diameter_max"];
                    
                    string firstDate = (string)asteroidArray[i]["orbital_data"]["first_observation_date"].ToString();
                    string lastDate = (string)asteroidArray[i]["orbital_data"]["last_observation_date"].ToString();
                    
                    string absoluteMagnitudeH = (string)asteroidArray[i]["absolute_magnitude_h"];
                    string orbitDeterminationDate = (string)asteroidArray[i]["orbital_data"]["orbit_determination_date"].ToString();
                    string observationsUse = (string)asteroidArray[i]["orbital_data"]["observations_used"].ToString();
                    string minimumOrbitIntersection = (string)asteroidArray[i]["orbital_data"]["minimum_orbit_intersection"].ToString();
                    string ecentricity = (string)asteroidArray[i]["orbital_data"]["eccentricity"].ToString();
                    string semiMajorX = (string)asteroidArray[i]["orbital_data"]["semi_major_axis"].ToString();
                    string orbitalPeriod = (string)asteroidArray[i]["orbital_data"]["orbital_period"].ToString();
                    string orbitClassRange = (string)asteroidArray[i]["orbital_data"]["orbit_class"]["orbit_class_range"].ToString();

                    Console.WriteLine("Name: " + name + "\n" + " Diameter: " + diameter + "\n" + " Potentially Hazard: " + isPotentiallyHazard + " km min : " + kilometersEstimatedDiameterMin + "\n"
                          + " km max : " + kilometersEstimatedDiameterMax + "\n" + " First_date : " + firstDate + "\n" + " Last_date : " + lastDate + "\n" + " absolute_magnitude_h : " + absoluteMagnitudeH + "\n"
                          + " orbit_determination_dat : " + orbitDeterminationDate + "\n" + " observations_use : " + observationsUse + "\n" + " minimum_orbit_intersection : " + minimumOrbitIntersection + "\n"
                          + " ecentricity : " + ecentricity + "\n" + " semi_major_x : " + semiMajorX + "\n" + " orbital_period : " + orbitalPeriod + "\n"
                          + " orbit_class_range : " + orbitClassRange + "\n"
                        );
                    JArray approachDataArray = (JArray)asteroidArray[i]["close_approach_data"];
                    List<string> approachDataList = new List<string>();
                    for (int j = 0; j < approachDataArray.Count; j++)
                    {
                        string approachDate = (string)approachDataArray[j]["close_approach_date"];
                        approachDataList.Add(approachDate);
                    }

                    Console.WriteLine("Approach Dates: " + string.Join(",", approachDataList));
                    Rendu();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Laplanet());
        }
    }
}
