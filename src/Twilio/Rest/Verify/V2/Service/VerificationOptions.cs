/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service
{

    /// <summary> Create a new Verification using a Service </summary>
    public class CreateVerificationOptions : IOptions<VerificationResource>
    {
        
        ///<summary> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The phone number or [email](https://www.twilio.com/docs/verify/email) to verify. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </summary> 
        public string To { get; }

        ///<summary> The verification method to use. One of: [`email`](https://www.twilio.com/docs/verify/email), `sms`, `whatsapp`, `call`, `sna` or `auto`. </summary> 
        public string Channel { get; }

        ///<summary> A custom user defined friendly name that overwrites the existing one in the verification message </summary> 
        public string CustomFriendlyName { get; set; }

        ///<summary> The text of a custom message to use for the verification. </summary> 
        public string CustomMessage { get; set; }

        ///<summary> The digits to send after a phone call is answered, for example, to dial an extension. For more information, see the Programmable Voice documentation of [sendDigits](https://www.twilio.com/docs/voice/twiml/number#attributes-sendDigits). </summary> 
        public string SendDigits { get; set; }

        ///<summary> Locale will automatically resolve based on phone number country code for SMS, WhatsApp, and call channel verifications. It will fallback to English or the template’s default translation if the selected translation is not available. This parameter will override the automatic locale resolution. [See supported languages and more information here](https://www.twilio.com/docs/verify/supported-languages). </summary> 
        public string Locale { get; set; }

        ///<summary> A pre-generated code to use for verification. The code can be between 4 and 10 characters, inclusive. </summary> 
        public string CustomCode { get; set; }

        ///<summary> The amount of the associated PSD2 compliant transaction. Requires the PSD2 Service flag enabled. </summary> 
        public string Amount { get; set; }

        ///<summary> The payee of the associated PSD2 compliant transaction. Requires the PSD2 Service flag enabled. </summary> 
        public string Payee { get; set; }

        ///<summary> The custom key-value pairs of Programmable Rate Limits. Keys correspond to `unique_name` fields defined when [creating your Rate Limit](https://www.twilio.com/docs/verify/api/service-rate-limits). Associated value pairs represent values in the request that you are rate limiting on. You may include multiple Rate Limit values in each request. </summary> 
        public object RateLimits { get; set; }

        ///<summary> [`email`](https://www.twilio.com/docs/verify/email) channel configuration in json format. The fields 'from' and 'from_name' are optional but if included the 'from' field must have a valid email address. </summary> 
        public object ChannelConfiguration { get; set; }

        ///<summary> Your [App Hash](https://developers.google.com/identity/sms-retriever/verify#computing_your_apps_hash_string) to be appended at the end of your verification SMS body. Applies only to SMS. Example SMS body: `<#> Your AppName verification code is: 1234 He42w354ol9`. </summary> 
        public string AppHash { get; set; }

        ///<summary> The message [template](https://www.twilio.com/docs/verify/api/templates). If provided, will override the default template for the Service. SMS and Voice channels only. </summary> 
        public string TemplateSid { get; set; }

        ///<summary> A stringified JSON object in which the keys are the template's special variables and the values are the variables substitutions. </summary> 
        public string TemplateCustomSubstitutions { get; set; }

        ///<summary> Strongly encouraged if using the auto channel. The IP address of the client's device. If provided, it has to be a valid IPv4 or IPv6 address. </summary> 
        public string DeviceIp { get; set; }

        
        public VerificationResource.RiskCheckEnum RiskCheck { get; set; }


        /// <summary> Construct a new CreateVerificationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to create the resource under. </param>
        /// <param name="to"> The phone number or [email](https://www.twilio.com/docs/verify/email) to verify. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </param>
        /// <param name="channel"> The verification method to use. One of: [`email`](https://www.twilio.com/docs/verify/email), `sms`, `whatsapp`, `call`, `sna` or `auto`. </param>
        public CreateVerificationOptions(string pathServiceSid, string to, string channel)
        {
            PathServiceSid = pathServiceSid;
            To = to;
            Channel = channel;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }
            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Channel));
            }
            if (CustomFriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomFriendlyName", CustomFriendlyName));
            }
            if (CustomMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomMessage", CustomMessage));
            }
            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }
            if (Locale != null)
            {
                p.Add(new KeyValuePair<string, string>("Locale", Locale));
            }
            if (CustomCode != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomCode", CustomCode));
            }
            if (Amount != null)
            {
                p.Add(new KeyValuePair<string, string>("Amount", Amount));
            }
            if (Payee != null)
            {
                p.Add(new KeyValuePair<string, string>("Payee", Payee));
            }
            if (RateLimits != null)
            {
                p.Add(new KeyValuePair<string, string>("RateLimits", Serializers.JsonObject(RateLimits)));
            }
            if (ChannelConfiguration != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelConfiguration", Serializers.JsonObject(ChannelConfiguration)));
            }
            if (AppHash != null)
            {
                p.Add(new KeyValuePair<string, string>("AppHash", AppHash));
            }
            if (TemplateSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TemplateSid", TemplateSid));
            }
            if (TemplateCustomSubstitutions != null)
            {
                p.Add(new KeyValuePair<string, string>("TemplateCustomSubstitutions", TemplateCustomSubstitutions));
            }
            if (DeviceIp != null)
            {
                p.Add(new KeyValuePair<string, string>("DeviceIp", DeviceIp));
            }
            if (RiskCheck != null)
            {
                p.Add(new KeyValuePair<string, string>("RiskCheck", RiskCheck.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Fetch a specific Verification </summary>
    public class FetchVerificationOptions : IOptions<VerificationResource>
    {
    
        ///<summary> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to fetch the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Verification resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchVerificationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to fetch the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Verification resource to fetch. </param>
        public FetchVerificationOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Update a Verification status </summary>
    public class UpdateVerificationOptions : IOptions<VerificationResource>
    {
    
        ///<summary> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to update the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Verification resource to update. </summary> 
        public string PathSid { get; }

        
        public VerificationResource.StatusEnum Status { get; }



        /// <summary> Construct a new UpdateVerificationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the verification [Service](https://www.twilio.com/docs/verify/api/service) to update the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Verification resource to update. </param>
        /// <param name="status">  </param>
        public UpdateVerificationOptions(string pathServiceSid, string pathSid, VerificationResource.StatusEnum status)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Status = status;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

