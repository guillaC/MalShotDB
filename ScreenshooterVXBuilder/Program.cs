using System.Diagnostics;
using System.Drawing;
using ScreenshooterVXBuilder.Models;
using ScreenshooterVXBuilder.Utils;

namespace ScreenshooterVXBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> Paths = new List<String>();
            List<Malware> Malwares = Saver.LoadData();
            Process newProcess = new();

            Paths = Directory.GetFiles("./Malwares", "*.EXE", SearchOption.AllDirectories).Select(fileName => Path.GetFullPath(fileName)).ToList();

            foreach (String Path in Paths)
            {
                Malware malware = new Malware(Path, DateTime.Now.ToString());

                // Static & Informations
                malware.PeInformations = Analyzer.GetPEInfo(Path);
                malware.StaticAnalysis = Analyzer.Analysis(Path);

                if (Malwares.Where(m => m.PeInformations.Sha1.Equals(malware.PeInformations.Sha1)).Count()>0)// Check si unique dans le JSON
                {
                    Console.WriteLine($"{malware.PeInformations.ExeName} [ {malware.PeInformations.Sha1} ] déjà scanné");
                    continue;
                }
                else if (malware.StaticAnalysis.Manalyze != null && malware.StaticAnalysis.Manalyze.Contains("WINDOWS_GUI"))// Check si GUI ou pas
                {
                    // Screenshot
                    try
                    {
                        Console.WriteLine($"Lancement de {Path}");
                        newProcess = Process.Start(Path);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    if (newProcess != null && ScreenShot.WaitUI(newProcess))
                    {
                        Dictionary<String, Bitmap> screenshots = ScreenShot.CaptureFromProcess(newProcess);
                        foreach (KeyValuePair<String, Bitmap> screenshot in screenshots)
                        {
                            string randomStr = Guid.NewGuid().ToString("n");
                            string filename = $"./Screenshots/{newProcess.MainWindowTitle}_{randomStr}.png";

                            screenshot.Value.Save(filename);
                            malware.Screenshots.Add(new UI(screenshot.Key, filename));
                        }
                        Thread.Sleep(1000);
                        newProcess.CloseMainWindow();
                        newProcess.Kill(true);
                    }
                    else
                    {
                        Console.WriteLine("Impossible de récupérer un handle");
                        newProcess.CloseMainWindow();
                        newProcess.Kill(true);
                    }

                    if (malware.Screenshots.Count > 0) //save
                    {
                        Malwares.Add(malware);
                        Saver.SaveData(Malwares);
                    }
                }
            }
        }
    }
}


