using System.Collections.Generic;

namespace APIMatic.Hackathon.DTOs
{
    public class Datum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IataCode { get; set; }
        public string SubType { get; set; }
        public int Relevance { get; set; }
        public string Type { get; set; }
        public List<string> HotelIds { get; set; }
        public Address Address { get; set; }
        public GeoCode GeoCode { get; set; }
    }
}
