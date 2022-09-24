using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshooterVXBuilder.Models
{
    public class UI
    {
        public UI(string? windowTitle, string? path)
        {
            WindowTitle = windowTitle;
            Path = path;
        }
        public string? WindowTitle { get; set; }
        public string? Path { get; set; }
    }
}
