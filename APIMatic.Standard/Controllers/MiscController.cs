// <copyright file="MiscController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace APIMatic.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Standard;
    using APIMatic.Standard.Authentication;
    using APIMatic.Standard.Http.Client;
    using APIMatic.Standard.Http.Request;
    using APIMatic.Standard.Http.Response;
    using APIMatic.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MiscController.
    /// </summary>
    public class MiscController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal MiscController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// https://calendarific.com/api/v2/holidays?api_key=c414387b1b51021c367ed080f6801b35b765dc69&country=PK&year=2022&location=pk-khi EndPoint.
        /// </summary>
        /// <param name="apiKey">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="year">Required parameter: Example: .</param>
        /// <param name="location">Required parameter: Example: .</param>
        public void HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhi(
                string apiKey,
                string country,
                int year,
                string location,
                int? month,
                int? day)
        {
            Task t = this.HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(apiKey, 
                country, year, location, day, month);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// https://calendarific.com/api/v2/holidays?api_key=c414387b1b51021c367ed080f6801b35b765dc69&country=PK&year=2022&location=pk-khi EndPoint.
        /// </summary>
        /// <param name="apiKey">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="year">Required parameter: Example: .</param>
        /// <param name="location">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task<string> HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(
                string apiKey,
                string country,
                int year,
                string location,
                int? day,
                int? month,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/holidays");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "api_key", apiKey },
                { "country", country },
                { "year", year }
            };

            if (location != null)
                queryParams.Add("location", location);

            if (day != null)
                queryParams.Add("day", day);

            if (month != null)
                queryParams.Add("month", month);

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }

        /// <summary>
        /// https://api.opentripmap.com/0.1/en/places/geoname?name=Balochistan&country=PK&apikey=5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="apikey">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        public void HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba(
                string name,
                string country,
                string apikey)
        {
            Task t = this.HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(name, country, apikey);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// https://api.opentripmap.com/0.1/en/places/geoname?name=Balochistan&country=PK&apikey=5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="apikey">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task<string> HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
                string name,
                string country,
                string apikey,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/geoname");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "name", name },
                { "country", country },
                { "apikey", apikey },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }

        /// <summary>
        /// https://api.opentripmap.com/0.1/en/places/radius?radius=10000&lon=67.0104&lat=24.8608&kinds=natural%2Cbeaches%2Cother_beaches&apikey=5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba EndPoint.
        /// </summary>
        /// <param name="radius">Required parameter: Example: .</param>
        /// <param name="lon">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="kinds">Required parameter: Example: .</param>
        /// <param name="apikey">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        public void HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba(
                int radius,
                double lon,
                double lat,
                string kinds,
                string name,
                string apikey,
                int limit)
        {
            Task t = this.HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(radius, lon, lat, kinds, name, apikey, limit);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// https://api.opentripmap.com/0.1/en/places/radius?radius=10000&lon=67.0104&lat=24.8608&kinds=natural%2Cbeaches%2Cother_beaches&apikey=5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba EndPoint.
        /// </summary>
        /// <param name="radius">Required parameter: Example: .</param>
        /// <param name="lon">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="kinds">Required parameter: Example: .</param>
        /// <param name="apikey">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task<string> HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
                int radius,
                double lon,
                double lat,
                string kinds,
                string name,
                string apikey,
                int limit,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/radius");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "radius", radius },
                { "lon", lon },
                { "lat", lat },
                { "kinds", kinds },
                { "apikey", apikey },
                { "name", name },
                { "limit", limit }
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }

        /// <summary>
        /// https://test.api.amadeus.com/v1/reference-data/locations/hotel?keyword=Karachi&subType=HOTEL_LEISURE&subType=HOTEL_GDS&countryCode=PK&lang=EN&max=20 EndPoint.
        /// </summary>
        /// <param name="keyword">Required parameter: Example: .</param>
        /// <param name="subType">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="max">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        public void HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20(
                string keyword,
                string subType,
                string countryCode,
                string lang,
                int max)
        {
            Task t = this.HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(keyword, subType, countryCode, lang, max);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// https://test.api.amadeus.com/v1/reference-data/locations/hotel?keyword=Karachi&subType=HOTEL_LEISURE&subType=HOTEL_GDS&countryCode=PK&lang=EN&max=20 EndPoint.
        /// </summary>
        /// <param name="keyword">Required parameter: Example: .</param>
        /// <param name="subType">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="max">Required parameter: Example: .</param>
        /// <param name="accept">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task<string> HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(
                string keyword,
                string subType,
                string countryCode,
                string lang,
                int max,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server3);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/reference-data/locations/hotel");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "keyword", keyword },
                { "subType", subType },
                { "countryCode", countryCode },
                { "lang", lang },
                { "max", max },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }


        /// <summary>
        /// https://test.api.amadeus.com/v1/security/oauth2/token EndPoint.
        /// </summary>
        /// <param name="grantType">Required parameter: Example: .</param>
        /// <param name="clientId">Required parameter: Example: .</param>
        /// <param name="clientSecret">Required parameter: Example: .</param>
        public void HttpsTestApiAmadeusComV1SecurityOauth2Token(
                string grantType,
                string clientId,
                string clientSecret)
        {
            Task t = this.HttpsTestApiAmadeusComV1SecurityOauth2TokenAsync(grantType, clientId, clientSecret);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// https://test.api.amadeus.com/v1/security/oauth2/token EndPoint.
        /// </summary>
        /// <param name="grantType">Required parameter: Example: .</param>
        /// <param name="clientId">Required parameter: Example: .</param>
        /// <param name="clientSecret">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task<string> HttpsTestApiAmadeusComV1SecurityOauth2TokenAsync(
                string grantType,
                string clientId,
                string clientSecret,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server3);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/security/oauth2/token");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Content-Type", "application/x-www-form-urlencoded" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("grant_type", grantType),
                new KeyValuePair<string, object>("client_id", clientId),
                new KeyValuePair<string, object>("client_secret", clientSecret),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), null, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return response.Body;
        }
    }
}