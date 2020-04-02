/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Environment
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all deployments.
    /// </summary>
    public class ReadDeploymentOptions : ReadOptions<DeploymentResource>
    {
        /// <summary>
        /// The SID of the Service to read the Deployment resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment used by the Deployment resources to read
        /// </summary>
        public string PathEnvironmentSid { get; }

        /// <summary>
        /// Construct a new ReadDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Deployment resources from </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment used by the Deployment resources to read </param>
        public ReadDeploymentOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
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
    /// Retrieve a specific deployment.
    /// </summary>
    public class FetchDeploymentOptions : IOptions<DeploymentResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the Deployment resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment used by the Deployment to fetch
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// The SID that identifies the Deployment resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Deployment resource from </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment used by the Deployment to fetch </param>
        /// <param name="pathSid"> The SID that identifies the Deployment resource to fetch </param>
        public FetchDeploymentOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
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
    /// Create a new deployment.
    /// </summary>
    public class CreateDeploymentOptions : IOptions<DeploymentResource>
    {
        /// <summary>
        /// The SID of the Service to create the Deployment resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment for the deployment
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// The SID of the build for the deployment
        /// </summary>
        public string BuildSid { get; set; }

        /// <summary>
        /// Construct a new CreateDeploymentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Deployment resource under </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment for the deployment </param>
        public CreateDeploymentOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (BuildSid != null)
            {
                p.Add(new KeyValuePair<string, string>("BuildSid", BuildSid.ToString()));
            }

            return p;
        }
    }

}