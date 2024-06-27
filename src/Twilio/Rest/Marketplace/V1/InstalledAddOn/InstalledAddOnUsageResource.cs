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


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Marketplace.V1.InstalledAddOn
{
    public class InstalledAddOnUsageResource : Resource
    {
    
        public class CreateBillingUsageRequestBillableItems
        {
            [JsonProperty("quantity")]
            private decimal? Quantity {get; set;}
            [JsonProperty("sid")]
            private string Sid {get; set;}
            public CreateBillingUsageRequestBillableItems() { }
            public class Builder
            {
                private CreateBillingUsageRequestBillableItems _createBillingUsageRequestBillableItems = new CreateBillingUsageRequestBillableItems();
                public Builder()
                {
                }
                public Builder WithQuantity(decimal? quantity)
                {
                    _createBillingUsageRequestBillableItems.Quantity= quantity;
                    return this;
                }
                public Builder WithSid(string sid)
                {
                    _createBillingUsageRequestBillableItems.Sid= sid;
                    return this;
                }
                public CreateBillingUsageRequestBillableItems Build()
                {
                    return _createBillingUsageRequestBillableItems;
                }
            }
        }
        public class CreateBillingUsageRequest
        {
            [JsonProperty("billable_items")]
            private List<CreateBillingUsageRequestBillableItems> BillableItems {get; set;}
            public CreateBillingUsageRequest() { }
            public class Builder
            {
                private CreateBillingUsageRequest _createBillingUsageRequest = new CreateBillingUsageRequest();
                public Builder()
                {
                }
                public Builder WithBillableItems(List<CreateBillingUsageRequestBillableItems> billableItems)
                {
                    _createBillingUsageRequest.BillableItems= billableItems;
                    return this;
                }
                public CreateBillingUsageRequest Build()
                {
                    return _createBillingUsageRequest;
                }
            }
        }
        public class MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems
        {
            [JsonProperty("quantity")]
            private decimal? Quantity {get; set;}
            [JsonProperty("sid")]
            private string Sid {get; set;}
            [JsonProperty("submitted")]
            private bool? Submitted {get; set;}
            public MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems() { }
            public class Builder
            {
                private MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems _marketplaceV1InstalledAddOnBillingUsageResponseBillableItems = new MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems();
                public Builder()
                {
                }
                public Builder WithQuantity(decimal? quantity)
                {
                    _marketplaceV1InstalledAddOnBillingUsageResponseBillableItems.Quantity= quantity;
                    return this;
                }
                public Builder WithSid(string sid)
                {
                    _marketplaceV1InstalledAddOnBillingUsageResponseBillableItems.Sid= sid;
                    return this;
                }
                public Builder WithSubmitted(bool? submitted)
                {
                    _marketplaceV1InstalledAddOnBillingUsageResponseBillableItems.Submitted= submitted;
                    return this;
                }
                public MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems Build()
                {
                    return _marketplaceV1InstalledAddOnBillingUsageResponseBillableItems;
                }
            }
        }

    

        
        private static Request BuildCreateRequest(CreateInstalledAddOnUsageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns/{InstalledAddOnSid}/Usage";

            string PathInstalledAddOnSid = options.PathInstalledAddOnSid;
            path = path.Replace("{"+"InstalledAddOnSid"+"}", PathInstalledAddOnSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Marketplace,
                path,

                contentType: EnumConstants.ContentTypeEnum.JSON,
                body: options.GetBody(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create InstalledAddOnUsage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOnUsage </returns>
        public static InstalledAddOnUsageResource Create(CreateInstalledAddOnUsageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create InstalledAddOnUsage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOnUsage </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnUsageResource> CreateAsync(CreateInstalledAddOnUsageOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathInstalledAddOnSid">  </param>
        /// <param name="createBillingUsageRequest">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOnUsage </returns>
        public static InstalledAddOnUsageResource Create(
                                          string pathInstalledAddOnSid,
                                          InstalledAddOnUsageResource.CreateBillingUsageRequest createBillingUsageRequest,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInstalledAddOnUsageOptions(pathInstalledAddOnSid, createBillingUsageRequest){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathInstalledAddOnSid">  </param>
        /// <param name="createBillingUsageRequest">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOnUsage </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnUsageResource> CreateAsync(
                                                                                  string pathInstalledAddOnSid,
                                                                                  InstalledAddOnUsageResource.CreateBillingUsageRequest createBillingUsageRequest,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInstalledAddOnUsageOptions(pathInstalledAddOnSid, createBillingUsageRequest){  };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InstalledAddOnUsageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InstalledAddOnUsageResource object represented by the provided JSON </returns>
        public static InstalledAddOnUsageResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InstalledAddOnUsageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The billable_items </summary> 
        [JsonProperty("billable_items")]
        public List<MarketplaceV1InstalledAddOnBillingUsageResponseBillableItems> BillableItems { get; private set; }

        ///<summary> Represents the total quantity submitted. </summary> 
        [JsonProperty("total_submitted")]
        public decimal? TotalSubmitted { get; private set; }



        private InstalledAddOnUsageResource() {

        }
    }
}
