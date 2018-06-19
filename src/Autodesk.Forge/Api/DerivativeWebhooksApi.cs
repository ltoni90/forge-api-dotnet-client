/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Newtonsoft.Json.Linq;
using Autodesk.Forge.Client;
using Autodesk.Forge.Model;

namespace Autodesk.Forge
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDerivativeWebhooksApi : IApiAccessor
    {
        /// <summary>
        /// Creates a webhook for the given model derivative event.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to create hool for.</param>
        /// <param name="callbackUrl">The callback URL the hook will call when triggered.</param>
        /// <param name="workflow">The workflow ID of a group of jobs.</param>
        /// <returns>Task of</returns>
        System.Threading.Tasks.Task<dynamic> CreateHookAsync(DerivativeWebhookEvent eventType, string callbackUrl, string workflow);
        /// <summary>
        /// Creates a webhook for the given model derivative event.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to create hool for.</param>
        /// <param name="callbackUrl">The callback URL the hook will call when triggered.</param>
        /// <param name="workflow">The workflow ID of a group of jobs.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<dynamic> CreateHookAsyncWithHttpInfo(DerivativeWebhookEvent eventType, string callbackUrl, string workflow);
        /// <summary>
        /// Returns hooks for model derivate events.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to get hooks for. </param>
        /// <param name="acceptEncoding">If specified with &#x60;gzip&#x60; or &#x60;*&#x60;, content will be compressed and returned in a GZIP format.  (optional)</param>
        /// <returns>Task of webhooks</returns>
        System.Threading.Tasks.Task<dynamic> GetHooksAsync(DerivativeWebhookEvent eventType, string acceptEncoding = null);
        /// <summary>
        /// Returns hooks for model derivate events.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to get hooks for. </param>
        /// <param name="acceptEncoding">If specified with &#x60;gzip&#x60; or &#x60;*&#x60;, content will be compressed and returned in a GZIP format.  (optional)</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        System.Threading.Tasks.Task<ApiResponse<dynamic>> GetHooksAsyncWithHttpInfo(DerivativeWebhookEvent eventType, string acceptEncoding = null);
        /// <summary>
        /// Deletes the webhook with the given GUID for the given model derivative event.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to delete hook for.</param>
        /// <param name="hookId">The GUID of the hook to delete.</param>
        /// <returns>Task of webhooks</returns>
        System.Threading.Tasks.Task DeleteHookAsync(DerivativeWebhookEvent eventType, Guid hookId);
        /// <summary>
        /// Deletes the webhook with the given GUID for the given model derivative event.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to delete hook for.</param>
        /// <param name="hookId">The GUID of the hook to delete.</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        System.Threading.Tasks.Task<ApiResponse<dynamic>> DeleteHookAsyncWithHttpInfo(DerivativeWebhookEvent eventType, Guid hookId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DerivativeWebhooksApi : IDerivativeWebhooksApi
    {
        private Autodesk.Forge.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivativeWebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DerivativeWebhooksApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DerivativeWebhooksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DerivativeWebhooksApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Autodesk.Forge.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a webhook for the given modelderivative event.
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to create hool for.</param>
        /// <param name="callbackUrl">The callback URL the hook will call when triggered.</param>
        /// <param name="workflow">The workflow ID of a group of jobs.</param>
        /// <returns>Task of</returns>
        public async System.Threading.Tasks.Task<dynamic> CreateHookAsync(DerivativeWebhookEvent eventType, string callbackUrl, string workflow)
        {
            ApiResponse<dynamic> localVarResponse = await CreateHookAsyncWithHttpInfo(eventType, callbackUrl, workflow);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a webhook for the given modelderivative event.
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to create hool for.</param>
        /// <param name="callbackUrl">The callback URL the hook will call when triggered.</param>
        /// <param name="workflow">The workflow ID of a group of jobs.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<dynamic> CreateHookAsyncWithHttpInfo(DerivativeWebhookEvent eventType, string callbackUrl, string workflow)
        {
            // verify the required parameter 'urn' is set
            if (callbackUrl == null)
                throw new ApiException(400, "Missing required parameter 'callbackUrl' when calling DerivativeWebhooksApi->CreateHookAsync");

            // verify the required parameter 'workflow' is set
            if (workflow == null)
                throw new ApiException(400, "Missing required parameter 'workflow' when calling DerivativeWebhooksApi->CreateHookAsync");

            var enumAsString = EventEnumToString(eventType);
            var localVarPath = "/webhooks/v1/systems/derivative/events/" + enumAsString + "/hooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json",
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            var postBodyObject = CreateWebhookPostObject(callbackUrl, workflow);
            localVarPostBody = Configuration.ApiClient.Serialize(postBodyObject);

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_application) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateHook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Job*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Job)*/ localVarResponse);

        }

        /// <summary>
        /// Returns hooks for model derivate events.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to get hooks for. </param>
        /// <param name="acceptEncoding">If specified with &#x60;gzip&#x60; or &#x60;*&#x60;, content will be compressed and returned in a GZIP format.  (optional)</param>
        /// <returns>Task of webhooks</returns>
        public async System.Threading.Tasks.Task<dynamic> GetHooksAsync(DerivativeWebhookEvent eventType, string acceptEncoding = null)
        {
            ApiResponse<dynamic> localVarResponse = await GetHooksAsyncWithHttpInfo(eventType, acceptEncoding);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns hooks for model derivate events.
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to get hooks for. </param>
        /// <param name="acceptEncoding">If specified with &#x60;gzip&#x60; or &#x60;*&#x60;, content will be compressed and returned in a GZIP format.  (optional)</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<dynamic>> GetHooksAsyncWithHttpInfo(DerivativeWebhookEvent eventType, string acceptEncoding = null)
        {
            var enumAsString = EventEnumToString(eventType);
            var localVarPath = "/webhooks/v1/systems/derivative/events/" + enumAsString + "/hooks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json",
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (acceptEncoding != null) localVarHeaderParams.Add("Accept-Encoding", Configuration.ApiClient.ParameterToString(acceptEncoding)); // header parameter

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_application) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHooks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Manifest*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Manifest)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonApiCollection)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes the webhook with the given GUID for the given model derivative event.
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to delete hook for.</param>
        /// <param name="hookId">The GUID of the hook to delete.</param>
        /// <returns>Task of webhooks</returns>
        public async System.Threading.Tasks.Task DeleteHookAsync(DerivativeWebhookEvent eventType, Guid hookId)
        {
            ApiResponse<dynamic> localVarResponse = await DeleteHookAsyncWithHttpInfo(eventType, hookId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes the webhook with the given GUID for the given model derivative event.
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventType">The webhook event type to delete hook for.</param>
        /// <param name="hookId">The GUID of the hook to delete.</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<dynamic>> DeleteHookAsyncWithHttpInfo(DerivativeWebhookEvent eventType, Guid hookId)
        {
            // verify the required parameter 'hookId' is set
            if (hookId == Guid.Empty)
                throw new ApiException(400, "Missing required parameter 'hookId' when calling DerivativeWebhooksApi->DeleteHookAsync");

            var enumAsString = EventEnumToString(eventType);
            var localVarPath = "/webhooks/v1/systems/derivative/events/" + enumAsString + "/hooks/" + hookId.ToString("D");
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json",
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_application) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteHook", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the event type on the format needed by the REST request.
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when passing unimplemented type.</exception>
        /// <param name="webhookEvent">The webhook event type to get as string for REST request.</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        private string EventEnumToString(DerivativeWebhookEvent webhookEvent)
        {
            switch (webhookEvent)
            {
                case DerivativeWebhookEvent.ExtractionFinished:
                    return "extraction.finished";
                default:
                    throw new ApiException(400, "Webhook event type {webhookEvent} is not implemented.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a webhook object that can be passed to the REST request.
        /// </remarks>
        /// <param name="callbackUrl">The callback URL the hook will call when triggered.</param>
        /// <param name="workflow">The workflow ID of a group of jobs.</param>
        /// <returns>Task of ApiResponse (webhooks)</returns>
        private dynamic CreateWebhookPostObject(string callbackUrl, string workflow)
        {
            dynamic postObject = new System.Dynamic.ExpandoObject();
            postObject.callbackUrl = callbackUrl;
            postObject.scope = new System.Dynamic.ExpandoObject();
            postObject.scope.workflow = workflow;
            return postObject;
        }
    }
}