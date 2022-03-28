﻿using System.Collections.Generic;
using MangoPay.SDK.Core.Deserializers;
using MangoPay.SDK.Core.Enumerations;
using MangoPay.SDK.Entities.GET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers;

namespace MangoPay.SDK.Core
{
    public sealed class MangoPayJsonDeserializer : IDeserializer
    {
        public string DateFormat { get; set; }

        public string Namespace { get; set; }

        public string RootElement { get; set; }

        public T Deserialize<T>(RestResponse response)
        {
            if (typeof(T) != typeof(IdempotencyResponseDTO))
                return JsonConvert.DeserializeObject<T>(response.Content);

            JToken token = JObject.Parse(response.Content);

            var result = new IdempotencyResponseDTO
            {
                StatusCode = (string) token.SelectToken("StatusCode"),
                ContentLength = (string) token.SelectToken("ContentLength"),
                ContentType = (string) token.SelectToken("ContentType"),
                Date = (string) token.SelectToken("Date"),
                RequestURL = (string) token.SelectToken("RequestURL"),
                Resource = token.SelectToken("Resource") != null ? token.SelectToken("Resource").ToString() : ""
            };

            return (T)((object)result);
        }

		public T DeserializeString<T>(object resource)
		{
			return JsonConvert.DeserializeObject<T>((string)resource);
		}
	}

    public sealed class MangoPaySerializer : IRestSerializer
    {
        public MangoPaySerializer()
        {
            Serializer = new MangoPayJsonSerializer();
            Deserializer = new MangoPayJsonDeserializer();
            SupportsContentType = type => true;
        }

        public string Serialize(object obj)
        {
            var ser = new MangoPayJsonSerializer();
            return ser.Serialize(obj);
        }

        public string Serialize(Parameter bodyParameter) => Serialize(bodyParameter.Value);

        public ISerializer Serializer { get; }

        public IDeserializer Deserializer { get; }

        public string[] AcceptedContentTypes { get; } =
        {
            "application/json", "text/json", "text/x-json", "text/javascript", "*+json"
        };

        public SupportsContentType SupportsContentType { get; }

        public DataFormat DataFormat { get; } = DataFormat.Json;
    }
}
