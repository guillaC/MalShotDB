using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenshooter.GUI.Models
{
    public class UI
    {
        public UI(string? windowTitle, string? path)
        {
            WindowTitle = windowTitle.Replace("/", "").Replace("\\", "");
            Path = path;
        }
        public string? WindowTitle { get; set; }
        public string? Path { get; set; }
    }
}
