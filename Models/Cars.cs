using System.Diagnostics;

namespace MyWebApp.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string color { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string modelNumber { get; set; } = string.Empty;
        public string fuletype { get; set; } = string.Empty;
        public string imageURL { get; set; } = string.Empty;
    }
}
