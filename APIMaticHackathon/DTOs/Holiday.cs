using System.Collections.Generic;

namespace APIMatic.Hackathon.DTOs
{
    public class Holiday
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Country Country { get; set; }
        public Date Date { get; set; }
        public List<string> Type { get; set; }
        public string Locations { get; set; }
        public object States { get; set; }
    }
}
