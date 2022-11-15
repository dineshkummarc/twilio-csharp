/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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



namespace Twilio.Rest.Studio.V1.Flow.Execution
{
    public class ExecutionStepResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchExecutionStepOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Executions/{ExecutionSid}/Steps/{Sid}";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathExecutionSid = options.PathExecutionSid;
            path = path.Replace("{"+"ExecutionSid"+"}", PathExecutionSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a Step. </summary>
        /// <param name="options"> Fetch ExecutionStep parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStep </returns>
        public static ExecutionStepResource Fetch(FetchExecutionStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a Step. </summary>
        /// <param name="options"> Fetch ExecutionStep parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStep </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepResource> FetchAsync(FetchExecutionStepOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution resource with the Step to fetch. </param>
        /// <param name="pathSid"> The SID of the ExecutionStep resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStep </returns>
        public static ExecutionStepResource Fetch(
                                         string pathFlowSid, 
                                         string pathExecutionSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepOptions(pathFlowSid, pathExecutionSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution resource with the Step to fetch. </param>
        /// <param name="pathSid"> The SID of the ExecutionStep resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStep </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepResource> FetchAsync(string pathFlowSid, string pathExecutionSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepOptions(pathFlowSid, pathExecutionSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadExecutionStepOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Executions/{ExecutionSid}/Steps";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathExecutionSid = options.PathExecutionSid;
            path = path.Replace("{"+"ExecutionSid"+"}", PathExecutionSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Steps for an Execution. </summary>
        /// <param name="options"> Read ExecutionStep parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStep </returns>
        public static ResourceSet<ExecutionStepResource> Read(ReadExecutionStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ExecutionStepResource>.FromJson("steps", response.Content);
            return new ResourceSet<ExecutionStepResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Steps for an Execution. </summary>
        /// <param name="options"> Read ExecutionStep parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStep </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ExecutionStepResource>> ReadAsync(ReadExecutionStepOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ExecutionStepResource>.FromJson("steps", response.Content);
            return new ResourceSet<ExecutionStepResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Steps for an Execution. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Steps to read. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution with the Steps to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of ExecutionStep </returns>
        public static ResourceSet<ExecutionStepResource> Read(
                                                     string pathFlowSid,
                                                     string pathExecutionSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadExecutionStepOptions(pathFlowSid, pathExecutionSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Steps for an Execution. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Steps to read. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution with the Steps to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of ExecutionStep </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ExecutionStepResource>> ReadAsync(
                                                                                             string pathFlowSid,
                                                                                             string pathExecutionSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadExecutionStepOptions(pathFlowSid, pathExecutionSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ExecutionStepResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ExecutionStepResource>.FromJson("steps", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ExecutionStepResource> NextPage(Page<ExecutionStepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ExecutionStepResource>.FromJson("steps", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ExecutionStepResource> PreviousPage(Page<ExecutionStepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ExecutionStepResource>.FromJson("steps", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a ExecutionStepResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExecutionStepResource object represented by the provided JSON </returns>
        public static ExecutionStepResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ExecutionStepResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the Account that created the resource </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Flow </summary> 
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }

        ///<summary> The SID of the Execution </summary> 
        [JsonProperty("execution_sid")]
        public string ExecutionSid { get; private set; }

        ///<summary> The event that caused the Flow to transition to the Step </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The current state of the flow </summary> 
        [JsonProperty("context")]
        public object Context { get; private set; }

        ///<summary> The Widget that preceded the Widget for the Step </summary> 
        [JsonProperty("transitioned_from")]
        public string TransitionedFrom { get; private set; }

        ///<summary> The Widget that will follow the Widget for the Step </summary> 
        [JsonProperty("transitioned_to")]
        public string TransitionedTo { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ExecutionStepResource() {

        }
    }
}

