using System.Collections.Generic;

namespace APIMatic.Hackathon.DTOs
{
    public class TouristDestinationResponse
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }
    }
}
