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




namespace Twilio.Rest.Marketplace.V1.InstalledAddOn
{

    /// <summary> create </summary>
    public class CreateInstalledAddOnUsageOptions : IOptions<InstalledAddOnUsageResource>
    {
        
        
        public string PathInstalledAddOnSid { get; }

        
        public InstalledAddOnUsageResource.CreateBillingUsageRequest CreateBillingUsageRequest { get; }


        /// <summary> Construct a new CreateBillingUsageOptions </summary>
        /// <param name="pathInstalledAddOnSid">  </param>
        /// <param name="createBillingUsageRequest">  </param>
        public CreateInstalledAddOnUsageOptions(string pathInstalledAddOnSid, InstalledAddOnUsageResource.CreateBillingUsageRequest createBillingUsageRequest)
        {
            PathInstalledAddOnSid = pathInstalledAddOnSid;
            CreateBillingUsageRequest = createBillingUsageRequest;
        }

        
        /// <summary> Generate the request body </summary>
        public string GetBody()
        {
            string body = "";

            if (CreateBillingUsageRequest != null)
            {
                body = InstalledAddOnUsageResource.ToJson(CreateBillingUsageRequest);
            }
            return body;
        }
        

    }
}

