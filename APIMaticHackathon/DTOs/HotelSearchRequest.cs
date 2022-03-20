namespace APIMatic.Hackathon.DTOs
{
    public class HotelSearchRequest
    {
        /// <summary>
        /// Hotel to search for. Required parameter.
        /// </summary>
        /// <example>Pearl</example>
        public string Keyword { get; set; }

        /// <summary>
        /// Two letter country code. Required parameter.
        /// </summary>
        /// <example>US,PK</example>
        public string CountryCode { get; set; }

        /// <summary>
        /// Result limit. Required parameter.
        /// </summary>
        /// <example>20</example>
        public int Max { get; set; }
    }
}
