# locationiq.Api.SearchApi

All URIs are relative to *https://eu1.locationiq.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Search**](SearchApi.md#search) | **GET** /search.php | Forward Geocoding


<a name="search"></a>
# **Search**
> List<Location> Search (string q, string format, int? normalizecity, int? addressdetails = null, string viewbox = null, int? bounded = null, int? limit = null, string acceptLanguage = null, string countrycodes = null, int? namedetails = null, int? dedupe = null, int? extratags = null)

Forward Geocoding

The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.

### Example
```csharp
using System;
using System.Diagnostics;
using locationiq.Api;
using locationiq.Client;
using locationiq.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new SearchApi();
            var q = Empire state building;  // string | Address to geocode
            var format = json;  // string | Format to geocode. Only JSON supported for SDKs
            var normalizecity = 1;  // int? | For responses with no city value in the address section, the next available element in this order - city_district, locality, town, borough, municipality, village, hamlet, quarter, neighbourhood - from the address section will be normalized to city. Defaults to 1 for SDKs.
            var addressdetails = 1;  // int? | Include a breakdown of the address into elements. Defaults to 0. (optional) 
            var viewbox = -132.84908,47.69382,-70.44674,30.82531;  // string | The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. (optional) 
            var bounded = 1;  // int? | Restrict the results to only items contained with the viewbox (optional) 
            var limit = 10;  // int? | Limit the number of returned results. Default is 10. (optional)  (default to 10)
            var acceptLanguage = en;  // string | Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language=native (optional) 
            var countrycodes = US;  // string | Limit search to a list of countries. (optional) 
            var namedetails = 1;  // int? | Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional) 
            var dedupe = 1;  // int? | Sometimes you have several objects in OSM identifying the same place or object in reality. The simplest case is a street being split in many different OSM ways due to different characteristics. Nominatim will attempt to detect such duplicates and only return one match; this is controlled by the dedupe parameter which defaults to 1. Since the limit is, for reasons of efficiency, enforced before and not after de-duplicating, it is possible that de-duplicating leaves you with less results than requested. (optional) 
            var extratags = 0;  // int? | Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional) 

            try
            {
                // Forward Geocoding
                List&lt;Location&gt; result = apiInstance.Search(q, format, normalizecity, addressdetails, viewbox, bounded, limit, acceptLanguage, countrycodes, namedetails, dedupe, extratags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Address to geocode | 
 **format** | **string**| Format to geocode. Only JSON supported for SDKs | 
 **normalizecity** | **int?**| For responses with no city value in the address section, the next available element in this order - city_district, locality, town, borough, municipality, village, hamlet, quarter, neighbourhood - from the address section will be normalized to city. Defaults to 1 for SDKs. | 
 **addressdetails** | **int?**| Include a breakdown of the address into elements. Defaults to 0. | [optional] 
 **viewbox** | **string**| The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. | [optional] 
 **bounded** | **int?**| Restrict the results to only items contained with the viewbox | [optional] 
 **limit** | **int?**| Limit the number of returned results. Default is 10. | [optional] [default to 10]
 **acceptLanguage** | **string**| Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native | [optional] 
 **countrycodes** | **string**| Limit search to a list of countries. | [optional] 
 **namedetails** | **int?**| Include a list of alternative names in the results. These may include language variants, references, operator and brand. | [optional] 
 **dedupe** | **int?**| Sometimes you have several objects in OSM identifying the same place or object in reality. The simplest case is a street being split in many different OSM ways due to different characteristics. Nominatim will attempt to detect such duplicates and only return one match; this is controlled by the dedupe parameter which defaults to 1. Since the limit is, for reasons of efficiency, enforced before and not after de-duplicating, it is possible that de-duplicating leaves you with less results than requested. | [optional] 
 **extratags** | **int?**| Include additional information in the result if available, e.g. wikipedia link, opening hours. | [optional] 

### Return type

[**List<Location>**](Location.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

