/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Pricing
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


namespace Twilio.Rest.Pricing.V2
{
    public class NumberResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Trunking/Numbers/{DestinationNumber}";

            string PathDestinationNumber = options.PathDestinationNumber.ToString();
            path = path.Replace("{"+"DestinationNumber"+"}", PathDestinationNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Pricing,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch pricing information for a specific destination and, optionally, origination phone number. </summary>
        /// <param name="options"> Fetch Number parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Number </returns>
        public static NumberResource Fetch(FetchNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch pricing information for a specific destination and, optionally, origination phone number. </summary>
        /// <param name="options"> Fetch Number parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Number </returns>
        public static async System.Threading.Tasks.Task<NumberResource> FetchAsync(FetchNumberOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch pricing information for a specific destination and, optionally, origination phone number. </summary>
        /// <param name="pathDestinationNumber"> The destination phone number, in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, for which to fetch the origin-based voice pricing information. E.164 format consists of a + followed by the country code and subscriber number. </param>
        /// <param name="originationNumber"> The origination phone number, in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, for which to fetch the origin-based voice pricing information. E.164 format consists of a + followed by the country code and subscriber number. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Number </returns>
        public static NumberResource Fetch(
                                         Types.PhoneNumber pathDestinationNumber, 
                                         Types.PhoneNumber originationNumber = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchNumberOptions(pathDestinationNumber){ OriginationNumber = originationNumber };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch pricing information for a specific destination and, optionally, origination phone number. </summary>
        /// <param name="pathDestinationNumber"> The destination phone number, in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, for which to fetch the origin-based voice pricing information. E.164 format consists of a + followed by the country code and subscriber number. </param>
        /// <param name="originationNumber"> The origination phone number, in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, for which to fetch the origin-based voice pricing information. E.164 format consists of a + followed by the country code and subscriber number. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Number </returns>
        public static async System.Threading.Tasks.Task<NumberResource> FetchAsync(Types.PhoneNumber pathDestinationNumber, Types.PhoneNumber originationNumber = null, ITwilioRestClient client = null)
        {
            var options = new FetchNumberOptions(pathDestinationNumber){ OriginationNumber = originationNumber };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NumberResource object represented by the provided JSON </returns>
        public static NumberResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The destination phone number, in E.164 format </summary> 
        [JsonProperty("destination_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber DestinationNumber { get; private set; }

        ///<summary> The origination phone number, in E.164 format </summary> 
        [JsonProperty("origination_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber OriginationNumber { get; private set; }

        ///<summary> The name of the country </summary> 
        [JsonProperty("country")]
        public string Country { get; private set; }

        ///<summary> The ISO country code </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The terminating_prefix_prices </summary> 
        [JsonProperty("terminating_prefix_prices")]
        public List<OutboundPrefixPriceWithOrigin> TerminatingPrefixPrices { get; private set; }

        ///<summary> The originating_call_price </summary> 
        [JsonProperty("originating_call_price")]
        public InboundCallPrice OriginatingCallPrice { get; private set; }

        ///<summary> The currency in which prices are measured, in ISO 4127 format (e.g. usd, eur, jpy) </summary> 
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }

        ///<summary> The absolute URL of the resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private NumberResource() {

        }
    }
}

