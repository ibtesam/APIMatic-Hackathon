namespace APIMatic.Hackathon.DTOs
{
    public class HolidayPlanRequest
    {
        /// <summary>
        /// Two letter country code. Required parameter.
        /// </summary>
        /// <example>US,PK</example>
        public string CountryCode { get; set; }

        /// <summary>
        /// Month to plan holiday in. Optional parameter.
        /// </summary>
        /// <example>1-12</example>
        public int? Month { get; set; }

        /// <summary>
        /// Year to plan holiday in. Optional parameter.
        /// </summary>
        /// <example>2022</example>
        public int? Year { get; set; }

        /// <summary>
        /// City to plan holiday in. Required parameter.
        /// </summary>
        /// <example>Karachi</example>
        public string City { get; set; }

        /// <summary>
        /// Radius limit for destination. Required parameter.
        /// </summary>
        /// <example>1000</example>
        public int VisitingRadiusInMeter { get; set; } = 1000;

        /// <summary>
        /// Kind of destinations preferred, comma separated. Optional.
        /// </summary>
        /// <example>natural,interesting_places,monuments,cultural,beaches</example>
        public string DestinationKinds { get; set; }

        /// <summary>
        /// Search for destination. Optional parameter.
        /// </summary>
        /// <example>Clifton</example>
        public string PreferredDestination { get; set; }
    }
}
