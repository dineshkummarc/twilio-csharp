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
using Twilio.Types;


namespace Twilio.Rest.Conversations.V1.Service.Configuration
{
    public class WebhookResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class MethodEnum : StringEnum
        {
            private MethodEnum(string value) : base(value) {}
            public MethodEnum() {}
            public static implicit operator MethodEnum(string value)
            {
                return new MethodEnum(value);
            }
            public static readonly MethodEnum Get = new MethodEnum("GET");
            public static readonly MethodEnum Post = new MethodEnum("POST");

        }

        
        private static Request BuildFetchRequest(FetchWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ChatServiceSid}/Configuration/Webhooks";

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

        /// <summary> Fetch a specific service webhook configuration. </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(FetchWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific service webhook configuration. </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(FetchWebhookOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific service webhook configuration. </summary>
        /// <param name="pathChatServiceSid"> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(
                                         string pathChatServiceSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathChatServiceSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific service webhook configuration. </summary>
        /// <param name="pathChatServiceSid"> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(string pathChatServiceSid, ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathChatServiceSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ChatServiceSid}/Configuration/Webhooks";

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

        /// <summary> Update a specific Webhook. </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(UpdateWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Webhook. </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(UpdateWebhookOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Webhook. </summary>
        /// <param name="pathChatServiceSid"> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </param>
        /// <param name="preWebhookUrl"> The absolute url the pre-event webhook request should be sent to. </param>
        /// <param name="postWebhookUrl"> The absolute url the post-event webhook request should be sent to. </param>
        /// <param name="filters"> The list of events that your configured webhook targets will receive. Events not configured here will not fire. Possible values are `onParticipantAdd`, `onParticipantAdded`, `onDeliveryUpdated`, `onConversationUpdated`, `onConversationRemove`, `onParticipantRemove`, `onConversationUpdate`, `onMessageAdd`, `onMessageRemoved`, `onParticipantUpdated`, `onConversationAdded`, `onMessageAdded`, `onConversationAdd`, `onConversationRemoved`, `onParticipantUpdate`, `onMessageRemove`, `onMessageUpdated`, `onParticipantRemoved`, `onMessageUpdate` or `onConversationStateUpdated`. </param>
        /// <param name="method"> The HTTP method to be used when sending a webhook request. One of `GET` or `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(
                                          string pathChatServiceSid,
                                          Uri preWebhookUrl = null,
                                          Uri postWebhookUrl = null,
                                          List<string> filters = null,
                                          string method = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathChatServiceSid){ PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, Filters = filters, Method = method };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Webhook. </summary>
        /// <param name="pathChatServiceSid"> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </param>
        /// <param name="preWebhookUrl"> The absolute url the pre-event webhook request should be sent to. </param>
        /// <param name="postWebhookUrl"> The absolute url the post-event webhook request should be sent to. </param>
        /// <param name="filters"> The list of events that your configured webhook targets will receive. Events not configured here will not fire. Possible values are `onParticipantAdd`, `onParticipantAdded`, `onDeliveryUpdated`, `onConversationUpdated`, `onConversationRemove`, `onParticipantRemove`, `onConversationUpdate`, `onMessageAdd`, `onMessageRemoved`, `onParticipantUpdated`, `onConversationAdded`, `onMessageAdded`, `onConversationAdd`, `onConversationRemoved`, `onParticipantUpdate`, `onMessageRemove`, `onMessageUpdated`, `onParticipantRemoved`, `onMessageUpdate` or `onConversationStateUpdated`. </param>
        /// <param name="method"> The HTTP method to be used when sending a webhook request. One of `GET` or `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(
                                                                              string pathChatServiceSid,
                                                                              Uri preWebhookUrl = null,
                                                                              Uri postWebhookUrl = null,
                                                                              List<string> filters = null,
                                                                              string method = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathChatServiceSid){ PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, Filters = filters, Method = method };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WebhookResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WebhookResource object represented by the provided JSON </returns>
        public static WebhookResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WebhookResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique ID of the Account responsible for this service. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </summary> 
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }

        ///<summary> The absolute url the pre-event webhook request should be sent to. </summary> 
        [JsonProperty("pre_webhook_url")]
        public Uri PreWebhookUrl { get; private set; }

        ///<summary> The absolute url the post-event webhook request should be sent to. </summary> 
        [JsonProperty("post_webhook_url")]
        public Uri PostWebhookUrl { get; private set; }

        ///<summary> The list of events that your configured webhook targets will receive. Events not configured here will not fire. </summary> 
        [JsonProperty("filters")]
        public List<string> Filters { get; private set; }

        
        [JsonProperty("method")]
        public WebhookResource.MethodEnum Method { get; private set; }

        ///<summary> An absolute URL for this webhook. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private WebhookResource() {

        }
    }
}

