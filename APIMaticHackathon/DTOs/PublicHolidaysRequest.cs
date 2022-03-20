namespace APIMatic.Hackathon.DTOs
{
    public class PublicHolidaysRequest
    {
        /// <summary>
        /// Two-letter country code, ISO-3166. A required field.
        /// </summary>
        /// <example>PK,US</example>
        public string Country { get; set; }

        /// <summary>
        /// The particular day for holiday. Optional.
        /// </summary>
        /// <example>1-31</example>
        public int? Day { get; set; }

        /// <summary>
        /// The particular month for holiday. Optional.
        /// </summary>
        /// <example>1-12</example>
        public int? Month { get; set; }

        /// <summary>
        /// The particular year for holidays. Required parameter.
        /// </summary>
        /// <example>2022</example>
        public int Year { get; set; }

        /// <summary>
        /// State of the mentioned country to get state-level holidays (iso-3166 format). Optional.
        /// </summary>
        /// <example>us-ny</example>
        public string Location { get; set; }
    }
}
