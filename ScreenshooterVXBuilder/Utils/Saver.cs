using ScreenshooterVXBuilder.Models;
using System.Text.Json;

namespace ScreenshooterVXBuilder.Utils
{
    public class Saver
    {
        public static List<Malware> LoadData(string pPath = "./sav.json")
        {
            List<Malware> malwares;

            if (File.Exists(pPath))
            {
                using (StreamReader r = new StreamReader(pPath))
                {
                    string json = r.ReadToEnd();
                    malwares = JsonSerializer.Deserialize<List<Malware>>(json);
                }
            }
            else
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

        public static void SaveDataMD(List<Malware> pMalwares, string pPath = "./sav.md")
        {
            pMalwares = pMalwares.OrderBy(m => m.PeInformations.LastEdition).ToList();
            string md = "![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)" + Environment.NewLine;

            foreach (Malware m in pMalwares)
            {
                md += $"# {m.PeInformations.ProductName} - {m.PeInformations.ExeName}{Environment.NewLine}";
                md += $"## Informations{Environment.NewLine}";
                md += $"| Label | Value |{Environment.NewLine}";
                md += $"| :--- | ---: |{Environment.NewLine}";
                md += $"| Executable Name | {m.PeInformations.ExeName} |{Environment.NewLine}";
                md += $"| Product Name | {m.PeInformations.ProductName} |{Environment.NewLine}";
                md += $"| Version Number | {m.PeInformations.VersionNumber} |{Environment.NewLine}";
                md += $"| Description | {m.PeInformations.Description} |{Environment.NewLine}";
                md += $"| Company Name | {m.PeInformations.CompanyName} |{Environment.NewLine}";
                md += $"| Copyright | {m.PeInformations.LegalCopyright} |{Environment.NewLine}";
                md += $"| Trademarks | {m.PeInformations.LegalTrademarks} |{Environment.NewLine}";
                md += $"| Last Edition | {m.PeInformations.LastEdition} |{Environment.NewLine}";
                md += $"| Size | {m.PeInformations.Size} |{Environment.NewLine}";
                md += $"| SHA1 🔎 | [{m.PeInformations.Sha1}](https://www.virustotal.com/gui/search/{m.PeInformations.Sha1}) |{Environment.NewLine}";
                md += $"| MD5 | {m.PeInformations.Md5} |{Environment.NewLine}";
                md += $"| Language | {m.PeInformations.Language} |{Environment.NewLine}";
                md += $"## Static Analysis{Environment.NewLine}";
                md += $"<details>{Environment.NewLine}<summary>Manalyze</summary>{Environment.NewLine}";
                md += $"<p>{Environment.NewLine}{Environment.NewLine}```{Environment.NewLine}{Environment.NewLine}{m.StaticAnalysis.Manalyze.Replace("[NewLine]", Environment.NewLine)}{Environment.NewLine}{Environment.NewLine}```{Environment.NewLine}{Environment.NewLine}</p>{Environment.NewLine}";
                md += $"</details>{Environment.NewLine}{Environment.NewLine}";
                md += $"## Screenshots{Environment.NewLine}";
                foreach(UI ui in m.Screenshots)
                {
                    md += $"### {ui.WindowTitle}{Environment.NewLine}";
                    md += $"![UI]({ui.Path}) {Environment.NewLine}";
                }
            }

            File.WriteAllText(pPath, md);
        }
    }
}
