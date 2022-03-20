using APIMatic.Hackathon.DTOs;
using APIMatic.Standard;
using APIMatic.Standard.Controllers;
using APIMatic.Standard.Exceptions;
using APIMatic.Standard.Http.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatic.Hackathon.Controllers
{
    [ApiController]
    [Route("HolidayPlanner")]
    public class HolidayPlannerController : ControllerBase
    {
        public MiscController miscController1;
        public MiscController miscController2;
        public HttpCallBack HttpCallBackHandler;
        protected APIMaticClient Client1;
        protected APIMaticClient Client2;
        public string calendarificApiKey = "c414387b1b51021c367ed080f6801b35b765dc69";
        public string openTripApiKey = "5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba";

        public HolidayPlannerController()
        {
            this.HttpCallBackHandler = new HttpCallBack();
            this.Client1 = APIMaticClient
                .CreateFromEnvironment().ToBuilder()
                .HttpCallBack(this.HttpCallBackHandler)
                .Build();
            this.miscController1 = this.Client1.MiscController;
        }

        [HttpGet("public-holidays")]
        public async Task<PublicHolidayResponse> GetPublicHolidaysAsync([FromQuery]PublicHolidaysRequest request)
        {
            if (string.IsNullOrEmpty(request.Country) || 
                request.Day > 31 || request.Day < 1 ||
                request.Month > 12 || request.Month < 1)
            {
                throw new Exception("Invalid request.");
            }

            string apiKey = this.calendarificApiKey;

            try
            {
                var response = await this.miscController1
                    .HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(apiKey,
                    request.Country, request.Year, request.Location, request.Day, request.Month);

                var mappedResponse = new PublicHolidayResponse() { Response = new Response() { Holidays = new List<Holiday>() } };

                mappedResponse = JsonConvert.DeserializeObject<PublicHolidayResponse>(response, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                if (mappedResponse.Response.Holidays.Any())
                    mappedResponse.Response.Holidays.OrderBy(h => h.Date.Datetime.Month)
                        .ThenBy(h => h.Date.Datetime.Day);

                return mappedResponse;
            }
            catch (ApiException)
            {
                throw new Exception("Public Holidays could not be retrieved.");
            }
        }

        [HttpGet("location-details")]
        public async Task<LocationDetailsResponse> GetLocationDetailsAsync([FromQuery]LocationDetailsRequest request)
        {
            string apikey = this.openTripApiKey;

            if (string.IsNullOrEmpty(request.Name))
                throw new Exception("Invalid request.");

            try
            {
                var response = await this.miscController1.
                    HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
                    request.Name, request.Country, apikey);
                
                var mappedRespone = JsonConvert.DeserializeObject<LocationDetailsResponse>(response, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                return mappedRespone;
            }
            catch (ApiException)
            {
                throw new Exception("Location details could not be retrieved.");
            }
        }

        [HttpGet("popular-destinations-near-you")]
        public async Task<TouristDestinationResponse> GetPopularDestinationsAsync([FromQuery]TouristDestinationRequest request)
        {
            string apikey = this.openTripApiKey;

            if (request.Lat == null && request.Lon == null && request.CityDetails == null)
                throw new Exception("Please provide latitude, longitude or location.");

            try
            {
                if (request.Lat == null && request.Lon == null)
                {
                    var locationResponse = await this.GetLocationDetailsAsync(new LocationDetailsRequest { 
                        Country = request.CityDetails.Country, Name = request.CityDetails.Name });

                    request.Lat = locationResponse.Lat;
                    request.Lon = locationResponse.Lon;
                }

                var mappedResponse = new TouristDestinationResponse() { Features = new List<Feature>() };

                var response = await this.miscController1.
                    HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
                    request.Radius, request.Lon.Value, request.Lat.Value, request.Kinds, request.PreferredDestination, apikey, 20);

                mappedResponse = JsonConvert.DeserializeObject<TouristDestinationResponse>(response, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                if (mappedResponse.Features.Any())
                    mappedResponse.Features.OrderByDescending(h => h.Properties.Rate);

                return mappedResponse;
            }
            catch (ApiException)
            {
                throw new Exception("Tourism location details could not be retrieved.");
            }
        }

        async Task<OAuthResponse> GetOAuthTokenAsync()
        {
            string grantType = "client_credentials";
            string clientId = "PpTNvmtQHrcT5gArV7nmWD5fC3WKAQZy";
            string clientSecret = "0VWpyHQAvfybQwG6";

            try
            {
                var response = await this.miscController1.HttpsTestApiAmadeusComV1SecurityOauth2TokenAsync(grantType, clientId, clientSecret);

                var mappedRespone = JsonConvert.DeserializeObject<OAuthResponse>(response, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                return mappedRespone;
            }
            catch (ApiException)
            {
                throw new Exception("Token not granted.");
            }
        }

        [HttpGet("search-hotels-by-name")]
        public async Task<HotelSearchResponse> SearchHotelsByName([FromQuery]HotelSearchRequest request)
        {
            if (string.IsNullOrEmpty(request.Keyword))
                throw new Exception("Keyword cannot be empty.");

            var token = await this.GetOAuthTokenAsync();

            this.Client2 = APIMaticClient
                .CreateFromEnvironment(token.Access_Token).ToBuilder()
                .HttpCallBack(this.HttpCallBackHandler)
                .Build();

            this.miscController2 = this.Client2.MiscController;

            string subType = "HOTEL_LEISURE";
            string language = "EN";

            try
            {
                var response = await this.miscController2.
                    HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(
                    request.Keyword, subType, request.CountryCode, language, request.Max);

                var mappedResponse = new HotelSearchResponse() { Data = new List<Datum>() };

                mappedResponse = JsonConvert.DeserializeObject<HotelSearchResponse>(response, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                if (mappedResponse.Data.Any())
                    mappedResponse.Data.OrderBy(h => h.GeoCode.Latitude)
                        .ThenBy(h => h.GeoCode.Longitude);

                return mappedResponse;
            }
            catch (ApiException)
            {
                throw new Exception("Hotel details could not be retrieved.");
            }
        }

        [HttpGet("automate-planning")]
        public async Task<List<HolidayPlanResponse>> AutomatePlanAsync([FromQuery]HolidayPlanRequest request)
        {
            if (string.IsNullOrEmpty(request.CountryCode) || string.IsNullOrEmpty(request.City))
                throw new Exception("Country code or city cannot be an empty field.");

            var currentDate = DateTime.UtcNow;

            var publicHolidays = await this.GetPublicHolidaysAsync(new PublicHolidaysRequest
            {
                Country = request.CountryCode,
                Year = request.Year == null ? currentDate.Year : request.Year.Value,
                Month = request.Month == null ? null : request.Month,
            });

            var incomingPublicHolidays = publicHolidays.Response.Holidays
                .Where(h => h.Date.Datetime.Day >= currentDate.Day && h.Date.Datetime.Month >= currentDate.Month)
                .Take(5)
                .ToList();

            var response = new List<HolidayPlanResponse>();

            if (!string.IsNullOrEmpty(request.City))
            {
                var locationDetails = await this.GetLocationDetailsAsync(new LocationDetailsRequest
                {
                    Country = request.CountryCode,
                    Name = request.City
                });

                var touristDestinations = await this.GetPopularDestinationsAsync(new TouristDestinationRequest
                {
                    Radius = request.VisitingRadiusInMeter,
                    Lat = locationDetails.Lat,
                    Lon = locationDetails.Lon,
                    Kinds = request.DestinationKinds,
                    PreferredDestination = request.PreferredDestination
                });

                var hotels = await this.SearchHotelsByName(new HotelSearchRequest
                {
                    CountryCode = request.CountryCode,
                    Keyword = request.City,
                    Max = 20
                });

                response = incomingPublicHolidays.Select(h => new HolidayPlanResponse
                {
                    Holiday = h,
                    Destinations = touristDestinations.Features.Take(10).ToList(),
                    Hotels = hotels.Data.Take(10).ToList()
                })
                .ToList();
            }

            return response;
        }
    }
}
