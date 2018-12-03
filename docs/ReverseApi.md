# locationiq.Api.ReverseApi

All URIs are relative to *https://eu1.locationiq.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Reverse**](ReverseApi.md#reverse) | **GET** /reverse.php | Reverse Geocoding


<a name="reverse"></a>
# **Reverse**
> Location Reverse (decimal? lat, decimal? lon, string format, int? normalizecity, int? addressdetails = null, string acceptLanguage = null, int? namedetails = null, int? extratags = null)

Reverse Geocoding

Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.

### Example
```csharp
using System;
using System.Diagnostics;
using locationiq.Api;
using locationiq.Client;
using locationiq.Model;

namespace Example
{
    public class ReverseExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new ReverseApi();
            var lat = 17.24;  // decimal? | Latitude of the location to generate an address for.
            var lon = 74.25;  // decimal? | Longitude of the location to generate an address for.
            var format = "json";  // string | Format to geocode. Only JSON supported for SDKs
            var normalizecity = 1;  // int? | Normalizes village to city level data to city
            var addressdetails = 1;  // int? | Include a breakdown of the address into elements. Defaults to 1. (optional)  (default to 1)
            var acceptLanguage = "en";  // string | Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language=native (optional) 
            var namedetails = 0;  // int? | Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional) 
            var extratags = 0;  // int? | Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional) 

            try
            {
                // Reverse Geocoding
                Location result = apiInstance.Reverse(lat, lon, format, normalizecity, addressdetails, acceptLanguage, namedetails, extratags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReverseApi.Reverse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lat** | **decimal?**| Latitude of the location to generate an address for. | 
 **lon** | **decimal?**| Longitude of the location to generate an address for. | 
 **format** | **string**| Format to geocode. Only JSON supported for SDKs | 
 **normalizecity** | **int?**| Normalizes village to city level data to city | 
 **addressdetails** | **int?**| Include a breakdown of the address into elements. Defaults to 1. | [optional] [default to 1]
 **acceptLanguage** | **string**| Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native | [optional] 
 **namedetails** | **int?**| Include a list of alternative names in the results. These may include language variants, references, operator and brand. | [optional] 
 **extratags** | **int?**| Include additional information in the result if available, e.g. wikipedia link, opening hours. | [optional] 

### Return type

[**Location**](Location.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

