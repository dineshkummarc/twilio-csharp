/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
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


namespace Twilio.Rest.Supersim.V1
{
    public class SettingsUpdateResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Scheduled = new StatusEnum("scheduled");
            public static readonly StatusEnum InProgress = new StatusEnum("in-progress");
            public static readonly StatusEnum Successful = new StatusEnum("successful");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }

        
        private static Request BuildReadRequest(ReadSettingsUpdateOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/SettingsUpdates";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Settings Updates. </summary>
        /// <param name="options"> Read SettingsUpdate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SettingsUpdate </returns>
        public static ResourceSet<SettingsUpdateResource> Read(ReadSettingsUpdateOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SettingsUpdateResource>.FromJson("settings_updates", response.Content);
            return new ResourceSet<SettingsUpdateResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Settings Updates. </summary>
        /// <param name="options"> Read SettingsUpdate parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SettingsUpdate </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SettingsUpdateResource>> ReadAsync(ReadSettingsUpdateOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SettingsUpdateResource>.FromJson("settings_updates", response.Content);
            return new ResourceSet<SettingsUpdateResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Settings Updates. </summary>
        /// <param name="sim"> Filter the Settings Updates by a Super SIM's SID or UniqueName. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of SettingsUpdate </returns>
        public static ResourceSet<SettingsUpdateResource> Read(
                                                     string sim = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSettingsUpdateOptions(){ Sim = sim, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Settings Updates. </summary>
        /// <param name="sim"> Filter the Settings Updates by a Super SIM's SID or UniqueName. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of SettingsUpdate </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SettingsUpdateResource>> ReadAsync(
                                                                                             string sim = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSettingsUpdateOptions(){ Sim = sim, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SettingsUpdateResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SettingsUpdateResource>.FromJson("settings_updates", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SettingsUpdateResource> NextPage(Page<SettingsUpdateResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SettingsUpdateResource>.FromJson("settings_updates", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SettingsUpdateResource> PreviousPage(Page<SettingsUpdateResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SettingsUpdateResource>.FromJson("settings_updates", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a SettingsUpdateResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SettingsUpdateResource object represented by the provided JSON </returns>
        public static SettingsUpdateResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SettingsUpdateResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique identifier of this Settings Update </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The ICCID associated with the SIM </summary> 
        [JsonProperty("iccid")]
        public string Iccid { get; private set; }

        ///<summary> The SID of the Super SIM to which this Settings Update was applied </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        
        [JsonProperty("status")]
        public SettingsUpdateResource.StatusEnum Status { get; private set; }

        ///<summary> Array containing the different Settings Packages that will be applied to the SIM after the update completes </summary> 
        [JsonProperty("packages")]
        public List<object> Packages { get; private set; }

        ///<summary> The time when the update successfully completed and the new settings were applied to the SIM </summary> 
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }

        ///<summary> The date this Settings Update was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date this Settings Update was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private SettingsUpdateResource() {

        }
    }
}

