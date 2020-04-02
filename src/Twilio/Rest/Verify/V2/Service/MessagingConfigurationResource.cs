/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// MessagingConfigurationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Verify.V2.Service
{

    public class MessagingConfigurationResource : Resource
    {
        private static Request BuildCreateRequest(CreateMessagingConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/MessagingConfigurations",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new MessagingConfiguration for a service.
        /// </summary>
        /// <param name="options"> Create MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Create(CreateMessagingConfigurationOptions options,
                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new MessagingConfiguration for a service.
        /// </summary>
        /// <param name="options"> Create MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> CreateAsync(CreateMessagingConfigurationOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new MessagingConfiguration for a service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="country"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service used for this configuration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Create(string pathServiceSid,
                                                            string country,
                                                            string messagingServiceSid,
                                                            ITwilioRestClient client = null)
        {
            var options = new CreateMessagingConfigurationOptions(pathServiceSid, country, messagingServiceSid);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new MessagingConfiguration for a service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="country"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service used for this configuration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> CreateAsync(string pathServiceSid,
                                                                                                    string country,
                                                                                                    string messagingServiceSid,
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateMessagingConfigurationOptions(pathServiceSid, country, messagingServiceSid);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateMessagingConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/MessagingConfigurations/" + options.PathCountry + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific MessagingConfiguration
        /// </summary>
        /// <param name="options"> Update MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Update(UpdateMessagingConfigurationOptions options,
                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific MessagingConfiguration
        /// </summary>
        /// <param name="options"> Update MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> UpdateAsync(UpdateMessagingConfigurationOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific MessagingConfiguration
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service used for this configuration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Update(string pathServiceSid,
                                                            string pathCountry,
                                                            string messagingServiceSid,
                                                            ITwilioRestClient client = null)
        {
            var options = new UpdateMessagingConfigurationOptions(pathServiceSid, pathCountry, messagingServiceSid);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific MessagingConfiguration
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the Messaging Service used for this configuration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> UpdateAsync(string pathServiceSid,
                                                                                                    string pathCountry,
                                                                                                    string messagingServiceSid,
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateMessagingConfigurationOptions(pathServiceSid, pathCountry, messagingServiceSid);
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchMessagingConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/MessagingConfigurations/" + options.PathCountry + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific MessagingConfiguration.
        /// </summary>
        /// <param name="options"> Fetch MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Fetch(FetchMessagingConfigurationOptions options,
                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific MessagingConfiguration.
        /// </summary>
        /// <param name="options"> Fetch MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> FetchAsync(FetchMessagingConfigurationOptions options,
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific MessagingConfiguration.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static MessagingConfigurationResource Fetch(string pathServiceSid,
                                                           string pathCountry,
                                                           ITwilioRestClient client = null)
        {
            var options = new FetchMessagingConfigurationOptions(pathServiceSid, pathCountry);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific MessagingConfiguration.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<MessagingConfigurationResource> FetchAsync(string pathServiceSid,
                                                                                                   string pathCountry,
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchMessagingConfigurationOptions(pathServiceSid, pathCountry);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadMessagingConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/MessagingConfigurations",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Messaging Configurations for a Service.
        /// </summary>
        /// <param name="options"> Read MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static ResourceSet<MessagingConfigurationResource> Read(ReadMessagingConfigurationOptions options,
                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<MessagingConfigurationResource>.FromJson("messaging_configurations", response.Content);
            return new ResourceSet<MessagingConfigurationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Messaging Configurations for a Service.
        /// </summary>
        /// <param name="options"> Read MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessagingConfigurationResource>> ReadAsync(ReadMessagingConfigurationOptions options,
                                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessagingConfigurationResource>.FromJson("messaging_configurations", response.Content);
            return new ResourceSet<MessagingConfigurationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Messaging Configurations for a Service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static ResourceSet<MessagingConfigurationResource> Read(string pathServiceSid,
                                                                       int? pageSize = null,
                                                                       long? limit = null,
                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadMessagingConfigurationOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Messaging Configurations for a Service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessagingConfigurationResource>> ReadAsync(string pathServiceSid,
                                                                                                               int? pageSize = null,
                                                                                                               long? limit = null,
                                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadMessagingConfigurationOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MessagingConfigurationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessagingConfigurationResource>.FromJson("messaging_configurations", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MessagingConfigurationResource> NextPage(Page<MessagingConfigurationResource> page,
                                                                    ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Verify,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessagingConfigurationResource>.FromJson("messaging_configurations", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MessagingConfigurationResource> PreviousPage(Page<MessagingConfigurationResource> page,
                                                                        ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Verify,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<MessagingConfigurationResource>.FromJson("messaging_configurations", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteMessagingConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/MessagingConfigurations/" + options.PathCountry + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific MessagingConfiguration.
        /// </summary>
        /// <param name="options"> Delete MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static bool Delete(DeleteMessagingConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific MessagingConfiguration.
        /// </summary>
        /// <param name="options"> Delete MessagingConfiguration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessagingConfigurationOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific MessagingConfiguration.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MessagingConfiguration </returns>
        public static bool Delete(string pathServiceSid, string pathCountry, ITwilioRestClient client = null)
        {
            var options = new DeleteMessagingConfigurationOptions(pathServiceSid, pathCountry);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific MessagingConfiguration.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathCountry"> The ISO-3166-1 country code of the country or `all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MessagingConfiguration </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathCountry,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteMessagingConfigurationOptions(pathServiceSid, pathCountry);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a MessagingConfigurationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessagingConfigurationResource object represented by the provided JSON </returns>
        public static MessagingConfigurationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MessagingConfigurationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The ISO-3166-1 country code of the country or `all`.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }
        /// <summary>
        /// The SID of the Messaging Service used for this configuration.
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private MessagingConfigurationResource()
        {

        }
    }

}