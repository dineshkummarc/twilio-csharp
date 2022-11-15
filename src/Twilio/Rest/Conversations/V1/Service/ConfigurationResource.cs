/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
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



namespace Twilio.Rest.Conversations.V1.Service
{
    public class ConfigurationResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchConfigurationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ChatServiceSid}/Configuration";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{"+"ChatServiceSid"+"}", PathChatServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the configuration of a conversation service </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(FetchConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch the configuration of a conversation service </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(FetchConfigurationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch the configuration of a conversation service </summary>
        /// <param name="pathChatServiceSid"> The SID of the Service configuration resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(
                                         string pathChatServiceSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(pathChatServiceSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch the configuration of a conversation service </summary>
        /// <param name="pathChatServiceSid"> The SID of the Service configuration resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(string pathChatServiceSid, ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(pathChatServiceSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateConfigurationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ChatServiceSid}/Configuration";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{"+"ChatServiceSid"+"}", PathChatServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update configuration settings of a conversation service </summary>
        /// <param name="options"> Update Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Update(UpdateConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update configuration settings of a conversation service </summary>
        /// <param name="options"> Update Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<ConfigurationResource> UpdateAsync(UpdateConfigurationOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update configuration settings of a conversation service </summary>
        /// <param name="pathChatServiceSid"> The SID of the Service configuration resource to update. </param>
        /// <param name="defaultConversationCreatorRoleSid"> The conversation-level role assigned to a conversation creator when they join a new conversation. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="defaultConversationRoleSid"> The conversation-level role assigned to users when they are added to a conversation. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="defaultChatServiceRoleSid"> The service-level role assigned to users when they are added to the service. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="reachabilityEnabled"> Whether the [Reachability Indicator](https://www.twilio.com/docs/chat/reachability-indicator) is enabled for this Conversations Service. The default is `false`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Update(
                                          string pathChatServiceSid,
                                          string defaultConversationCreatorRoleSid = null,
                                          string defaultConversationRoleSid = null,
                                          string defaultChatServiceRoleSid = null,
                                          bool? reachabilityEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateConfigurationOptions(pathChatServiceSid){ DefaultConversationCreatorRoleSid = defaultConversationCreatorRoleSid, DefaultConversationRoleSid = defaultConversationRoleSid, DefaultChatServiceRoleSid = defaultChatServiceRoleSid, ReachabilityEnabled = reachabilityEnabled };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update configuration settings of a conversation service </summary>
        /// <param name="pathChatServiceSid"> The SID of the Service configuration resource to update. </param>
        /// <param name="defaultConversationCreatorRoleSid"> The conversation-level role assigned to a conversation creator when they join a new conversation. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="defaultConversationRoleSid"> The conversation-level role assigned to users when they are added to a conversation. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="defaultChatServiceRoleSid"> The service-level role assigned to users when they are added to the service. See the [Conversation Role](https://www.twilio.com/docs/conversations/api/role-resource) for more info about roles. </param>
        /// <param name="reachabilityEnabled"> Whether the [Reachability Indicator](https://www.twilio.com/docs/chat/reachability-indicator) is enabled for this Conversations Service. The default is `false`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> UpdateAsync(
                                                                              string pathChatServiceSid,
                                                                              string defaultConversationCreatorRoleSid = null,
                                                                              string defaultConversationRoleSid = null,
                                                                              string defaultChatServiceRoleSid = null,
                                                                              bool? reachabilityEnabled = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateConfigurationOptions(pathChatServiceSid){ DefaultConversationCreatorRoleSid = defaultConversationCreatorRoleSid, DefaultConversationRoleSid = defaultConversationRoleSid, DefaultChatServiceRoleSid = defaultChatServiceRoleSid, ReachabilityEnabled = reachabilityEnabled };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ConfigurationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConfigurationResource object represented by the provided JSON </returns>
        public static ConfigurationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConfigurationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }

        ///<summary> The role assigned to a conversation creator user when they join a new conversation </summary> 
        [JsonProperty("default_conversation_creator_role_sid")]
        public string DefaultConversationCreatorRoleSid { get; private set; }

        ///<summary> The role assigned to users when they are added to a conversation </summary> 
        [JsonProperty("default_conversation_role_sid")]
        public string DefaultConversationRoleSid { get; private set; }

        ///<summary> The service role assigned to users when they are added to the service </summary> 
        [JsonProperty("default_chat_service_role_sid")]
        public string DefaultChatServiceRoleSid { get; private set; }

        ///<summary> An absolute URL for this service configuration. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Absolute URL to access the push notifications configuration of this service. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> Whether the Reachability Indicator feature is enabled for this Conversations Service </summary> 
        [JsonProperty("reachability_enabled")]
        public bool? ReachabilityEnabled { get; private set; }



        private ConfigurationResource() {

        }
    }
}

