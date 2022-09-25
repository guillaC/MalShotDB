using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshooterVXBuilder.Models
{
    public class StaticAnalysis
    {
        public string? Manalyze { get; set; }

        public StaticAnalysis(string? Manalyze)
        {
            this.Manalyze = Manalyze;
        }
    }
}
