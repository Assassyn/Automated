using System;

namespace Automated.Api
{
    public sealed class ApiCallWithMethod
    {
        private readonly Uri uri;
        private readonly string method;

        internal ApiCallWithMethod(Uri uri, string method)
        {
            this.uri = uri;
            this.method = method;
        }
        public IRequest WithPayload(object payload)
        {
            switch (this.method.ToUpper())
            {
                case "GET":
                case "DELETE":
                    return new JustQueryRequest(this.uri, this.method);
                case "POST":
                    return new WithPayloadRequest(this.uri, this.method, payload);
                default:
                    throw new NullReferenceException("Method does not exist");
            }
        }

        public IRequest Execute()
            => this.WithPayload(string.Empty);
    }
}
