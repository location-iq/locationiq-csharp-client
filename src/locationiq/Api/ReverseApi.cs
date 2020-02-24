/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using locationiq.Client;
using locationiq.Model;

namespace locationiq.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReverseApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Reverse Geocoding
        /// </summary>
        /// <remarks>
        /// Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Location</returns>
        Location Reverse (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int));

        /// <summary>
        /// Reverse Geocoding
        /// </summary>
        /// <remarks>
        /// Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> ReverseWithHttpInfo (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Reverse Geocoding
        /// </summary>
        /// <remarks>
        /// Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> ReverseAsync (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int));

        /// <summary>
        /// Reverse Geocoding
        /// </summary>
        /// <remarks>
        /// Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </remarks>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> ReverseAsyncWithHttpInfo (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReverseApi : IReverseApi
    {
        private locationiq.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReverseApi(String basePath)
        {
            this.Configuration = new locationiq.Client.Configuration { BasePath = basePath };

            ExceptionFactory = locationiq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseApi"/> class
        /// </summary>
        /// <returns></returns>
        public ReverseApi()
        {
            this.Configuration = locationiq.Client.Configuration.Default;

            ExceptionFactory = locationiq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReverseApi(locationiq.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = locationiq.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = locationiq.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public locationiq.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public locationiq.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Reverse Geocoding Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Location</returns>
        public Location Reverse (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int))
        {
             ApiResponse<Location> localVarResponse = ReverseWithHttpInfo(lat, lon, format, normalizecity, addressdetails, acceptLanguage, namedetails, extratags, statecode, showdistance, postaladdress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reverse Geocoding Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> ReverseWithHttpInfo (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int))
        {
            // verify the required parameter 'lat' is set
            if (lat == null)
                throw new ApiException(400, "Missing required parameter 'lat' when calling ReverseApi->Reverse");
            // verify the required parameter 'lon' is set
            if (lon == null)
                throw new ApiException(400, "Missing required parameter 'lon' when calling ReverseApi->Reverse");
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling ReverseApi->Reverse");
            // verify the required parameter 'normalizecity' is set
            if (normalizecity == null)
                throw new ApiException(400, "Missing required parameter 'normalizecity' when calling ReverseApi->Reverse");

            var localVarPath = "/reverse.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lat != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lat", lat)); // query parameter
            if (lon != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lon", lon)); // query parameter
            if (format != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "format", format)); // query parameter
            if (normalizecity != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "normalizecity", normalizecity)); // query parameter
            if (addressdetails != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addressdetails", addressdetails)); // query parameter
            if (acceptLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accept-language", acceptLanguage)); // query parameter
            if (namedetails != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namedetails", namedetails)); // query parameter
            if (extratags != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "extratags", extratags)); // query parameter
            if (statecode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "statecode", statecode)); // query parameter
            if (showdistance != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "showdistance", showdistance)); // query parameter
            if (postaladdress != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "postaladdress", postaladdress)); // query parameter

            // authentication (key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", this.Configuration.GetApiKeyWithPrefix("key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Reverse", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Location>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Location) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Location)));
        }

        /// <summary>
        /// Reverse Geocoding Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> ReverseAsync (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int))
        {
             ApiResponse<Location> localVarResponse = await ReverseAsyncWithHttpInfo(lat, lon, format, normalizecity, addressdetails, acceptLanguage, namedetails, extratags, statecode, showdistance, postaladdress);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reverse Geocoding Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
        /// </summary>
        /// <exception cref="locationiq.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lat">Latitude of the location to generate an address for.</param>
        /// <param name="lon">Longitude of the location to generate an address for.</param>
        /// <param name="format">Format to geocode. Only JSON supported for SDKs</param>
        /// <param name="normalizecity">Normalizes village to city level data to city</param>
        /// <param name="addressdetails">Include a breakdown of the address into elements. Defaults to 1. (optional, default to 1)</param>
        /// <param name="acceptLanguage">Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native (optional)</param>
        /// <param name="namedetails">Include a list of alternative names in the results. These may include language variants, references, operator and brand. (optional)</param>
        /// <param name="extratags">Include additional information in the result if available, e.g. wikipedia link, opening hours. (optional)</param>
        /// <param name="statecode">Adds state or province code when available to the statecode key inside the address element. Currently supported for addresses in the USA, Canada and Australia. Defaults to 0 (optional)</param>
        /// <param name="showdistance">Returns the straight line distance (meters) between the input location and the result&#39;s location. Value is set in the distance key of the response. Defaults to 0 [0,1] (optional)</param>
        /// <param name="postaladdress">Returns address inside the postaladdress key, that is specifically formatted for each country. Currently supported for addresses in Germany. Defaults to 0 [0,1] (optional)</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> ReverseAsyncWithHttpInfo (decimal lat, decimal lon, string format, int normalizecity, int addressdetails = default(int), string acceptLanguage = default(string), int namedetails = default(int), int extratags = default(int), int statecode = default(int), int showdistance = default(int), int postaladdress = default(int))
        {
            // verify the required parameter 'lat' is set
            if (lat == null)
                throw new ApiException(400, "Missing required parameter 'lat' when calling ReverseApi->Reverse");
            // verify the required parameter 'lon' is set
            if (lon == null)
                throw new ApiException(400, "Missing required parameter 'lon' when calling ReverseApi->Reverse");
            // verify the required parameter 'format' is set
            if (format == null)
                throw new ApiException(400, "Missing required parameter 'format' when calling ReverseApi->Reverse");
            // verify the required parameter 'normalizecity' is set
            if (normalizecity == null)
                throw new ApiException(400, "Missing required parameter 'normalizecity' when calling ReverseApi->Reverse");

            var localVarPath = "/reverse.php";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (lat != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lat", lat)); // query parameter
            if (lon != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "lon", lon)); // query parameter
            if (format != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "format", format)); // query parameter
            if (normalizecity != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "normalizecity", normalizecity)); // query parameter
            if (addressdetails != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "addressdetails", addressdetails)); // query parameter
            if (acceptLanguage != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accept-language", acceptLanguage)); // query parameter
            if (namedetails != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namedetails", namedetails)); // query parameter
            if (extratags != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "extratags", extratags)); // query parameter
            if (statecode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "statecode", statecode)); // query parameter
            if (showdistance != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "showdistance", showdistance)); // query parameter
            if (postaladdress != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "postaladdress", postaladdress)); // query parameter

            // authentication (key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", this.Configuration.GetApiKeyWithPrefix("key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Reverse", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Location>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Location) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Location)));
        }

    }
}
