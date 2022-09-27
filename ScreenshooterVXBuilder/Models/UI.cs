namespace ScreenshooterVXBuilder.Models
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
