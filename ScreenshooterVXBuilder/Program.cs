using System.Diagnostics;
using System.Drawing;
using ScreenshooterVXBuilder.Utils;

namespace ScreenshooterVXBuilder 
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> Paths = new List<String>();
            Process newProcess = new();

            Paths = Directory.GetFiles("./Malwares", "*.EXE", SearchOption.AllDirectories).Select(fileName => Path.GetFullPath(fileName)).ToList();


            foreach (String Path in Paths)
            {
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
            }
        }
    }
}


