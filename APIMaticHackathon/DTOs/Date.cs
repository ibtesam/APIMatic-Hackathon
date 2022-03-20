using static APIMatic.Hackathon.DTOs.PublicHolidayResponse;

namespace APIMatic.Hackathon.DTOs
{
    public class Date
    {
        public object Iso { get; set; }
        public Datetime Datetime { get; set; }
        public Timezone Timezone { get; set; }
    }
}
