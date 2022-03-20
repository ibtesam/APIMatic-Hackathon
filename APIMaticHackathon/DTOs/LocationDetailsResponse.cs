namespace APIMatic.Hackathon.DTOs
{
    public class LocationDetailsResponse
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public int Population { get; set; }
        public string Timezone { get; set; }
        public string Status { get; set; }
    }
}
