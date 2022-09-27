namespace ScreenshooterVXBuilder.Models
{
    public class PeInformations
    {
        public PeInformations(string exeName, string productName, string versionNumber, string description, string size, string md5,
            string sha1, string language, string legalCopyright, string legalTrademarks, string companyName, string lastEdition)
        {
            ExeName = exeName;
            ProductName = productName;
            VersionNumber = versionNumber;
            Description = description;
            LegalCopyright = legalCopyright;
            LegalTrademarks = legalTrademarks;
            CompanyName = companyName;
            Language = language;
            Size = size;
            Md5 = md5.Replace("-", "");
            Sha1 = sha1.Replace("-", "");
            LastEdition = lastEdition;
        }

        public string? ExeName { get; set; }
        public string? ProductName { get; set; }
        public string? VersionNumber { get; set; }
        public string? LegalCopyright { get; set; }
        public string? LegalTrademarks { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public string? LastEdition { get; set; }
        public string? Size { get; set; }
        public string? Md5 { get; set; }
        public string? Sha1 { get; set; }
        public string? Language { get; set; }
    }
}
