namespace APIMatic.Hackathon.DTOs
{
    public class LocationDetailsRequest
    {
        /// <summary>
        /// Location to search for. Required parameter.
        /// </summary>
        /// <example>Karachi</example>
        public string Name { get; set; }

        /// <summary>
        /// Two-letter country code to search for location. Optional parameter.
        /// </summary>
        /// <example>PK, US</example>
        public string Country { get; set; }
    }
}
