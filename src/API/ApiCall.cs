using System;

namespace Automated.Api
{
    public sealed class ApiCall
    {
        private readonly Uri uri;
        internal ApiCall(Uri baseUri)
        {
            this.uri = baseUri;
        }

        public static ApiCall WithUri(Uri baseUrl)
            => new ApiCall(baseUrl);

        public static ApiCall WithString(string baseUrl)
            => new ApiCall(new Uri(baseUrl));

        public ApiCallWithMethod WithMethod(string method)
            => new ApiCallWithMethod(uri, method);
    }
}
