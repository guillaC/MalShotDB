using ScreenshooterVXBuilder.Models;
using ScreenshooterVXBuilder.Utils;

namespace jsonToMdVXBuilder
{
    public class Program
    {

        static void Main(string[] args)
        {
            string jsonPath = "";

            if (args.Length > 0)
            {
                jsonPath = Environment.GetCommandLineArgs()[1];
            }
            else
            {
                Console.Write("Json Path: ");
                jsonPath = Console.ReadLine();
            }

            List<Malware> Malwares = Saver.LoadData(jsonPath);
            Saver.SaveDataMD(Malwares, jsonPath.Replace(Path.GetFileName(jsonPath),""));
            Console.WriteLine("done.");
            Console.ReadLine();

            
        }
    }
}