/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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
using Twilio.Types;


namespace Twilio.Rest.Api.V2010.Account
{
    public class TokenResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateTokenOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Tokens.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new token for ICE servers </summary>
        /// <param name="options"> Create Token parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Token </returns>
        public static TokenResource Create(CreateTokenOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new token for ICE servers </summary>
        /// <param name="options"> Create Token parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Token </returns>
        public static async System.Threading.Tasks.Task<TokenResource> CreateAsync(CreateTokenOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new token for ICE servers </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="ttl"> The duration in seconds for which the generated credentials are valid. The default value is 86400 (24 hours). </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Token </returns>
        public static TokenResource Create(
                                          string pathAccountSid = null,
                                          int? ttl = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateTokenOptions(){  PathAccountSid = pathAccountSid, Ttl = ttl };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new token for ICE servers </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="ttl"> The duration in seconds for which the generated credentials are valid. The default value is 86400 (24 hours). </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Token </returns>
        public static async System.Threading.Tasks.Task<TokenResource> CreateAsync(
                                                                                  string pathAccountSid = null,
                                                                                  int? ttl = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateTokenOptions(){  PathAccountSid = pathAccountSid, Ttl = ttl };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a TokenResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TokenResource object represented by the provided JSON </returns>
        public static TokenResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TokenResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the Account that created the resource </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT that the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT that the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> An array representing the ephemeral credentials </summary> 
        [JsonProperty("ice_servers")]
        public List<IceServer> IceServers { get; private set; }

        ///<summary> The temporary password used for authenticating </summary> 
        [JsonProperty("password")]
        public string Password { get; private set; }

        ///<summary> The duration in seconds the credentials are valid </summary> 
        [JsonProperty("ttl")]
        public string Ttl { get; private set; }

        ///<summary> The temporary username that uniquely identifies a Token </summary> 
        [JsonProperty("username")]
        public string Username { get; private set; }



        private TokenResource() {

        }
    }
}

