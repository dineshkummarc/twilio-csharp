/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Chat
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
using System.Linq;



namespace Twilio.Rest.Chat.V2.Service.Channel
{

    /// <summary> create </summary>
    public class CreateMemberOptions : IOptions<MemberResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Member resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Member resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/chat/rest/service-resource). See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more info. </summary> 
        public string Identity { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The SID of the [Role](https://www.twilio.com/docs/chat/rest/role-resource) to assign to the member. The default roles are those specified on the [Service](https://www.twilio.com/docs/chat/rest/service-resource). </summary> 
        public string RoleSid { get; set; }

        ///<summary> The index of the last [Message](https://www.twilio.com/docs/chat/rest/message-resource) in the [Channel](https://www.twilio.com/docs/chat/channels) that the Member has read. This parameter should only be used when recreating a Member from a backup/separate source. </summary> 
        public int? LastConsumedMessageIndex { get; set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) timestamp of the last [Message](https://www.twilio.com/docs/chat/rest/message-resource) read event for the Member within the [Channel](https://www.twilio.com/docs/chat/channels). </summary> 
        public DateTime? LastConsumptionTimestamp { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was created. The default value is the current time set by the Chat service.  Note that this parameter should only be used when a Member is being recreated from a backup/separate source. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was last updated. The default value is `null`. Note that this parameter should only be used when a Member is being recreated from a backup/separate source and where a Member was previously updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> A valid JSON string that contains application-specific data. </summary> 
        public string Attributes { get; set; }


        /// <summary> Construct a new CreateMemberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Member resource under. </param>        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Member resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/chat/rest/service-resource). See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more info. </param>
        public CreateMemberOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid));
            }
            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }
            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
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
    /// <summary> delete </summary>
    public class DeleteMemberOptions : IOptions<MemberResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Member resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The SID of the Member resource to delete. This value can be either the Member's `sid` or its `identity` value. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }



        /// <summary> Construct a new DeleteMemberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Member resource from. </param>        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>        /// <param name="pathSid"> The SID of the Member resource to delete. This value can be either the Member's `sid` or its `identity` value. </param>
        public DeleteMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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


    /// <summary> fetch </summary>
    public class FetchMemberOptions : IOptions<MemberResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Member resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The SID of the Member resource to fetch. This value can be either the Member's `sid` or its `identity` value. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchMemberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Member resource from. </param>        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>        /// <param name="pathSid"> The SID of the Member resource to fetch. This value can be either the Member's `sid` or its `identity` value. </param>
        public FetchMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Member resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the Member resources to read. See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more details. </summary> 
        public List<string> Identity { get; set; }



        /// <summary> Construct a new ListMemberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Member resources from. </param>        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        public ReadMemberOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.AddRange(Identity.Select(Identity => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateMemberOptions : IOptions<MemberResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Member resource in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to update belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The SID of the Member resource to update. This value can be either the Member's `sid` or its `identity` value. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public MemberResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The SID of the [Role](https://www.twilio.com/docs/chat/rest/role-resource) to assign to the member. The default roles are those specified on the [Service](https://www.twilio.com/docs/chat/rest/service-resource). </summary> 
        public string RoleSid { get; set; }

        ///<summary> The index of the last [Message](https://www.twilio.com/docs/chat/rest/message-resource) that the Member has read within the [Channel](https://www.twilio.com/docs/chat/channels). </summary> 
        public int? LastConsumedMessageIndex { get; set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) timestamp of the last [Message](https://www.twilio.com/docs/chat/rest/message-resource) read event for the Member within the [Channel](https://www.twilio.com/docs/chat/channels). </summary> 
        public DateTime? LastConsumptionTimestamp { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was created. The default value is the current time set by the Chat service.  Note that this parameter should only be used when a Member is being recreated from a backup/separate source. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> A valid JSON string that contains application-specific data. </summary> 
        public string Attributes { get; set; }



        /// <summary> Construct a new UpdateMemberOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Member resource in. </param>        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Member resource to update belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>        /// <param name="pathSid"> The SID of the Member resource to update. This value can be either the Member's `sid` or its `identity` value. </param>
        public UpdateMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid));
            }
            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }
            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
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

