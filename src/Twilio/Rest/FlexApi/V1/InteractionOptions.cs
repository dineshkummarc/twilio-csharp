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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.FlexApi.V1
{

    /// <summary> Create a new Interaction. </summary>
    public class CreateInteractionOptions : IOptions<InteractionResource>
    {
        
        ///<summary> The Interaction's channel. </summary> 
        public object Channel { get; }

        ///<summary> The Interaction's routing logic. </summary> 
        public object Routing { get; }


        /// <summary> Construct a new CreateInteractionOptions </summary>
        /// <param name="channel"> The Interaction's channel. </param>        /// <param name="routing"> The Interaction's routing logic. </param>
        public CreateInteractionOptions(object channel, object routing)
        {
            Channel = channel;
            Routing = routing;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Serializers.JsonObject(Channel)));
            }
            if (Routing != null)
            {
                p.Add(new KeyValuePair<string, string>("Routing", Serializers.JsonObject(Routing)));
            }
            return p;
        }
        

    }
    /// <summary> fetch </summary>
    public class FetchInteractionOptions : IOptions<InteractionResource>
    {
    
        ///<summary> The SID of the Interaction resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchInteractionOptions </summary>
        /// <param name="pathSid"> The SID of the Interaction resource to fetch. </param>
        public FetchInteractionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}

