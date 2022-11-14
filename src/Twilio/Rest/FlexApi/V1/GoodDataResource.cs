/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// GoodDataResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.FlexApi.V1
{

    public class GoodDataResource : Resource
    {
        private static Request BuildCreateRequest(CreateGoodDataOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/Accounts/GoodData",
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary>
        /// To create a GoodData Session id to access GoodData dashboards
        /// </summary>
        /// <param name="options"> Create GoodData parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of GoodData </returns>
        public static GoodDataResource Create(CreateGoodDataOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// To create a GoodData Session id to access GoodData dashboards
        /// </summary>
        /// <param name="options"> Create GoodData parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of GoodData </returns>
        public static async System.Threading.Tasks.Task<GoodDataResource> CreateAsync(CreateGoodDataOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// To create a GoodData Session id to access GoodData dashboards
        /// </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of GoodData </returns>
        public static GoodDataResource Create(string token = null, ITwilioRestClient client = null)
        {
            var options = new CreateGoodDataOptions(){Token = token};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// To create a GoodData Session id to access GoodData dashboards
        /// </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of GoodData </returns>
        public static async System.Threading.Tasks.Task<GoodDataResource> CreateAsync(string token = null,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new CreateGoodDataOptions(){Token = token};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a GoodDataResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> GoodDataResource object represented by the provided JSON </returns>
        public static GoodDataResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<GoodDataResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Unique workspace ID in gooddata
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; private set; }
        /// <summary>
        /// The session expiry date and time
        /// </summary>
        [JsonProperty("session_expiry")]
        public string SessionExpiry { get; private set; }
        /// <summary>
        /// Unique session ID
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private GoodDataResource()
        {

        }
    }

}