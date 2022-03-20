# Misc

```csharp
MiscController miscController = client.MiscController;
```

## Class Name

`MiscController`

## Methods

* [Https Calendarific Com Api V 2 Holidays Api Key C 414387 B 1 B 51021 C 367 Ed 080 F 6801 B 35 B 765 Dc 69 Country PK Year 2022 Location Pk-Khi](../../doc/controllers/misc.md#https-calendarific-com-api-v-2-holidays-api-key-c-414387-b-1-b-51021-c-367-ed-080-f-6801-b-35-b-765-dc-69-country-pk-year-2022-location-pk-khi)
* [Https Api Opentripmap Com 0 1 En Places Geoname Name Balochistan Country PK Apikey 5 Ae 2 E 3 F 221 C 38 a 28845 F 05 B 67 D 444 F 5 Ca 2 Dbda 72 B 5 E 51 a 9 D 6 Ed 318 Ba](../../doc/controllers/misc.md#https-api-opentripmap-com-0-1-en-places-geoname-name-balochistan-country-pk-apikey-5-ae-2-e-3-f-221-c-38-a-28845-f-05-b-67-d-444-f-5-ca-2-dbda-72-b-5-e-51-a-9-d-6-ed-318-ba)
* [Https Api Opentripmap Com 0 1 En Places Radius Radius 10000 Lon 67 0104 Lat 24 8608 Kinds Natural 2 Cbeaches 2 Cother Beaches Apikey 5 Ae 2 E 3 F 221 C 38 a 28845 F 05 B 67 D 444 F 5 Ca 2 Dbda 72 B 5 E 51 a 9 D 6 Ed 318 Ba](../../doc/controllers/misc.md#https-api-opentripmap-com-0-1-en-places-radius-radius-10000-lon-67-0104-lat-24-8608-kinds-natural-2-cbeaches-2-cother-beaches-apikey-5-ae-2-e-3-f-221-c-38-a-28845-f-05-b-67-d-444-f-5-ca-2-dbda-72-b-5-e-51-a-9-d-6-ed-318-ba)
* [Https Test Api Amadeus Com V 1 Reference-Data Locations Hotel Keyword Karachi Sub Type HOTEL LEISURE Sub Type HOTEL GDS Country Code PK Lang EN Max 20](../../doc/controllers/misc.md#https-test-api-amadeus-com-v-1-reference-data-locations-hotel-keyword-karachi-sub-type-hotel-leisure-sub-type-hotel-gds-country-code-pk-lang-en-max-20)


# Https Calendarific Com Api V 2 Holidays Api Key C 414387 B 1 B 51021 C 367 Ed 080 F 6801 B 35 B 765 Dc 69 Country PK Year 2022 Location Pk-Khi

```csharp
HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(
    string apiKey,
    string country,
    int year,
    string location)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apiKey` | `string` | Query, Required | - |
| `country` | `string` | Query, Required | - |
| `year` | `int` | Query, Required | - |
| `location` | `string` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string apiKey = "c414387b1b51021c367ed080f6801b35b765dc69";
string country = "PK";
int year = 2022;
string location = "pk-khi";

try
{
    await miscController.HttpsCalendarificComApiV2HolidaysApiKeyC414387b1b51021c367ed080f6801b35b765dc69CountryPKYear2022LocationPkKhiAsync(apiKey, country, year, location);
}
catch (ApiException e){};
```


# Https Api Opentripmap Com 0 1 En Places Geoname Name Balochistan Country PK Apikey 5 Ae 2 E 3 F 221 C 38 a 28845 F 05 B 67 D 444 F 5 Ca 2 Dbda 72 B 5 E 51 a 9 D 6 Ed 318 Ba

```csharp
HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
    string name,
    string country,
    string apikey,
    string accept)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Required | - |
| `country` | `string` | Query, Required | - |
| `apikey` | `string` | Query, Required | - |
| `accept` | `string` | Header, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string name = "Balochistan";
string country = "PK";
string apikey = "5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba";
string accept = "application/json";

try
{
    await miscController.HttpsApiOpentripmapCom01EnPlacesGeonameNameBalochistanCountryPKApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(name, country, apikey, accept);
}
catch (ApiException e){};
```


# Https Api Opentripmap Com 0 1 En Places Radius Radius 10000 Lon 67 0104 Lat 24 8608 Kinds Natural 2 Cbeaches 2 Cother Beaches Apikey 5 Ae 2 E 3 F 221 C 38 a 28845 F 05 B 67 D 444 F 5 Ca 2 Dbda 72 B 5 E 51 a 9 D 6 Ed 318 Ba

```csharp
HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(
    int radius,
    double lon,
    double lat,
    string kinds,
    string apikey,
    string accept)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `radius` | `int` | Query, Required | - |
| `lon` | `double` | Query, Required | - |
| `lat` | `double` | Query, Required | - |
| `kinds` | `string` | Query, Required | - |
| `apikey` | `string` | Query, Required | - |
| `accept` | `string` | Header, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
int radius = 10000;
double lon = 67.0104;
double lat = 24.8608;
string kinds = "natural,beaches,other_beaches";
string apikey = "5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318ba";
string accept = "application/json";

try
{
    await miscController.HttpsApiOpentripmapCom01EnPlacesRadiusRadius10000Lon670104Lat248608KindsNatural2Cbeaches2CotherBeachesApikey5ae2e3f221c38a28845f05b67d444f5ca2dbda72b5e51a9d6ed318baAsync(radius, lon, lat, kinds, apikey, accept);
}
catch (ApiException e){};
```


# Https Test Api Amadeus Com V 1 Reference-Data Locations Hotel Keyword Karachi Sub Type HOTEL LEISURE Sub Type HOTEL GDS Country Code PK Lang EN Max 20

```csharp
HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(
    string keyword,
    string subType,
    string countryCode,
    string lang,
    int max,
    string accept)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `keyword` | `string` | Query, Required | - |
| `subType` | `string` | Query, Required | - |
| `countryCode` | `string` | Query, Required | - |
| `lang` | `string` | Query, Required | - |
| `max` | `int` | Query, Required | - |
| `accept` | `string` | Header, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string keyword = "Karachi";
string subType = "HOTEL_LEISURE";
string countryCode = "PK";
string lang = "EN";
int max = 20;
string accept = "application/json";

try
{
    await miscController.HttpsTestApiAmadeusComV1ReferenceDataLocationsHotelKeywordKarachiSubTypeHOTELLEISURESubTypeHOTELGDSCountryCodePKLangENMax20Async(keyword, subType, countryCode, lang, max, accept);
}
catch (ApiException e){};
```

