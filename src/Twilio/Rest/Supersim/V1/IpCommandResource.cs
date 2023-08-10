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
    public class IpCommandResource : Resource
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
            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Sent = new StatusEnum("sent");
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }
            public static readonly DirectionEnum ToSim = new DirectionEnum("to_sim");
            public static readonly DirectionEnum FromSim = new DirectionEnum("from_sim");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PayloadTypeEnum : StringEnum
        {
            private PayloadTypeEnum(string value) : base(value) {}
            public PayloadTypeEnum() {}
            public static implicit operator PayloadTypeEnum(string value)
            {
                return new PayloadTypeEnum(value);
            }
            public static readonly PayloadTypeEnum Text = new PayloadTypeEnum("text");
            public static readonly PayloadTypeEnum Binary = new PayloadTypeEnum("binary");

        }

        
        private static Request BuildCreateRequest(CreateIpCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/IpCommands";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Send an IP Command to a Super SIM. </summary>
        /// <param name="options"> Create IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static IpCommandResource Create(CreateIpCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Send an IP Command to a Super SIM. </summary>
        /// <param name="options"> Create IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<IpCommandResource> CreateAsync(CreateIpCommandOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Send an IP Command to a Super SIM. </summary>
        /// <param name="sim"> The `sid` or `unique_name` of the [Super SIM](https://www.twilio.com/docs/iot/supersim/api/sim-resource) to send the IP Command to. </param>
        /// <param name="payload"> The data that will be sent to the device. The payload cannot exceed 1300 bytes. If the PayloadType is set to text, the payload is encoded in UTF-8. If PayloadType is set to binary, the payload is encoded in Base64. </param>
        /// <param name="devicePort"> The device port to which the IP Command will be sent. </param>
        /// <param name="payloadType">  </param>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` after we have sent the IP Command. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be `GET` or `POST`, and the default is `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static IpCommandResource Create(
                                          string sim,
                                          string payload,
                                          int? devicePort,
                                          IpCommandResource.PayloadTypeEnum payloadType = null,
                                          Uri callbackUrl = null,
                                          Twilio.Http.HttpMethod callbackMethod = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateIpCommandOptions(sim, payload, devicePort){  PayloadType = payloadType, CallbackUrl = callbackUrl, CallbackMethod = callbackMethod };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Send an IP Command to a Super SIM. </summary>
        /// <param name="sim"> The `sid` or `unique_name` of the [Super SIM](https://www.twilio.com/docs/iot/supersim/api/sim-resource) to send the IP Command to. </param>
        /// <param name="payload"> The data that will be sent to the device. The payload cannot exceed 1300 bytes. If the PayloadType is set to text, the payload is encoded in UTF-8. If PayloadType is set to binary, the payload is encoded in Base64. </param>
        /// <param name="devicePort"> The device port to which the IP Command will be sent. </param>
        /// <param name="payloadType">  </param>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` after we have sent the IP Command. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be `GET` or `POST`, and the default is `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<IpCommandResource> CreateAsync(
                                                                                  string sim,
                                                                                  string payload,
                                                                                  int? devicePort,
                                                                                  IpCommandResource.PayloadTypeEnum payloadType = null,
                                                                                  Uri callbackUrl = null,
                                                                                  Twilio.Http.HttpMethod callbackMethod = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateIpCommandOptions(sim, payload, devicePort){  PayloadType = payloadType, CallbackUrl = callbackUrl, CallbackMethod = callbackMethod };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchIpCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/IpCommands/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch IP Command instance from your account. </summary>
        /// <param name="options"> Fetch IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static IpCommandResource Fetch(FetchIpCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch IP Command instance from your account. </summary>
        /// <param name="options"> Fetch IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<IpCommandResource> FetchAsync(FetchIpCommandOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch IP Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the IP Command resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static IpCommandResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchIpCommandOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch IP Command instance from your account. </summary>
        /// <param name="pathSid"> The SID of the IP Command resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<IpCommandResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchIpCommandOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadIpCommandOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/IpCommands";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of IP Commands from your account. </summary>
        /// <param name="options"> Read IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static ResourceSet<IpCommandResource> Read(ReadIpCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<IpCommandResource>.FromJson("ip_commands", response.Content);
            return new ResourceSet<IpCommandResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IP Commands from your account. </summary>
        /// <param name="options"> Read IpCommand parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpCommandResource>> ReadAsync(ReadIpCommandOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<IpCommandResource>.FromJson("ip_commands", response.Content);
            return new ResourceSet<IpCommandResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of IP Commands from your account. </summary>
        /// <param name="sim"> The SID or unique name of the Sim resource that IP Command was sent to or from. </param>
        /// <param name="simIccid"> The ICCID of the Sim resource that IP Command was sent to or from. </param>
        /// <param name="status"> The status of the IP Command. Can be: `queued`, `sent`, `received` or `failed`. See the [IP Command Status Values](https://www.twilio.com/docs/iot/supersim/api/ipcommand-resource#status-values) for a description of each. </param>
        /// <param name="direction"> The direction of the IP Command. Can be `to_sim` or `from_sim`. The value of `to_sim` is synonymous with the term `mobile terminated`, and `from_sim` is synonymous with the term `mobile originated`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpCommand </returns>
        public static ResourceSet<IpCommandResource> Read(
                                                     string sim = null,
                                                     string simIccid = null,
                                                     IpCommandResource.StatusEnum status = null,
                                                     IpCommandResource.DirectionEnum direction = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadIpCommandOptions(){ Sim = sim, SimIccid = simIccid, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IP Commands from your account. </summary>
        /// <param name="sim"> The SID or unique name of the Sim resource that IP Command was sent to or from. </param>
        /// <param name="simIccid"> The ICCID of the Sim resource that IP Command was sent to or from. </param>
        /// <param name="status"> The status of the IP Command. Can be: `queued`, `sent`, `received` or `failed`. See the [IP Command Status Values](https://www.twilio.com/docs/iot/supersim/api/ipcommand-resource#status-values) for a description of each. </param>
        /// <param name="direction"> The direction of the IP Command. Can be `to_sim` or `from_sim`. The value of `to_sim` is synonymous with the term `mobile terminated`, and `from_sim` is synonymous with the term `mobile originated`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpCommand </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpCommandResource>> ReadAsync(
                                                                                             string sim = null,
                                                                                             string simIccid = null,
                                                                                             IpCommandResource.StatusEnum status = null,
                                                                                             IpCommandResource.DirectionEnum direction = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadIpCommandOptions(){ Sim = sim, SimIccid = simIccid, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<IpCommandResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<IpCommandResource>.FromJson("ip_commands", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<IpCommandResource> NextPage(Page<IpCommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpCommandResource>.FromJson("ip_commands", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<IpCommandResource> PreviousPage(Page<IpCommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpCommandResource>.FromJson("ip_commands", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a IpCommandResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IpCommandResource object represented by the provided JSON </returns>
        public static IpCommandResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<IpCommandResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the IP Command resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the IP Command resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Super SIM](https://www.twilio.com/docs/iot/supersim/api/sim-resource) that this IP Command was sent to or from. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) of the [Super SIM](https://www.twilio.com/docs/iot/supersim/api/sim-resource) that this IP Command was sent to or from. </summary> 
        [JsonProperty("sim_iccid")]
        public string SimIccid { get; private set; }

        
        [JsonProperty("status")]
        public IpCommandResource.StatusEnum Status { get; private set; }

        
        [JsonProperty("direction")]
        public IpCommandResource.DirectionEnum Direction { get; private set; }

        ///<summary> The IP address of the device that the IP Command was sent to or received from. For an IP Command sent to a Super SIM, `device_ip` starts out as `null`, and once the IP Command is “sent”, the `device_ip` will be filled out. An IP Command sent from a Super SIM have its `device_ip` always set. </summary> 
        [JsonProperty("device_ip")]
        public string DeviceIp { get; private set; }

        ///<summary> For an IP Command sent to a Super SIM, it would be the destination port of the IP message. For an IP Command sent from a Super SIM, it would be the source port of the IP message. </summary> 
        [JsonProperty("device_port")]
        public int? DevicePort { get; private set; }

        
        [JsonProperty("payload_type")]
        public IpCommandResource.PayloadTypeEnum PayloadType { get; private set; }

        ///<summary> The payload that is carried in the IP/UDP message. The payload can be encoded in either text or binary format. For text payload, UTF-8 encoding must be used.  For an IP Command sent to a Super SIM, the payload is appended to the IP/UDP message “as is”. The payload should not exceed 1300 bytes.  For an IP Command sent from a Super SIM, the payload from the received IP/UDP message is extracted and sent in binary encoding. For an IP Command sent from a Super SIM, the payload should not exceed 1300 bytes. If it is larger than 1300 bytes, there might be fragmentation on the upstream and the message may appear truncated. </summary> 
        [JsonProperty("payload")]
        public string Payload { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the IP Command resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private IpCommandResource() {

        }
    }
}

