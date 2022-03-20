// <copyright file="MiscControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace APIMatic.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Standard;
    using APIMatic.Standard.Controllers;
    using APIMatic.Standard.Exceptions;
    using APIMatic.Standard.Http.Client;
    using APIMatic.Standard.Http.Response;
    using APIMatic.Standard.Utilities;
    using APIMatic.Tests.Helpers;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// MiscControllerTest.
    /// </summary>
    [TestFixture]
    public class MiscControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MiscController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MiscController;
        }

        /// <summary>
        /// TestHttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhi.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhi()
        {
            // Parameters for the API call
            string apiKey = "c414387b1b51021c367ed080f6801b35b765dc69";
            string country = "PK";
            int year = 2022;
            string location = "pk-khi";

            // Perform API call
            try
            {
                await this.controller.HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(apiKey, country, year, location);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba()
        {
            // Parameters for the API call
            string name = "Balochistan";
            string country = "PK";
            string apikey = "5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba";
            string accept = "application/json";

            // Perform API call
            try
            {
                await this.controller.HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(name, country, apikey, accept);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba()
        {
            // Parameters for the API call
            int radius = 10000;
            double lon = 67.0104;
            double lat = 24.8608;
            string kinds = "natural,beaches,other_beaches";
            string apikey = "5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba";
            string accept = "application/json";

            // Perform API call
            try
            {
                await this.controller.HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(radius, lon, lat, kinds, apikey, accept);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20()
        {
            // Parameters for the API call
            string keyword = "Karachi";
            string subType = "HOTEL_LEISURE";
            string countryCode = "PK";
            string lang = "EN";
            int max = 20;
            string accept = "application/json";

            // Perform API call
            try
            {
                await this.controller.HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(keyword, subType, countryCode, lang, max, accept);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}