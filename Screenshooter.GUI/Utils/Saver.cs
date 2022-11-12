using Screenshooter.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Screenshooter.GUI.Utils
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

        public static void SaveDataMD(List<Malware> pMalwares, string pPath)
        {
            pMalwares = pMalwares.OrderBy(m => m.PeInformations.LastEdition).ToList();
            Directory.CreateDirectory(pPath + "/Reports/");

            string md = "";
            foreach (Malware m in pMalwares)
            {
                md = "![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)" + Environment.NewLine;
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
                md += $"| Language | {m.PeInformations.Language} |{Environment.NewLine}";
                md += $"## Static Analysis{Environment.NewLine}";
                md += $"<details>{Environment.NewLine}<summary>Manalyze</summary>{Environment.NewLine}";
                md += $"<p>{Environment.NewLine}{Environment.NewLine}```{Environment.NewLine}{Environment.NewLine}{m.StaticAnalysis.Manalyze.Replace("[NewLine]", Environment.NewLine)}{Environment.NewLine}{Environment.NewLine}```{Environment.NewLine}{Environment.NewLine}</p>{Environment.NewLine}";
                md += $"</details>{Environment.NewLine}{Environment.NewLine}";
                md += $"## Screenshots{Environment.NewLine}";
                foreach (UI ui in m.Screenshots)
                {
                    md += $"### {ui.WindowTitle}{Environment.NewLine}";
                    md += $"![UI]({ui.Path.Replace(" ", "%20")}) {Environment.NewLine}";
                }
                File.WriteAllText(pPath + "/Reports/" + m.PeInformations.Sha1 + ".md", md);
            }

            md = "![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)" + Environment.NewLine;
            md += $"# Table of Contents{Environment.NewLine}";
            md += $"| SHA1 | Product Name | Version Number | Form titles |{Environment.NewLine}";
            md += $"| :--- | --- | --- | --- |{Environment.NewLine}";

            var malwaresGrouped = pMalwares.GroupBy(x => DateTime.Parse(x.PeInformations.LastEdition).ToString("yyyy"));
            Dictionary<string, List<Malware>> malwaresGToDic = malwaresGrouped.ToDictionary(g => g.Key, g => g.ToList());
            SortedDictionary<string, List<Malware>> sortedMalwaresGToDic = new SortedDictionary<string, List<Malware>>(malwaresGToDic);

            int pageNB = 1;
            foreach (KeyValuePair<string, List<Malware>> mDic in sortedMalwaresGToDic)
            {
                //int pageNB = 1;
                //md += $"## {mDic.Key}{Environment.NewLine}";
                foreach (Malware m in mDic.Value)
                {
                    string productName = "";
                    string versionNumber = "";
                    List<string> formTitlesList = new List<string>();
                    foreach (UI screenS in m.Screenshots) formTitlesList.Add(screenS.WindowTitle);
                    string formTitlesString = String.Join(", ", formTitlesList.ToArray());

                    if (m.PeInformations.ProductName != null) productName = m.PeInformations.ProductName.Replace('[', ' ').Replace(']', ' ');
                    if (m.PeInformations.VersionNumber != null) versionNumber = m.PeInformations.VersionNumber;

                    md += $"| [{m.PeInformations.Sha1}](./Reports/{m.PeInformations.Sha1}.md) | {productName} | {versionNumber} | {formTitlesString} |{Environment.NewLine}";
                }
            }

            File.WriteAllText(pPath + "/readme.md", md);
        }
    }
}
