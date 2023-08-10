/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Wireless
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




namespace Twilio.Rest.Wireless.V1.Sim
{
    /// <summary> read </summary>
    public class ReadUsageRecordOptions : ReadOptions<UsageRecordResource>
    {
    
        ///<summary> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource)  to read the usage from. </summary> 
        public string PathSimSid { get; }

        ///<summary> Only include usage that occurred on or before this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is the current time. </summary> 
        public DateTime? End { get; set; }

        ///<summary> Only include usage that has occurred on or after this date, specified in [ISO 8601](https://www.iso.org/iso-8601-date-and-time-format.html). The default is one month before the `end` parameter value. </summary> 
        public DateTime? Start { get; set; }

        ///<summary> How to summarize the usage by time. Can be: `daily`, `hourly`, or `all`. The default is `all`. A value of `all` returns one Usage Record that describes the usage for the entire period. </summary> 
        public UsageRecordResource.GranularityEnum Granularity { get; set; }



        /// <summary> Construct a new ListUsageRecordOptions </summary>
        /// <param name="pathSimSid"> The SID of the [Sim resource](https://www.twilio.com/docs/iot/wireless/api/sim-resource)  to read the usage from. </param>
        public ReadUsageRecordOptions(string pathSimSid)
        {
            PathSimSid = pathSimSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (End != null)
            {
                p.Add(new KeyValuePair<string, string>("End", Serializers.DateTimeIso8601(End)));
            }
            if (Start != null)
            {
                p.Add(new KeyValuePair<string, string>("Start", Serializers.DateTimeIso8601(Start)));
            }
            if (Granularity != null)
            {
                p.Add(new KeyValuePair<string, string>("Granularity", Granularity.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

