﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProtoTest.Golem.Rest.OAuth
{
    public static class REST_VERB
    {
        public const string GET = "GET";
        public const string POST = "POST";
    }
    public static class Oauth_Signature_Methods
    {
        //enum Signautre_Methods {HMAC_SHA1, RSA_SHA1}
        public const string HMAC_SHA1 = "HMAC-SHA1";
        public const string RSA_SHA1 = "RSA-SHA1";
        public const string VERSION = "1.0";
    }
    public static class OAuth_Token_Keeper
    {
        public static string oauth_token { get; set; }
        public static string oauth_token_secret { get; set; }
        public static string oauth_consumer_key { get; set; }
        public static string oauth_consumer_secret { get; set; }
        public static string oauth_signature_method { get; set; }
        public static string resource_url { get; set; }
    }
    public class OAuth_Request_Builder
    {
        private string resource_URL;
        private string oauth_nonce;
        private string oauth_timestamp;
        private string baseFormat;

        public OAuth_Request_Builder(string URL, string verb)
        {
            resource_URL = URL;
        }



    }

}
