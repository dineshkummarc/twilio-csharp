/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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




namespace Twilio.Rest.Api.V2010.Account.Recording.AddOnResult.Payload
{
    /// <summary> Fetch an instance of a result payload </summary>
    public class FetchDataOptions : IOptions<DataResource>
    {
    
        ///<summary> The SID of the recording to which the AddOnResult resource that contains the payload to fetch belongs. </summary> 
        public string PathReferenceSid { get; }

        ///<summary> The SID of the AddOnResult to which the payload to fetch belongs. </summary> 
        public string PathAddOnResultSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Recording AddOnResult Payload resource to fetch. </summary> 
        public string PathPayloadSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult Payload resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchRecordingAddOnResultPayloadDataOptions </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the AddOnResult resource that contains the payload to fetch belongs. </param>
        /// <param name="pathAddOnResultSid"> The SID of the AddOnResult to which the payload to fetch belongs. </param>
        /// <param name="pathPayloadSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult Payload resource to fetch. </param>
        public FetchDataOptions(string pathReferenceSid, string pathAddOnResultSid, string pathPayloadSid)
        {
            PathReferenceSid = pathReferenceSid;
            PathAddOnResultSid = pathAddOnResultSid;
            PathPayloadSid = pathPayloadSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


}
