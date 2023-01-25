/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class InsightsQuestionnairesCategoryResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Categories";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To create a category for Questions </summary>
        /// <param name="options"> Create InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static InsightsQuestionnairesCategoryResource Create(CreateInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To create a category for Questions </summary>
        /// <param name="options"> Create InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesCategoryResource> CreateAsync(CreateInsightsQuestionnairesCategoryOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To create a category for Questions </summary>
        /// <param name="name"> The name of this category. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static InsightsQuestionnairesCategoryResource Create(
                                          string name,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInsightsQuestionnairesCategoryOptions(name){  Token = token };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> To create a category for Questions </summary>
        /// <param name="name"> The name of this category. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesCategoryResource> CreateAsync(
                                                                                  string name,
                                                                                  string token = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInsightsQuestionnairesCategoryOptions(name){  Token = token };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        private static Request BuildDeleteRequest(DeleteInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Categories/{CategoryId}";

            string PathCategoryId = options.PathCategoryId;
            path = path.Replace("{"+"CategoryId"+"}", PathCategoryId);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static bool Delete(DeleteInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInsightsQuestionnairesCategoryOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathCategoryId"> The ID of the category to be deleted </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static bool Delete(string pathCategoryId, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesCategoryOptions(pathCategoryId)      { Token = token }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathCategoryId"> The ID of the category to be deleted </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCategoryId, string token = null, ITwilioRestClient client = null)
        {
            var options = new DeleteInsightsQuestionnairesCategoryOptions(pathCategoryId)  { Token = token };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Categories/{CategoryId}";

            string PathCategoryId = options.PathCategoryId;
            path = path.Replace("{"+"CategoryId"+"}", PathCategoryId);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To update the category for Questions </summary>
        /// <param name="options"> Update InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static InsightsQuestionnairesCategoryResource Update(UpdateInsightsQuestionnairesCategoryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> To update the category for Questions </summary>
        /// <param name="options"> Update InsightsQuestionnairesCategory parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesCategoryResource> UpdateAsync(UpdateInsightsQuestionnairesCategoryOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> To update the category for Questions </summary>
        /// <param name="pathCategoryId"> The ID of the category to be update </param>
        /// <param name="name"> The name of this category. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsQuestionnairesCategory </returns>
        public static InsightsQuestionnairesCategoryResource Update(
                                          string pathCategoryId,
                                          string name,
                                          string token = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesCategoryOptions(pathCategoryId, name){ Token = token };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> To update the category for Questions </summary>
        /// <param name="pathCategoryId"> The ID of the category to be update </param>
        /// <param name="name"> The name of this category. </param>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsQuestionnairesCategory </returns>
        public static async System.Threading.Tasks.Task<InsightsQuestionnairesCategoryResource> UpdateAsync(
                                                                              string pathCategoryId,
                                                                              string name,
                                                                              string token = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateInsightsQuestionnairesCategoryOptions(pathCategoryId, name){ Token = token };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsQuestionnairesCategoryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsQuestionnairesCategoryResource object represented by the provided JSON </returns>
        public static InsightsQuestionnairesCategoryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsQuestionnairesCategoryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique ID for the category </summary> 
        [JsonProperty("category_id")]
        public string CategoryId { get; private set; }

        ///<summary> The name of this category. </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsQuestionnairesCategoryResource() {

        }
    }
}
