using System;

namespace Automated.Api
{
    internal sealed class JustQueryRequest : IRequest
    {
        private readonly Uri uri;
        private readonly string method;

        internal JustQueryRequest(Uri uri, string method)
        {
            this.uri = uri;
            this.method = method;
        }
        public Response Execute()
        {
            throw new NotImplementedException();
        }
    }
}
