/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Understand.Assistant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchQueryOptions
    /// </summary>
    public class FetchQueryOptions : IOptions<QueryResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchQueryOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchQueryOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadQueryOptions
    /// </summary>
    public class ReadQueryOptions : ReadOptions<QueryResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// An ISO language-country string of the sample.
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// The Model Build Sid or unique name of the Model Build to be queried.
        /// </summary>
        public string ModelBuild { get; set; }
        /// <summary>
        /// A string that described the query status. The values can be: pending_review, reviewed, discarded
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Construct a new ReadQueryOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        public ReadQueryOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (ModelBuild != null)
            {
                p.Add(new KeyValuePair<string, string>("ModelBuild", ModelBuild.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateQueryOptions
    /// </summary>
    public class CreateQueryOptions : IOptions<QueryResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// An ISO language-country string of the sample.
        /// </summary>
        public string Language { get; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. It can be up to 2048 characters long.
        /// </summary>
        public string Query { get; }
        /// <summary>
        /// Constraints the query to a set of intents. Useful when you need to constrain the paths the user can take. Intents should be comma separated intent-unique-name-1, intent-unique-name-2
        /// </summary>
        public string Intents { get; set; }
        /// <summary>
        /// The Model Build Sid or unique name of the Model Build to be queried.
        /// </summary>
        public string ModelBuild { get; set; }
        /// <summary>
        /// Constraints the query to a given Field with an intent. Useful when you know the Field you are expecting. It accepts one field in the format intent-unique-name-1:field-unique-name
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Construct a new CreateQueryOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="language"> An ISO language-country string of the sample. </param>
        /// <param name="query"> A user-provided string that uniquely identifies this resource as an alternative to the sid. It
        ///             can be up to 2048 characters long. </param>
        public CreateQueryOptions(string pathAssistantSid, string language, string query)
        {
            PathAssistantSid = pathAssistantSid;
            Language = language;
            Query = query;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }

            if (Query != null)
            {
                p.Add(new KeyValuePair<string, string>("Query", Query));
            }

            if (Intents != null)
            {
                p.Add(new KeyValuePair<string, string>("Intents", Intents));
            }

            if (ModelBuild != null)
            {
                p.Add(new KeyValuePair<string, string>("ModelBuild", ModelBuild.ToString()));
            }

            if (Field != null)
            {
                p.Add(new KeyValuePair<string, string>("Field", Field));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateQueryOptions
    /// </summary>
    public class UpdateQueryOptions : IOptions<QueryResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The sample_sid
        /// </summary>
        public string SampleSid { get; set; }
        /// <summary>
        /// A string that described the query status. The values can be: pending_review, reviewed, discarded
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Construct a new UpdateQueryOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateQueryOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (SampleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SampleSid", SampleSid.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteQueryOptions
    /// </summary>
    public class DeleteQueryOptions : IOptions<QueryResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteQueryOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteQueryOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}