# locationiq.Api.BalanceApi

All URIs are relative to *https://eu1.locationiq.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Balance**](BalanceApi.md#balance) | **GET** /balance.php | 


<a name="balance"></a>
# **Balance**
> Balance Balance ()



The Balance API provides a count of request credits left in the user's account for the day. Balance is reset at midnight UTC everyday (00:00 UTC).

### Example
```csharp
using System;
using System.Diagnostics;
using locationiq.Api;
using locationiq.Client;
using locationiq.Model;

namespace Example
{
    public class BalanceExample
    {
        public void main()
        {
            // Configure API key authorization: key
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new BalanceApi();

            try
            {
                Balance result = apiInstance.Balance();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.Balance: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Balance**](Balance.md)

### Authorization

[key](../README.md#key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

