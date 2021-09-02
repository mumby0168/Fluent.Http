using Fluent.Http.Abstractions;
using System;
using System.Net.Http;

namespace Fluent.Http.Requests
{
    public class GetRequestBuilder : BuildableRequest
    {
        public GetRequestBuilder(FluentHttpOptions fluentHttpOptions) : base(HttpMethod.Get, fluentHttpOptions)
        {
        }
        
        public GetRequestBuilder WithUri(Uri uri) => WithUri(uri, this);
        
        public GetRequestBuilder WithUri(string uri) => WithUri(uri, this);
    }
}