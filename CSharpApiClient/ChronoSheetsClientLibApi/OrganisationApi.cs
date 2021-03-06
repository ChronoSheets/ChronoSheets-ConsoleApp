/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.ChronoSheetsClientLibApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganisationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseOrganisation</returns>
        CSApiResponseOrganisation OrganisationGetOrganisation (string xChronosheetsAuth);

        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseOrganisation</returns>
        ApiResponse<CSApiResponseOrganisation> OrganisationGetOrganisationWithHttpInfo (string xChronosheetsAuth);
        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseUpdateOrganisationResponse</returns>
        CSApiResponseUpdateOrganisationResponse OrganisationUpdateOrganisation (CSUpdateOrganisationRequest request, string xChronosheetsAuth);

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseUpdateOrganisationResponse</returns>
        ApiResponse<CSApiResponseUpdateOrganisationResponse> OrganisationUpdateOrganisationWithHttpInfo (CSUpdateOrganisationRequest request, string xChronosheetsAuth);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseOrganisation</returns>
        System.Threading.Tasks.Task<CSApiResponseOrganisation> OrganisationGetOrganisationAsync (string xChronosheetsAuth);

        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseOrganisation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CSApiResponseOrganisation>> OrganisationGetOrganisationAsyncWithHttpInfo (string xChronosheetsAuth);
        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseUpdateOrganisationResponse</returns>
        System.Threading.Tasks.Task<CSApiResponseUpdateOrganisationResponse> OrganisationUpdateOrganisationAsync (CSUpdateOrganisationRequest request, string xChronosheetsAuth);

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseUpdateOrganisationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CSApiResponseUpdateOrganisationResponse>> OrganisationUpdateOrganisationAsyncWithHttpInfo (CSUpdateOrganisationRequest request, string xChronosheetsAuth);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganisationApi : IOrganisationApi
    {
        private ChronoSheetsAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganisationApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrganisationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChronoSheetsAPI.Client.ExceptionFactory ExceptionFactory
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
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseOrganisation</returns>
        public CSApiResponseOrganisation OrganisationGetOrganisation (string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseOrganisation> localVarResponse = OrganisationGetOrganisationWithHttpInfo(xChronosheetsAuth);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseOrganisation</returns>
        public ApiResponse< CSApiResponseOrganisation > OrganisationGetOrganisationWithHttpInfo (string xChronosheetsAuth)
        {
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling OrganisationApi->OrganisationGetOrganisation");

            var localVarPath = "/api/Organisation/GetOrganisation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrganisationGetOrganisation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseOrganisation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseOrganisation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseOrganisation)));
        }

        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseOrganisation</returns>
        public async System.Threading.Tasks.Task<CSApiResponseOrganisation> OrganisationGetOrganisationAsync (string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseOrganisation> localVarResponse = await OrganisationGetOrganisationAsyncWithHttpInfo(xChronosheetsAuth);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseOrganisation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CSApiResponseOrganisation>> OrganisationGetOrganisationAsyncWithHttpInfo (string xChronosheetsAuth)
        {
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling OrganisationApi->OrganisationGetOrganisation");

            var localVarPath = "/api/Organisation/GetOrganisation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrganisationGetOrganisation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseOrganisation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseOrganisation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseOrganisation)));
        }

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseUpdateOrganisationResponse</returns>
        public CSApiResponseUpdateOrganisationResponse OrganisationUpdateOrganisation (CSUpdateOrganisationRequest request, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseUpdateOrganisationResponse> localVarResponse = OrganisationUpdateOrganisationWithHttpInfo(request, xChronosheetsAuth);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseUpdateOrganisationResponse</returns>
        public ApiResponse< CSApiResponseUpdateOrganisationResponse > OrganisationUpdateOrganisationWithHttpInfo (CSUpdateOrganisationRequest request, string xChronosheetsAuth)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OrganisationApi->OrganisationUpdateOrganisation");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling OrganisationApi->OrganisationUpdateOrganisation");

            var localVarPath = "/api/Organisation/UpdateOrganisation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrganisationUpdateOrganisation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseUpdateOrganisationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseUpdateOrganisationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseUpdateOrganisationResponse)));
        }

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseUpdateOrganisationResponse</returns>
        public async System.Threading.Tasks.Task<CSApiResponseUpdateOrganisationResponse> OrganisationUpdateOrganisationAsync (CSUpdateOrganisationRequest request, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseUpdateOrganisationResponse> localVarResponse = await OrganisationUpdateOrganisationAsyncWithHttpInfo(request, xChronosheetsAuth);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseUpdateOrganisationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CSApiResponseUpdateOrganisationResponse>> OrganisationUpdateOrganisationAsyncWithHttpInfo (CSUpdateOrganisationRequest request, string xChronosheetsAuth)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OrganisationApi->OrganisationUpdateOrganisation");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling OrganisationApi->OrganisationUpdateOrganisation");

            var localVarPath = "/api/Organisation/UpdateOrganisation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrganisationUpdateOrganisation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseUpdateOrganisationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseUpdateOrganisationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseUpdateOrganisationResponse)));
        }

    }
}
