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
using Twilio.Rest.Media.V1.PlayerStreamer;

namespace Twilio.Tests.Rest.Media.V1.PlayerStreamer
{

    [TestFixture]
    public class PlaybackGrantTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers/VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/PlaybackGrant",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlaybackGrantResource.Create("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"grant\": {\"playbackUrl\": \"http://video.net/123/blabla?token=123\",\"playerStreamerSid\": \"VJcafebabecafebabecafebabecafebabe\",\"requestCredentials\": null}}"
                                     ));

            var response = PlaybackGrantResource.Create("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Media,
                "/v1/PlayerStreamers/VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/PlaybackGrant",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PlaybackGrantResource.Fetch("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"url\": \"https://media.twilio.com/v1/PlayerStreamers/VJcafebabecafebabecafebabecafebabe/PlaybackGrant\",\"sid\": \"VJcafebabecafebabecafebabecafebabe\",\"grant\": {\"playbackUrl\": \"http://video.net/123/blabla?token=123\",\"playerStreamerSid\": \"VJcafebabecafebabecafebabecafebabe\",\"requestCredentials\": null}}"
                                     ));

            var response = PlaybackGrantResource.Fetch("VJXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}