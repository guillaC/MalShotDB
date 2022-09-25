using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshooterVXBuilder.Models
{
    public class PeInformations
    {
        public PeInformations(string exeName, string productName, string versionNumber, string description, string size, string md5, string sha1, string language)
        {
            ExeName = exeName;
            ProductName = productName;
            VersionNumber = versionNumber;
            Description = description;
            Size = size;
            Md5 = md5.Replace("-","");
            Sha1 = sha1.Replace("-", "");
            Language = language;
        }

        public string ExeName { get; set; }
        public string ProductName { get; set; }
        public string VersionNumber { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Language { get; set; }
    }
}
