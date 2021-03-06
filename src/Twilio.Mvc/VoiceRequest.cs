﻿namespace Twilio.Mvc
{
    /// <summary>
    /// This class can be used as the parameter on your voice action. Incoming parameters will be bound here.
    /// </summary>
    /// <remarks>http://www.twilio.com/docs/api/twiml/twilio_request</remarks>
    public class VoiceRequest : TwilioRequest
    {
        public string CallSid { get; set; }
        public string CallStatus { get; set; }
        public string ApiVersion { get; set; }
        public string Direction { get; set; }
        public string ForwardedFrom { get; set; }
        public string CallerName { get; set; }

        //optional parameters only populated by the Gather or Record verbs
        public string Digits { get; set; }
        public string RecordingUrl { get; set; }
        public string RecordingDuration { get; set; }

        //optional parameters only populated when recording transcription is true
        public string TranscriptionSid { get; set; }
        public string TranscriptionText { get; set; }
        public string TranscriptionStatus { get; set; }
        public string TranscriptionUrl { get; set; }
        public string RecordingSid { get; set; }

        //optional parameters only populated when the <Dial> verb is used to init a call
        public string DialCallStatus { get; set; }
        public string DialCallSid { get; set; }
        public string DialCallDuration { get; set; }
    }
}
