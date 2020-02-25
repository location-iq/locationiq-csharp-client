# locationiq.Api.NearestApi

All URIs are relative to *https://eu1.locationiq.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Nearest**](NearestApi.md#nearest) | **GET** /nearest/driving/{coordinates} | Nearest Service



## Nearest

> DirectionsNearest Nearest (string coordinates, string generateHints = null, string exclude = null, string bearings = null, string radiuses = null, string approaches = null, int number = null)

Nearest Service

Snaps a coordinate to the street network and returns the nearest n matches. Where coordinates only supports a single {longitude},{latitude} entry.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using locationiq.Api;
using locationiq.Client;
using locationiq.Model;

namespace Example
{
    public class NearestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://eu1.locationiq.com/v1";
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new NearestApi(Configuration.Default);
            var coordinates = "-0.16102,51.523854";  // string | String of format {longitude},{latitude};{longitude},{latitude}[;{longitude},{latitude} ...] or polyline({polyline}) or polyline6({polyline6}). polyline follows Google's polyline format with precision 5
            var generateHints = "false";  // string | Adds a Hint to the response which can be used in subsequent requests, see hints parameter. Input Value - true (default), false Format - Base64 String (optional) 
            var exclude = "toll";  // string | Additive list of classes to avoid, order does not matter. input Value - {class}[,{class}] Format - A class name determined by the profile or none. (optional) 
            var bearings = "10,20";  // string | Limits the search to segments with given bearing in degrees towards true north in clockwise direction. List of positive integer pairs separated by semi-colon and bearings array should be equal to length of coordinate array. Input Value :- {bearing};{bearing}[;{bearing} ...] Bearing follows the following format : bearing {value},{range} integer 0 .. 360,integer 0 .. 180 (optional) 
            var radiuses = "1000";  // string | Limits the search to given radius in meters Radiuses array length should be same as coordinates array, eaach value separated by semi-colon. Input Value - {radius};{radius}[;{radius} ...] Radius has following format :- double >= 0 or unlimited (default) (optional) 
            var approaches = "curb";  // string | Keep waypoints on curb side. Input Value - {approach};{approach}[;{approach} ...] Format - curb or unrestricted (default) (optional) 
            var number = 3;  // int | Number of nearest segments that should be returned. [ integer >= 1 (default 1) ] (optional) 

            try
            {
                // Nearest Service
                DirectionsNearest result = apiInstance.Nearest(coordinates, generateHints, exclude, bearings, radiuses, approaches, number);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NearestApi.Nearest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **coordinates** | **string**| String of format {longitude},{latitude};{longitude},{latitude}[;{longitude},{latitude} ...] or polyline({polyline}) or polyline6({polyline6}). polyline follows Google&#39;s polyline format with precision 5 | 
 **generateHints** | **string**| Adds a Hint to the response which can be used in subsequent requests, see hints parameter. Input Value - true (default), false Format - Base64 String | [optional] 
 **exclude** | **string**| Additive list of classes to avoid, order does not matter. input Value - {class}[,{class}] Format - A class name determined by the profile or none. | [optional] 
 **bearings** | **string**| Limits the search to segments with given bearing in degrees towards true north in clockwise direction. List of positive integer pairs separated by semi-colon and bearings array should be equal to length of coordinate array. Input Value :- {bearing};{bearing}[;{bearing} ...] Bearing follows the following format : bearing {value},{range} integer 0 .. 360,integer 0 .. 180 | [optional] 
 **radiuses** | **string**| Limits the search to given radius in meters Radiuses array length should be same as coordinates array, eaach value separated by semi-colon. Input Value - {radius};{radius}[;{radius} ...] Radius has following format :- double &gt;&#x3D; 0 or unlimited (default) | [optional] 
 **approaches** | **string**| Keep waypoints on curb side. Input Value - {approach};{approach}[;{approach} ...] Format - curb or unrestricted (default) | [optional] 
 **number** | **int**| Number of nearest segments that should be returned. [ integer &gt;&#x3D; 1 (default 1) ] | [optional] 

### Return type

[**DirectionsNearest**](DirectionsNearest.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | The request has been made from an unauthorized domain. |  -  |
| **404** | No location or places were found for the given input |  -  |
| **429** | Request exceeded the rate-limits set on your account |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

