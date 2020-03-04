/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Supersim.V1;

namespace Twilio.Tests.Rest.Supersim.V1
{

    [TestFixture]
    public class UsageRecordTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Supersim,
                "/v1/UsageRecords",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                UsageRecordResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadAllResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"usage_records\": [{\"period\": {\"start_time\": \"2015-05-01T20:00:00Z\",\"end_time\": \"2015-06-01T20:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": null}],\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/UsageRecords?PageSize=50&Page=0\",\"key\": \"usage_records\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/UsageRecords?PageSize=50&Page=0\"}}"
                                     ));

            var response = UsageRecordResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadAllDayResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"usage_records\": [{\"period\": {\"start_time\": \"2019-05-01T00:00:00Z\",\"end_time\": \"2019-05-03T00:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": null},{\"period\": {\"start_time\": \"2019-05-03T00:00:00Z\",\"end_time\": \"2019-05-04T00:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": null}],\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/UsageRecords?Granularity=day&PageSize=50&Page=0\",\"key\": \"usage_records\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/UsageRecords?Granularity=day&PageSize=50&Page=0\"}}"
                                     ));

            var response = UsageRecordResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadAllHourResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"usage_records\": [{\"period\": {\"start_time\": \"2019-05-01T00:00:00Z\",\"end_time\": \"2019-05-01T01:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": null},{\"period\": {\"start_time\": \"2019-05-01T01:00:00Z\",\"end_time\": \"2019-05-01T02:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": null}],\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/UsageRecords?Granularity=hour&PageSize=50&Page=0\",\"key\": \"usage_records\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/UsageRecords?Granularity=hour&PageSize=50&Page=0\"}}"
                                     ));

            var response = UsageRecordResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadDaySimFilterResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"usage_records\": [{\"period\": {\"start_time\": \"2019-05-01T00:00:00Z\",\"end_time\": \"2019-05-03T00:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": \"HSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},{\"period\": {\"start_time\": \"2019-05-03T00:00:00Z\",\"end_time\": \"2019-05-04T00:00:00Z\"},\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"data_upload\": 1000,\"data_download\": 1000,\"data_total\": 2000,\"sim_sid\": \"HSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}],\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/UsageRecords?Sim=HSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Granularity=day&PageSize=50&Page=0\",\"key\": \"usage_records\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/UsageRecords?Sim=HSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&Granularity=day&PageSize=50&Page=0\"}}"
                                     ));

            var response = UsageRecordResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}