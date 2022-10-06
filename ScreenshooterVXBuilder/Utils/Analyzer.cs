using ScreenshooterVXBuilder.Models;
using System.Diagnostics;

namespace ScreenshooterVXBuilder.Utils
{
    public class Analyzer
    {
        public static PeInformations GetPEInfo(String Path)
        {
            FileInfo fi = new FileInfo(Path);
            FileVersionInfo fiVI = FileVersionInfo.GetVersionInfo(Path);
            FileStream fiO = File.OpenRead(Path);

            string sha1 = BitConverter.ToString(System.Security.Cryptography.SHA1.Create().ComputeHash(fiO));

            return new PeInformations(fi.Name, fiVI.ProductName, fiVI.FileVersion, fiVI.FileDescription, fi.Length.ToString(), sha1, fiVI.Language, fiVI.LegalCopyright, fiVI.LegalTrademarks,fiVI.CompanyName, File.GetLastWriteTime(Path).ToString());
        }

        public static StaticAnalysis Analysis(String Path)
        {
            #region Manalyze
            string manalyzeReport = "";
            var manalyzeProc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "./Tools/manalyze/manalyze.exe",
                    Arguments = $"\"{Path}\" --plugins=all --extract Extracted --dump all --output raw",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            manalyzeProc.Start();
            while (!manalyzeProc.StandardOutput.EndOfStream)
            {
                manalyzeReport += manalyzeProc.StandardOutput.ReadLine() + "[NewLine]";
            }
            #endregion

            return new StaticAnalysis(manalyzeReport);
        }
    }
}
