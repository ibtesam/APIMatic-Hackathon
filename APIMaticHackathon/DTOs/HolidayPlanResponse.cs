using System.Collections.Generic;

namespace APIMatic.Hackathon.DTOs
{
    public class HolidayPlanResponse
    {
        public Holiday Holiday { get; set; }

        public List<Feature> Destinations { get; set; }

        public List<Datum> Hotels { get; set; }
    }
}
