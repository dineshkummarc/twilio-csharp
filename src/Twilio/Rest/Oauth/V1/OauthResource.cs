/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Oauth
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Oauth.V1
{
    public class OauthResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchOauthOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/certs";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Oauth,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetches public JWKs </summary>
        /// <param name="options"> Fetch Oauth parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Oauth </returns>
        public static OauthResource Fetch(FetchOauthOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetches public JWKs </summary>
        /// <param name="options"> Fetch Oauth parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Oauth </returns>
        public static async System.Threading.Tasks.Task<OauthResource> FetchAsync(FetchOauthOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetches public JWKs </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Oauth </returns>
        public static OauthResource Fetch(
                                         ITwilioRestClient client = null)
        {
            var options = new FetchOauthOptions(){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetches public JWKs </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Oauth </returns>
        public static async System.Threading.Tasks.Task<OauthResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchOauthOptions(){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a OauthResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> OauthResource object represented by the provided JSON </returns>
        public static OauthResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<OauthResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A collection of certificates </summary> 
        [JsonProperty("keys")]
        public object Keys { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private OauthResource() {

        }
    }
}

