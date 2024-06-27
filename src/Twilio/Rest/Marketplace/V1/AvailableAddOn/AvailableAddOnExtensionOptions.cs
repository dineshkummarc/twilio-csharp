/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Marketplace
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




namespace Twilio.Rest.Marketplace.V1.AvailableAddOn
{
    /// <summary> Fetch an instance of an Extension for the Available Add-on. </summary>
    public class FetchAvailableAddOnExtensionOptions : IOptions<AvailableAddOnExtensionResource>
    {
    
        ///<summary> The SID of the AvailableAddOn resource with the extension to fetch. </summary> 
        public string PathAvailableAddOnSid { get; }

        ///<summary> The SID of the AvailableAddOn Extension resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchAvailableAddOnExtensionOptions </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extension to fetch. </param>
        /// <param name="pathSid"> The SID of the AvailableAddOn Extension resource to fetch. </param>
        public FetchAvailableAddOnExtensionOptions(string pathAvailableAddOnSid, string pathSid)
        {
            PathAvailableAddOnSid = pathAvailableAddOnSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of Extensions for the Available Add-on. </summary>
    public class ReadAvailableAddOnExtensionOptions : ReadOptions<AvailableAddOnExtensionResource>
    {
    
        ///<summary> The SID of the AvailableAddOn resource with the extensions to read. </summary> 
        public string PathAvailableAddOnSid { get; }



        /// <summary> Construct a new ListAvailableAddOnExtensionOptions </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extensions to read. </param>
        public ReadAvailableAddOnExtensionOptions(string pathAvailableAddOnSid)
        {
            PathAvailableAddOnSid = pathAvailableAddOnSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

