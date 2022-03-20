namespace APIMatic.Hackathon.DTOs
{
    public class TouristDestinationRequest
    {
        /// <summary>
        /// Radius to search within for location. Required parameter.
        /// </summary>
        /// <example>10000</example>
        public int Radius { get; set; }

        /// <summary>
        /// Latitude to search from. Optional if not known.
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// Longitude to search from. Optional if not known.
        /// </summary>
        public double? Lon { get; set; }

        /// <summary>
        /// City details. Required parameter if lat long are not provided.
        /// </summary>
        /// <example>Karachi</example>
        public LocationDetailsRequest CityDetails { get; set; }

        /// <summary>
        /// Kind of destinations preferred, comma separated. Optional.
        /// </summary>
        /// <example>natural,interesting_places,monuments,cultural,beaches</example>
        public string Kinds { get; set; }

        /// <summary>
        /// Search for destination. Optional parameter.
        /// </summary>
        /// <example>Clifton</example>
        public string PreferredDestination { get; set; }
    }
}
