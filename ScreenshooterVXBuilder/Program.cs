using ScreenshooterVXBuilder.Models;
using ScreenshooterVXBuilder.Utils;

namespace ScreenshooterVXBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Counter = 0;
            List<String> Paths = new List<String>();
            List<Malware> Malwares = Saver.LoadData();

            Paths = Directory.GetFiles("./Malwares", "*.EXE", SearchOption.AllDirectories).Select(fileName => Path.GetFullPath(fileName)).ToList();

            foreach (String Path in Paths)
            {
                Counter++;
                Malware malware = new Malware(Path, DateTime.Now.ToString());

                Console.WriteLine($"Processing {Counter}/{Paths.Count()}");
                // Static & Informations
                malware.PeInformations = Analyzer.GetPEInfo(Path);
                malware.StaticAnalysis = Analyzer.Analysis(Path);

                if (Malwares.Where(m => m.PeInformations.Sha1.Equals(malware.PeInformations.Sha1)).Count() > 0)// Check si unique dans le JSON
                {
                    Console.WriteLine($"{malware.PeInformations.Sha1} entry already existing");
                    continue;
                }
                else if (malware.StaticAnalysis.Manalyze != null && malware.StaticAnalysis.Manalyze.Contains("WINDOWS_GUI"))// Check si GUI ou pas
                {
                    List<UI> screenshots = ScreenShot.TakeScreenshot(Path);
                    if (screenshots.Count > 0) //save
                    {
                        malware.Screenshots = screenshots;
                        Malwares.Add(malware);
                        Saver.SaveData(Malwares);
                    }
                }

            }
        }
    }
}


