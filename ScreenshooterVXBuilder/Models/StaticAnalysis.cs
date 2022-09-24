using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshooterVXBuilder.Models
{
    public class StaticAnalysis
    {
        public StaticAnalysis(string? peScan, string? binText, string? signature)
        {
            PeScan = peScan;
            BinText = binText;
            Signature = signature;
        }
        public string? PeScan { get; set; }
        public string? BinText { get; set; }
        public string? Signature { get; set; }
    }
}
