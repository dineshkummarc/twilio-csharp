/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PlayerStreamerResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Media.V1
{

    public class PlayerStreamerResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Created = new StatusEnum("created");
            public static readonly StatusEnum Started = new StatusEnum("started");
            public static readonly StatusEnum Ended = new StatusEnum("ended");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class UpdateStatusEnum : StringEnum
        {
            private UpdateStatusEnum(string value) : base(value) {}
            public UpdateStatusEnum() {}
            public static implicit operator UpdateStatusEnum(string value)
            {
                return new UpdateStatusEnum(value);
            }

            public static readonly UpdateStatusEnum Ended = new UpdateStatusEnum("ended");
        }

        public sealed class OrderEnum : StringEnum
        {
            private OrderEnum(string value) : base(value) {}
            public OrderEnum() {}
            public static implicit operator OrderEnum(string value)
            {
                return new OrderEnum(value);
            }

            public static readonly OrderEnum Asc = new OrderEnum("asc");
            public static readonly OrderEnum Desc = new OrderEnum("desc");
        }

        public sealed class EndedReasonEnum : StringEnum
        {
            private EndedReasonEnum(string value) : base(value) {}
            public EndedReasonEnum() {}
            public static implicit operator EndedReasonEnum(string value)
            {
                return new EndedReasonEnum(value);
            }

            public static readonly EndedReasonEnum EndedViaApi = new EndedReasonEnum("ended-via-api");
            public static readonly EndedReasonEnum MaxDurationExceeded = new EndedReasonEnum("max-duration-exceeded");
            public static readonly EndedReasonEnum StreamDisconnectedBySource = new EndedReasonEnum("stream-disconnected-by-source");
            public static readonly EndedReasonEnum UnexpectedFailure = new EndedReasonEnum("unexpected-failure");
        }

        private static Request BuildFetchRequest(FetchPlayerStreamerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                "/v1/PlayerStreamers/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns a single PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="options"> Fetch PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Fetch(FetchPlayerStreamerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="options"> Fetch PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> FetchAsync(FetchPlayerStreamerOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchPlayerStreamerOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> FetchAsync(string pathSid,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchPlayerStreamerOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreatePlayerStreamerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Media,
                "/v1/PlayerStreamers",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Create(CreatePlayerStreamerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> CreateAsync(CreatePlayerStreamerOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="video"> Whether the PlayerStreamer is configured to stream video </param>
        /// <param name="statusCallback"> The URL to which Twilio will send PlayerStreamer event updates </param>
        /// <param name="statusCallbackMethod"> The HTTP method Twilio should use to call the `status_callback` URL </param>
        /// <param name="maxDuration"> Maximum PlayerStreamer duration in seconds </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Create(bool? video = null,
                                                    Uri statusCallback = null,
                                                    Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                    int? maxDuration = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new CreatePlayerStreamerOptions(){Video = video, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxDuration = maxDuration};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="video"> Whether the PlayerStreamer is configured to stream video </param>
        /// <param name="statusCallback"> The URL to which Twilio will send PlayerStreamer event updates </param>
        /// <param name="statusCallbackMethod"> The HTTP method Twilio should use to call the `status_callback` URL </param>
        /// <param name="maxDuration"> Maximum PlayerStreamer duration in seconds </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> CreateAsync(bool? video = null,
                                                                                            Uri statusCallback = null,
                                                                                            Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                            int? maxDuration = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new CreatePlayerStreamerOptions(){Video = video, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxDuration = maxDuration};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdatePlayerStreamerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Media,
                "/v1/PlayerStreamers/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Updates a PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="options"> Update PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Update(UpdatePlayerStreamerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Updates a PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="options"> Update PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> UpdateAsync(UpdatePlayerStreamerOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Updates a PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="status"> The status the PlayerStreamer should be transitioned to </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static PlayerStreamerResource Update(string pathSid,
                                                    PlayerStreamerResource.UpdateStatusEnum status,
                                                    ITwilioRestClient client = null)
        {
            var options = new UpdatePlayerStreamerOptions(pathSid, status);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Updates a PlayerStreamer resource identified by a SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="status"> The status the PlayerStreamer should be transitioned to </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<PlayerStreamerResource> UpdateAsync(string pathSid,
                                                                                            PlayerStreamerResource.UpdateStatusEnum status,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new UpdatePlayerStreamerOptions(pathSid, status);
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadPlayerStreamerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                "/v1/PlayerStreamers",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns a list of PlayerStreamers.
        /// </summary>
        /// <param name="options"> Read PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static ResourceSet<PlayerStreamerResource> Read(ReadPlayerStreamerOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<PlayerStreamerResource>.FromJson("player_streamers", response.Content);
            return new ResourceSet<PlayerStreamerResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of PlayerStreamers.
        /// </summary>
        /// <param name="options"> Read PlayerStreamer parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PlayerStreamerResource>> ReadAsync(ReadPlayerStreamerOptions options,
                                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<PlayerStreamerResource>.FromJson("player_streamers", response.Content);
            return new ResourceSet<PlayerStreamerResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Returns a list of PlayerStreamers.
        /// </summary>
        /// <param name="order"> The sort order of the list </param>
        /// <param name="status"> Status to filter by </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlayerStreamer </returns>
        public static ResourceSet<PlayerStreamerResource> Read(PlayerStreamerResource.OrderEnum order = null,
                                                               PlayerStreamerResource.StatusEnum status = null,
                                                               int? pageSize = null,
                                                               long? limit = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new ReadPlayerStreamerOptions(){Order = order, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of PlayerStreamers.
        /// </summary>
        /// <param name="order"> The sort order of the list </param>
        /// <param name="status"> Status to filter by </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlayerStreamer </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PlayerStreamerResource>> ReadAsync(PlayerStreamerResource.OrderEnum order = null,
                                                                                                       PlayerStreamerResource.StatusEnum status = null,
                                                                                                       int? pageSize = null,
                                                                                                       long? limit = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadPlayerStreamerOptions(){Order = order, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<PlayerStreamerResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PlayerStreamerResource>.FromJson("player_streamers", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<PlayerStreamerResource> NextPage(Page<PlayerStreamerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Media)
            );

            var response = client.Request(request);
            return Page<PlayerStreamerResource>.FromJson("player_streamers", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<PlayerStreamerResource> PreviousPage(Page<PlayerStreamerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Media)
            );

            var response = client.Request(request);
            return Page<PlayerStreamerResource>.FromJson("player_streamers", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a PlayerStreamerResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PlayerStreamerResource object represented by the provided JSON </returns>
        public static PlayerStreamerResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PlayerStreamerResource>(json);
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
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Whether the PlayerStreamer is configured to stream video
        /// </summary>
        [JsonProperty("video")]
        public bool? Video { get; private set; }
        /// <summary>
        /// The URLs of related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of the PlayerStreamer
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PlayerStreamerResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URL to which Twilio will send PlayerStreamer event updates
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The HTTP method Twilio should use to call the `status_callback` URL
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The reason why a PlayerStreamer ended
        /// </summary>
        [JsonProperty("ended_reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PlayerStreamerResource.EndedReasonEnum EndedReason { get; private set; }
        /// <summary>
        /// Maximum PlayerStreamer duration in seconds
        /// </summary>
        [JsonProperty("max_duration")]
        public int? MaxDuration { get; private set; }

        private PlayerStreamerResource()
        {

        }
    }

}