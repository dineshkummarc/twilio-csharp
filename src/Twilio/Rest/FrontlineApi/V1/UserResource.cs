/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Frontline
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


namespace Twilio.Rest.FrontlineApi.V1
{
    public class UserResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StateTypeEnum : StringEnum
        {
            private StateTypeEnum(string value) : base(value) {}
            public StateTypeEnum() {}
            public static implicit operator StateTypeEnum(string value)
            {
                return new StateTypeEnum(value);
            }
            public static readonly StateTypeEnum Active = new StateTypeEnum("active");
            public static readonly StateTypeEnum Deactivated = new StateTypeEnum("deactivated");

        }

        
        private static Request BuildFetchRequest(FetchUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.FrontlineApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a frontline user </summary>
        /// <param name="options"> Fetch User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Fetch(FetchUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a frontline user </summary>
        /// <param name="options"> Fetch User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> FetchAsync(FetchUserOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a frontline user </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchUserOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a frontline user </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchUserOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FrontlineApi,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an existing frontline user </summary>
        /// <param name="options"> Update User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Update(UpdateUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing frontline user </summary>
        /// <param name="options"> Update User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<UserResource> UpdateAsync(UpdateUserOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an existing frontline user </summary>
        /// <param name="pathSid"> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the User. </param>
        /// <param name="avatar"> The avatar URL which will be shown in Frontline application. </param>
        /// <param name="state">  </param>
        /// <param name="isAvailable"> Whether the User is available for new conversations. Set to `false` to prevent User from receiving new inbound conversations if you are using [Pool Routing](https://www.twilio.com/docs/frontline/handle-incoming-conversations#3-pool-routing). </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string avatar = null,
                                          UserResource.StateTypeEnum state = null,
                                          bool? isAvailable = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateUserOptions(pathSid){ FriendlyName = friendlyName, Avatar = avatar, State = state, IsAvailable = isAvailable };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an existing frontline user </summary>
        /// <param name="pathSid"> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the User. </param>
        /// <param name="avatar"> The avatar URL which will be shown in Frontline application. </param>
        /// <param name="state">  </param>
        /// <param name="isAvailable"> Whether the User is available for new conversations. Set to `false` to prevent User from receiving new inbound conversations if you are using [Pool Routing](https://www.twilio.com/docs/frontline/handle-incoming-conversations#3-pool-routing). </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string avatar = null,
                                                                              UserResource.StateTypeEnum state = null,
                                                                              bool? isAvailable = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateUserOptions(pathSid){ FriendlyName = friendlyName, Avatar = avatar, State = state, IsAvailable = isAvailable };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a UserResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserResource object represented by the provided JSON </returns>
        public static UserResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The string that identifies the resource's User </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The string that you assigned to describe the User </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The avatar URL which will be shown in Frontline application </summary> 
        [JsonProperty("avatar")]
        public string Avatar { get; private set; }

        
        [JsonProperty("state")]
        public UserResource.StateTypeEnum State { get; private set; }

        ///<summary> Whether the User is available for new conversations </summary> 
        [JsonProperty("is_available")]
        public bool? IsAvailable { get; private set; }

        ///<summary> An absolute URL for this user. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private UserResource() {

        }
    }
}

