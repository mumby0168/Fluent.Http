using Fluent.Http.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Text;

namespace Fluent.Http.Requests
{
    public class PostRequestBuilder : BuildableRequest
    {
        internal PostRequestBuilder(FluentHttpOptions fluentHttpOptions) : base(HttpMethod.Post, fluentHttpOptions)
        {
            
        }

        public PostRequestBuilder WithJsonBody<TBody>(TBody body) => WithJsonBody(body, this);
        
            public PostRequestBuilder WithUri(Uri uri) => WithUri(uri, this);
            
            public PostRequestBuilder WithUri(string uri) => WithUri(uri, this);

    }
}