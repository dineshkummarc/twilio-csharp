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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Conversations.V1.Service
{

    /// <summary> Create a new conversation in your service </summary>
    public class CreateConversationOptions : IOptions<ConversationResource>
    {
        
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        public string UniqueName { get; set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </summary> 
        public string Attributes { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) this conversation belongs to. </summary> 
        public string MessagingServiceSid { get; set; }

        ///<summary> The date that this resource was created. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date that this resource was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        
        public ConversationResource.StateEnum State { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string TimersInactive { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string TimersClosed { get; set; }


        /// <summary> Construct a new CreateServiceConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </param>
        public CreateConversationOptions(string pathChatServiceSid)
        {
            PathChatServiceSid = pathChatServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (TimersInactive != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Inactive", TimersInactive));
            }
            if (TimersClosed != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Closed", TimersClosed));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }
    /// <summary> Remove a conversation from your service </summary>
    public class DeleteConversationOptions : IOptions<ConversationResource>
    {
        
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }



        /// <summary> Construct a new DeleteServiceConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public DeleteConversationOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


    /// <summary> Fetch a conversation from your service </summary>
    public class FetchConversationOptions : IOptions<ConversationResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public FetchConversationOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of conversations in your service </summary>
    public class ReadConversationOptions : ReadOptions<ConversationResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> Start date or time in ISO8601 format for filtering list of Conversations. If a date is provided, the start time of the date is used (YYYY-MM-DDT00:00:00Z). Can be combined with other filters. </summary> 
        public string StartDate { get; set; }

        ///<summary> End date or time in ISO8601 format for filtering list of Conversations. If a date is provided, the end time of the date is used (YYYY-MM-DDT23:59:59Z). Can be combined with other filters. </summary> 
        public string EndDate { get; set; }

        ///<summary> State for sorting and filtering list of Conversations. Can be `active`, `inactive` or `closed` </summary> 
        public ConversationResource.StateEnum State { get; set; }



        /// <summary> Construct a new ListServiceConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </param>
        public ReadConversationOptions(string pathChatServiceSid)
        {
            PathChatServiceSid = pathChatServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update an existing conversation in your service </summary>
    public class UpdateConversationOptions : IOptions<ConversationResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The date that this resource was created. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date that this resource was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </summary> 
        public string Attributes { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) this conversation belongs to. </summary> 
        public string MessagingServiceSid { get; set; }

        
        public ConversationResource.StateEnum State { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string TimersInactive { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string TimersClosed { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        public string UniqueName { get; set; }



        /// <summary> Construct a new UpdateServiceConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Conversation resource is associated with. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. Can also be the `unique_name` of the Conversation. </param>
        public UpdateConversationOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (TimersInactive != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Inactive", TimersInactive));
            }
            if (TimersClosed != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Closed", TimersClosed));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


}

