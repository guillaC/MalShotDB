using ScreenshooterVXBuilder.Models;
using System.Text.Json;

namespace ScreenshooterVXBuilder.Utils
{
    public class Saver
    {
        public static List<Malware> LoadData(string pPath = "./sav.json")
        {
            List<Malware> malwares;

            if (File.Exists(pPath)) {
                using (StreamReader r = new StreamReader(pPath))
                {
                    string json = r.ReadToEnd();
                    malwares = JsonSerializer.Deserialize<List<Malware>>(json);
                }
            } else
            {
                malwares = new List<Malware>();
            } 

            return malwares;
        }

        public static void SaveData(List<Malware> pMalwares, string pPath = "./sav.json")
        {
            string jSon = JsonSerializer.Serialize(pMalwares);
            File.WriteAllText(pPath, jSon);
        }
    }
}
